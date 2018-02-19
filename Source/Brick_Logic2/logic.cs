//logic.cs

exec("./events.cs");
exec("./refreshSystem.cs");

$LogicBrickSystem::WireGroups = new ScriptGroup(AllWireGroups){};

//Spacetick Connections:
if(!$AddedLogicBricksCtrl)
{
	$SpaceMods::SpaceTick::Controllers = $SpaceMods::SpaceTick::Controllers TAB "LogicBricksCtrl";
	$AddedLogicBricksCtrl = 1;
}

if(!isObject(LogicBricksCtrl))
{
	new SimSet(LogicBricksCtrl){callFn = "LogicBricksCtrlTick";};
}

exec("./globalGateArray.cs");

function LogicBricksCtrlTick()//part of the Global gate Array System.
{
	for(%i = 0; %i < $GlobalGateArray.Gateindx; %i++)
	{
		if(isObject($GlobalGateArray.Gates[%i]))
		{
			if($GlobalGateArray.Gates[%i].Awaitingtick)//only if we need to.
			{
				$GlobalGateArray.Gates[%i].Awaitingtick = 0;
				DoLogic($GlobalGateArray.Gates[%i], $GlobalGateArray.Gates[%i].clickinclient);
			}
		}
	}
}

//ULILS
function GetBricksInBox(%boxcenter, %boxsize, %type, %filterbrick)//returns an array object,filter brick gets passed up..
{
	%arrayobj = new ScriptObject(brickarray);
	%arrayobj.array[0] = 0;
	%arrayobj.count = 0;
	
	InitContainerBoxSearch(%boxcenter, %boxsize, $TypeMasks::fxBrickObjectType | $TypeMasks::StaticShapeObjectType);

	while(%obj = containerSearchNext())
	{
		if(isObject(%obj))
		{
			if(%obj != %filterbrick)
			{
				if(%obj.IsLogicBrick && %obj.IsWire && %type $= "wires")
				{
					%arrayobj.array[%arrayobj.count] = %obj;
					%arrayobj.count++;
				}
				else if(%obj.IsLogicBrick && %obj.IsPowerElement && %type $= "pe")
				{
					%arrayobj.array[%arrayobj.count] = %obj;
					%arrayobj.count++;
				}
				else if(%obj.IsLogicBrick && %obj.IsInputElement && %type $= "ie")
				{
					%arrayobj.array[%arrayobj.count] = %obj;
					%arrayobj.count++;
				}
			}
		}
	}
	return %arrayobj;
}

//put replacementworldbox as 0 when you input a brick, use bricks, ie or pe.
//dir("xpos,xneg etc" or "all" for a useless array of all adj.,types specifies what type like wires
//%frombake returns the baked nieghbors of the object right off the bat.
function GetAdjFromObj(%obj, %dir, %type, %replacementworldbox, %frombake)
{	
	if(!isObject(%obj) && !%replacementworldbox)//if not enough Data is supplied, freak out.
	{
		%boxes = new ScriptObject(brickarray);
		%boxes.array[0] = 0;
		%boxes.count = 0;
		return %boxes;
	}
	
	if(%replacementworldbox)
		%worldbox = %replacementworldbox;

	if(isObject(%obj))
	{
		//kindof a big deal right here.
		if(%frombake)
		{
			%boxes = new ScriptObject(brickarray);
			%boxes.array[0] = 0;
			%boxes.count = 0;

			if(%type $= "wires")
			{
				for(%i = 0; %i < %obj.neighbors.wirearray.count; %i++)
				{
					%boxes.array[%i] = %obj.neighbors.wirearray.array[%i];
				}
				%boxes.count = %obj.neighbors.wirearray.count;
			}
			else if(%type $= "ie")
			{
				for(%i = 0; %i < %obj.neighbors.IEarray.count; %i++)
				{
					%boxes.array[%i] = %obj.neighbors.IEarray.array[%i];
				}
				%boxes.count = %obj.neighbors.IEarray.count;
			}
			else if(%type $= "pe")
			{
				for(%i = 0; %i < %obj.neighbors.PEarray.count; %i++)
				{
					%boxes.array[%i] = %obj.neighbors.PEarray.array[%i];
				}
				%boxes.count = %obj.neighbors.PEarray.count;
			}
		
			return %boxes;
		}
		%worldbox = %obj.getWorldBox();
	}

	%lateralcutoff = 0.4;//cuttof factor for x and y directions. (makes search box slightly smaller)
	%verticalcutoff = 0.055566;
	%xsize = getWord(%worldbox, 3) - getWord(%worldbox, 0);
	%ysize = getWord(%worldbox, 4) - getWord(%worldbox, 1);
	%zsize = getWord(%worldbox, 5) - getWord(%worldbox, 2);
	
	%xcenter = getWord(%worldbox, 0) + %xsize/2;
	%ycenter = getWord(%worldbox, 1) + %ysize/2;
	%zcenter = getWord(%worldbox, 2) + %zsize/2;
	
	switch$(%dir)
	{
		case "xpos":
			%center = ((getWord(%worldbox, 3) + 0.25) SPC %ycenter SPC %zcenter);
			%size = ((0.5 - %lateralcutoff) SPC %ysize - %lateralcutoff SPC %zsize - %verticalcutoff );
			
			%boxes = GetBricksInBox(%center, %size, %type, %obj);
		case "xneg":
			%center = ((getWord(%worldbox, 0) - 0.25) SPC %ycenter SPC %zcenter);
			%size = ((0.5 - %lateralcutoff) SPC %ysize - %lateralcutoff SPC %zsize - %verticalcutoff );
			
			%boxes = GetBricksInBox(%center, %size, %type, %obj);
		case "ypos":
			%center = (%xcenter SPC (getWord(%worldbox, 4) + 0.25) SPC %zcenter);
			%size = ((%xsize - %lateralcutoff) SPC (0.5 - %lateralcutoff) SPC %zsize - %verticalcutoff );
			%boxes = GetBricksInBox(%center, %size, %type, %obj);
		case "yneg":
			%center = (%xcenter SPC (getWord(%worldbox, 1) - 0.25) SPC %zcenter);
			%size = ((%xsize - %lateralcutoff) SPC (0.5 - %lateralcutoff) SPC %zsize - %verticalcutoff );
			%boxes = GetBricksInBox(%center, %size, %type, %obj);
		case "zpos":
			%center = (%xcenter SPC %ycenter SPC (getWord(%worldbox,5) + 0.10));
			%size = ((%xsize - %lateralcutoff) SPC (%ysize - %lateralcutoff) SPC %zsize - %verticalcutoff );
			%boxes = GetBricksInBox(%center, %size, %type, %obj);
		case "zneg":
			%center = (%xcenter SPC %ycenter SPC (getWord(%worldbox,2) - 0.10));
			%size = ((%xsize - %lateralcutoff) SPC (%ysize - %lateralcutoff) SPC %zsize - %verticalcutoff );
			%boxes = GetBricksInBox(%center, %size, %type, %obj);
		
		case "all":
			%xposbricks = GetAdjFromObj(%obj, "xpos", %type, %replacementworldbox);
			%xnegbricks = GetAdjFromObj(%obj, "xneg", %type, %replacementworldbox);
			%yposbricks = GetAdjFromObj(%obj, "ypos", %type, %replacementworldbox);
			%ynegbricks = GetAdjFromObj(%obj, "yneg", %type, %replacementworldbox);
			%zposbricks = GetAdjFromObj(%obj, "zpos", %type, %replacementworldbox);
			%znegbricks = GetAdjFromObj(%obj, "zneg", %type, %replacementworldbox);
			
			%boxes = new ScriptObject(brickarray);
			%boxes.array[0] = 0;
			%boxes.count = 0;
			
			for(%i = 0; %i < %xposbricks.count; %i++)
			{
				%boxes.array[%boxes.count] = %xposbricks.array[%i];
				%boxes.count++;	
			}
			
			for(%i = 0; %i < %xnegbricks.count; %i++)
			{
				%boxes.array[%boxes.count] = %xnegbricks.array[%i];
				%boxes.count++;
			}
			
			/////////////////////////////////////////////////////////
			for(%i = 0; %i < %yposbricks.count; %i++)
			{
				%boxes.array[%boxes.count] = %yposbricks.array[%i];
				%boxes.count++;
			}

			for(%i = 0; %i < %ynegbricks.count; %i++)
			{
				%boxes.array[%boxes.count] = %ynegbricks.array[%i];
				%boxes.count++;	
			}

			/////////////////////////////////////////////////////////
			for(%i = 0; %i < %zposbricks.count; %i++)
			{
				%boxes.array[%boxes.count] = %zposbricks.array[%i];
				%boxes.count++;	
			}	

			for(%i = 0; %i < %znegbricks.count; %i++)
			{
				%boxes.array[%boxes.count] = %znegbricks.array[%i];
				%boxes.count++;				
			}

			%xposbricks.delete();
			%xnegbricks.delete();
			%yposbricks.delete();
			%ynegbricks.delete();
			%zposbricks.delete();
			%znegbricks.delete();
	}
	return %boxes;
}

//WIREGROUPS

function CreateWireGroup(%startbrick) //starts with nothing other than the startbrick AUTOMATICALLY LINKS BOTH WAYS
{
	%WG = new ScriptObject(WireGroup)
	{
		WB[0] = 0;
		WBindx = 0;//also serves as numberofbricks.
		
		IE[0] = 0;
		IEindx = 0;
		
		PE[0] = 0;
		PEindx = 0;
	
		state = 0;
	};
	$LogicBrickSystem::WireGroups.add(%WG);
	//echo("Wiregroup" SPC %WG SPC "Created");
	%WG.AttachWire(%startbrick); //both ways....
	return %WG;
}

function WireGroup::AttachWire(%this, %wirebrick)
{
	if(isObject(%wirebrick))
	{
		if(%wirebrick.IsWire)
		{
		%this.WB[%this.WBindx] = %wirebrick;
		%this.WBindx++;
		%wirebrick.WG = %this;
		//echo("Brick" SPC %wirebrick SPC "Linked To WireGroup:" SPC %this);
		}
		if(%wirebrick.IsInputElement)
		{
			%this.IE[%this.IEindx] = %wirebrick;
			%this.IEindx++;
			%wirebrick.WG = %this;
			//echo("Input Element" SPC %wirebrick SPC "Linked To WireGroup:" SPC %this);
		}
	}
}

function RegisterNewWireBrick(%wirebrick)//decides whether to make a new WG or inherit a adjacent one.
{
	//if we already have a WG object - we have been touched by another proccess already (due to duplicator most likely)
	if(isObject(%wirebrick.WG))
	{
		return;
	}
	%AdjWires = GetAdjFromObj(%wirebrick, "all", "wires",0,1); //must have baked before this function!
	%AdjIE = GetAdjFromObj(%wirebrick, "all", "ie",0,1);
	
	//adjacent inheritence
	%noadjWG = 1;
	for(%i=0;%i < %AdjWires.count;%i++)
	{
		if(isObject(%AdjWires.array[%i].WG) && ColorMatch(%wirebrick, %AdjWires.array[%i]))//adjacent inheritence
		{
			
			SpreadWireGroup(%AdjWires.array[%i]);
			%AdjWires.array[%i].WG.SuggestUpdateState(1);
			%noadjWG = 0;
			%i = %AdjWires.count;
		}
	}
	
	for(%j=0;%j < %AdjIE.count;%j++)
	{
		if(isObject(%AdjIE.array[%j].WG) && !SameGate(%wirebrick, %AdjIE.array[%j]))//adjacent inheritence
		{
		SpreadWireGroup(%AdjIE.array[%j]);
		%AdjIE.array[%j].WG.SuggestUpdateState(1);
		%noadjWG = 0;
		%j = %AdjIE.count;
		}
	}

	if(%noadjWG)//no adj WG links, lets start the first one!
	{
		CreateWireGroup(%wirebrick);//linked up.
		SpreadWireGroup(%wirebrick);//spreads around
		%wirebrick.WG.SuggestUpdateState(1,0);
	}
	
	//we dont need AdjWires and IE object anymore.
	%AdjWires.delete();
	%AdjIE.delete();
}

function SpreadWireGroup(%wirebrick)//on the wire brick.
{
	%AdjWires = GetAdjFromObj(%wirebrick, "all", "wires",0,1);
	%AdjPE = GetAdjFromObj(%wirebrick, "all", "pe",0,1);
	%AdjIE = GetAdjFromObj(%wirebrick, "all", "ie",0,1);
	
	for(%a = 0;%a < %AdjWires.count; %a++)
	{
		%nextbrick = %AdjWires.array[%a];
			if(%nextbrick.WG == %wirebrick.WG)//if the WG is the Same, dont go on.
			{
				//try a different adj brick.
			}
			else
			{
				if(ColorMatch(%wirebrick, %nextbrick))
				{
					%wirebrick.WG.AttachWire(%nextbrick);
					SpreadWireGroup(%nextbrick);
				}
			}
	}

	//ie's
	for(%i = 0;%i < %AdjIE.count; %i++)
	{
		%nextIE = %AdjIE.array[%i];
		
			if((%nextIE.WG == %wirebrick.WG) || SameGate(%wirebrick, %nextIE))//if the WG is the Same, dont go on.
			{
				//try a different adj brick.
			}
			else
			{
				%wirebrick.WG.AttachWire(%nextIE);
				SpreadWireGroup(%nextIE);
			}
	}
	//check PE
	for(%p = 0;%p < %AdjPE.count; %p++)
	{
		%nextPE = %AdjPE.array[%p];
		RefreshPE(%nextPE);
	}
	
	%AdjWires.delete();
	%AdjPE.delete();
	%AdjIE.delete();
}

function WireGroup::SuggestUpdateState(%this, %override, %client)
{
	//loop through all connected power elements and see if any are on- if 1 or more are on, we set state to the largest value
	%count = 0;
	%largestVal = -999999.9;

	for(%p=0;%p<%this.PEindx;%p++)
	{
		if(%this.PE[%p].On)
		{	
			%count++;

			if(%this.PE[%p].On > %largestval)
			{
				%largestVal = %this.PE[%p].On;
			}
		}
	}

	if(%count)
	{		
		%this.UpdateState(%largestVal, %override, %client);	
	}
	else
	{
		%this.UpdateState(0, %override, %client);	
	}

    //for(%p=0;%p<%this.PEindx;%p++)
    //{
    //    if(%this.PE[%p].On)
    //    {    
    //        %this.UpdateState(1, %override, %client);
    //        return;
    //    }
    //}
    //%this.UpdateState(0, %override, %client);
}

function WireGroup::UpdateState(%this, %st, %override, %client)
{
	//we dont need to switch states if were switching to the same state
	if((%this.state != %st) || %override)
	{
		%this.state = %st;
		%this.DoBrickVisual(%client); //colorfx stuff
		%this.DoEvents(%client);
		%this.TriggerIES(%client); //Suggest that the Gates get updated
	}
}

function WireGroup::TriggerIES(%this, %client)
{
	for(%i=0;%i<%this.IEindx;%i++)
	{
		if(!%this.IE[%i].NOTRIG)//if its not trigerable - we cant proccess the gate from this ie.
		{
			if(%this.IE[%i].gate.ISINSTANT)//if it is an instant gate.
			{
				DoLogic(%this.IE[%i].gate, %client);
			}
			else//if it is a standard delayed gate - most gates.
			{
				%this.IE[%i].gate.AwaitingTick = 1;
				%this.IE[%i].gate.clickinclient = %client;
			}
		}
	}
}

function WireGroup::DoBrickVisual(%this, %client)//call only by updatestate!!!
{
	for(%b=0;%b<%this.WBindx;%b++)
	{
		if(isObject(%this.WB[%b]))//this "Bypasses" the issue with the duplicator planting fake bricks, and them being inserted into the array..
		{
			if(%this.WB[%b].colorFxID != 6)//for rainbow seams
			{	
				%this.WB[%b].LogicVisTriggered = 1; //for ::setcolorfx to not freak out

				if(%this.state > 0)
				{
					%this.WB[%b].setColorFX(3);
				}

				if(%this.state < 0)
				{
					%this.WB[%b].setColorFX(5);
				}

				if(%this.state == 0)
				{
					%this.WB[%b].setColorFX(0);
				}
			}
		}
	}
}

function WireGroup::DoEvents(%this, %client)//this only proccesses the events if the bricks old state differes from new state.
{
	for(%b=0;%b<%this.WBindx;%b++)
	{
		if(isObject(%this.WB[%b]))//this "Bypasses" the issue with the duplicator planting fake bricks, and them being inserted into the array..
		{
			%oldstate = %this.WB[%b].state;
			%this.WB[%b].state = %this.state;
			if(%oldstate != %this.state)
			{	
				%this.WB[%b].onPowerChange(%client);
			}
			if((%oldstate == 0) && (%this.state != 0))
			{	
				%this.WB[%b].onPowerOn(%client);
			}
			if((%oldstate != 0) && (%this.state == 0))
			{	
				%this.WB[%b].onPowerOff(%client);
			}
		}
	}
}

//Gates, PowerElements, and InputElements
function CalcPositionOfElement(%startbrick, %localpos)
{
	%upvec = "1 0 0";
	
	%brickfroward = %startbrick.getforwardvector();
	%bricktheta = -mAcos((vectordot(%upvec, %brickfroward))/(vectorlen(%upvec)*vectorlen(%brickfroward)));

	if(getWord(%brickfroward,1)<1)
	{
		%bricktheta = %bricktheta - 3.14;
	}

	%oldx = getWord(%localpos,0);
	%oldy = getWord(%localpos,1);
	
	%newX = %oldx*mCos(%bricktheta) - %oldy*mSin(%bricktheta);
	%newY = %oldx*mSin(%bricktheta) + %oldy*mCos(%bricktheta);

	%newlocalpos = %newX SPC %newY SPC getWord(%localpos,2);
	%newglobalpos = vectoradd(%startbrick.getWorldboxcenter(), %newlocalpos);
	
	return (%newglobalpos);
}

function CreatePowerElement(%startbrick, %localpos, %scale)
{
	%GlobalPosition = CalcPositionOfElement(%startbrick, %localpos);

	%PE = new StaticShape()
	{
		dataBlock = "LogicElementShapeData";
		position = %globalPosition;
		rotation = "1 0 0 0";
		scale = %scale;
		IsLogicBrick = 1;
		IsPowerElement = 1;
		WG[0] = 0;
		WGindx = 0;
		On = 0;
		gate = %startbrick;
	};

	return %PE;
}

function CreatePowerElementVisual(%startbrick, %localpos, %scale)
{
	%GlobalPosition = CalcPositionOfElement(%startbrick, %localpos);
	%PEv = new StaticShape()
	{
		dataBlock = "PowerElementVisualData";
		position = %globalPosition;
		rotation = "1 0 0 0";
		scale = %scale;
		gate = %startbrick;
	};

	return %PEv;
}

function AttachWGtoPE(%WG, %PE)
{
	//check if its already listed
	for(%a=0; %a < %PE.WGindx; %a++)
	{
		if(%PE.WG[%a] == %WG)
		{
			return 0;
		}
	}
	
	%WG.PE[%WG.PEindx] = %PE;
	%WG.PEindx++;
	%PE.WG[%PE.WGindx] = %WG;
	%PE.WGindx++;	
	//echo("Wiregroup" SPC %WG SPC "Linked To Power Element:" SPC %PE);
}

function SetPEPowered(%PE, %pow, %client)
{
	//%PE.On = %pow && 1;
	%PE.On = %pow;
	for(%w=0;%w<%PE.WGindx;%w++)
	{	
		if(isObject(%PE.WG[%w]))
		{
			%PE.WG[%w].SuggestUpdateState(0, %client);
		}
	}
}

function CreateInputElement(%startbrick, %localpos, %scale)
{
	
	%GlobalPosition = CalcPositionOfElement(%startbrick, %localpos);
	%IE = new StaticShape()
	{
		dataBlock = "LogicElementShapeData";
		position = %globalPosition;
		rotation = "1 0 0 0";
	    scale = %scale;
		IsLogicBrick = 1;
		IsInputElement = 1;
		WG = 0;
		gate = %startbrick;
	};
	
	return %IE;
}

function CreateInputElementVisual(%startbrick, %localpos, %scale)
{
	%GlobalPosition = CalcPositionOfElement(%startbrick, %localpos);
	%IEv = new StaticShape()
	{
		dataBlock = "InputElementVisualData";
		position = %globalPosition;
		rotation = "1 0 0 0";
	    scale = %scale;
		gate = %startbrick;
	};

	return %IEv;
}

function RefreshPE(%PE)//connections
{
	//clear out the wg array on pe first.
	for(%a=0;%a<%PE.WGindx;%a++)
	{
		%PE.WG[%a] = 0;
	}

	%PE.WGindx = 0;
	
	//look for wire/wire groups
	%AdjWires = GetAdjFromObj(%PE, "all", "wires",0,1);
	
	for(%b=0; %b < %AdjWires.count;%b++)//then we have wires adjacent - lets update
	{	
		AttachWGtoPE(%AdjWires.array[%b].WG, %PE);//should link both ways.
	}
	
	%AdjIE = GetAdjFromObj(%PE, "all", "ie",0,1);

	for(%c=0;%c < %AdjIE.count;%c++)//then we have wires adjacent - lets update
	{	if(!SameGate(%PE, %AdjIE.array[%c]))
		{
			AttachWGtoPE(%AdjIE.array[%c].WG, %PE);//should link both ways.
		}
	}
	
	//then we update signal from the PE
	SetPEPowered(%PE, %PE.On,0);
	
	%AdjWires.delete();
	%AdjIE.delete();
}

function RegisterNewGateBrick(%gatebrick)//decides whether to make a new WG or inherit a adjacent one.
{
	//add the gate to the global gate array
	$GlobalGateArray.AddGate(%gatebrick);
	
	for(%a = 0;%a < %gateBrick.numPE;%a++)//PE
	{
		BakeNeighbors(%gateBrick.PE[%a],1);
		RefreshPE(%gateBrick.PE[%a]);
	}
	for(%i = 0;%i < %gateBrick.numIE;%i++)//IE
	{
		BakeNeighbors(%gateBrick.IE[%i],1);
		RegisterNewWireBrick(%gateBrick.IE[%i]);
	}
}

function PrepareGateForDeletion(%this, %final)//%final states that we want to remove it from the list also! (to differentiate from ondeath and onremove.
{
	//remove all the PE's and IE's..
	for(%p=0;%p<%this.numPE;%p++)
	{
		BakeNeighbors(%this.PE[%p],1);
		%this.PE[%p].delete();

		if(isObject(%this.PEv[%p]))
		{
			%this.PEv[%p].delete();
		}
	}
	for(%i=0;%i<%this.numIE;%i++)
	{
		BakeNeighbors(%this.IE[%i],1);
		%this.IE[%i].delete();
		%this.IEv[%i].delete();
	}
	
	%this.numPE = 0;
	%this.numIE = 0;
	
	if(%final)
	{
		$GlobalGateArray.RemoveGate(%this);//remove from master list.
	}
}

/////////////////////////////////GENERIC/////////////////////////////////////////////////////

function ColorMatch(%brick1, %brick2)
{
	if(%brick1.IsInputElement || %brick2.IsInputElement)
	{
		return 1;
	}

	if((%brick1.colorFxID == 6) || (%brick2.colorFxID == 6))//rainbow seams
	{
		return 1;
	}

	if(%brick1.colorid == %brick2.colorid)
	{
		return 1;
	}
	
	return 0;
}

function RefreshAroundBlankBox(%brickbox)//updates WG's around the perimeter 
{
	//echo("refreshing");
	
	%AdjWires = GetAdjFromObj(0, "all", "wires", %brickbox,0);
	%AdjPE = GetAdjFromObj(0, "all", "pe", %brickbox,0);
	%AdjIE = GetAdjFromObj(0, "all", "ie", %brickbox,0);
	
	for(%a=0;%a<%AdjWires.count;%a++)
	{
		BakeNeighbors(%AdjWires.array[%a],0);//this refreshes the baked stuff around the area.
		%AdjWires.array[%a].oldWGid = %AdjWires.array[%a].WG.getid();//give a new int variable to each brick declaring what its original WG id was.
	}

	for(%b=0;%b<%AdjPE.count;%b++)
	{
		BakeNeighbors(%AdjPE.array[%b],0);
	}

	for(%c=0;%c<%AdjIE.count;%c++)
	{
		BakeNeighbors(%AdjIE.array[%c],0);//this refreshes the baked stuff around the area.
	}
	
	for(%b=0;%b<%AdjWires.count;%b++)
	{	
		
		%currWire = %adjWires.array[%b];
		
		if(%currWire.WG.getid() == %currWire.oldWGid)
		{
			CreateWireGroup(%currWire);
			SpreadWireGroup(%currWire);
			%currWire.WG.SuggestUpdateState(1);//update the state
		}
	}
	
	//now lets worry about Pe's and IE's
	for(%c=0;%c<%AdjPE.count;%c++)
	{
		RefreshPE(%AdjPE.array[%c]);
	}
	
	for(%d=0;%d<%AdjIE.count;%d++)//treat same as wire
	{
		%currie = %adjIE.array[%d];
		
		CreateWireGroup(%currie);
		SpreadWireGroup(%currie);
		%currie.WG.SuggestUpdateState(1);//update the state
	}
	
	//no use anymore
	%AdjWires.delete();
	%AdjPE.delete();
	%AdjIE.delete();
}

function BakeNeighbors(%obj, %repeating)//obj can be Wire, IE, or PE
{
	%obj.neighbors = new ScriptObject(NeighborPack)	// every wire brick, ie and pe should have this data set.
	{
		wirearray = GetAdjFromObj(%obj, "all", "wires",0,0); //not from bake of course.
		
		IEarray = GetAdjFromObj(%obj, "all", "ie",0,0); //not from bake of course.

		PEarray = GetAdjFromObj(%obj, "all", "pe",0,0); //not from bake of course.
	};
	
	//echo("BakedNeighbors on" SPC %obj);
	
	if(!%repeating)
	{
		return;
	}
	
	//now we need our new neighbors to know about this brick too.
	%adjwires = GetAdjFromObj(%obj, "all", "wires",0,1);//this time prebaked.
	%adjie = GetAdjFromObj(%obj, "all", "ie",0,1);//this time prebaked.
	%adjpe = GetAdjFromObj(%obj, "all", "pe",0,1);//this time prebaked.
	
	for(%a = 0;%a < %adjwires.count;%a++)
	{
		BakeNeighbors(%adjwires.array[%a],0);
	}
	
	for(%b = 0;%b < %adjie.count;%b++)
	{
		BakeNeighbors(%adjie.array[%b],0);
	}
	
	for(%c = 0;%c < %adjpe.count;%c++)
	{
		BakeNeighbors(%adjpe.array[%c],0);
	}
	%adjwires.delete();
	%adjie.delete();
	%adjpe.delete();
}

function SameGate(%obj1, %obj2)
{
	if(!(isObject(%obj1.Gate) && isObject(%obj2.Gate)))
	{
		//echo("Call Same Gate with objects that have a gate...");
		return 0;
	}

	if(%obj1.Gate.getid() == %obj2.Gate.getid())
	{
		return 1;
	}
	else
	{	
		return 0;
	}
	echo("Shouldnt go this far...");
}

//for input events
function fxDTSBrick::onPowerChange(%this, %inclient)
{
	%client = %inclient;

	if(%this.IsLogicBrick && %this.IsWire)
	{
		
		$InputTarget_["Self"] = %this;
		if(!isObject(%client))
		{
			%client = %this.getGroup().client;
		}
		
		$InputTarget_["Client"] = %client;
		$InputTarget_["Player"] = %client.player;
		
		//process the event
		//we need to pass a client object to this, thats why the if statement is above.
		%this.processInputEvent("onPowerChange", %client);
		
		//do cool stuff for print bricks
		if(%this.getDatablock().hasPrint)
		{
			%val = mAbs(%this.state);

			if(%val <= 9)
			{
				%val = mFloatLength(%val, 0); 
				%this.setPrintCount(%val);
			}
			else
			{
				%this.setPrint(72);
			}
		}
	}
}

function fxDTSBrick::onPowerOn(%this, %inclient)
{
	if(%this.IsLogicBrick && %this.IsWire)
	{
		
		$InputTarget_["Self"] = %this;
		if(!isObject(%inclient))
		{
			%inclient = %this.getGroup().client;
		}
		
		$InputTarget_["Client"] = %inclient;
		$InputTarget_["Player"] = %inclient.player;
		
		//process the event
		//we need to pass a client object to this, thats why the if statement is above.
		%this.processInputEvent("onPowerOn", %inclient);
	}
}

function fxDTSBrick::onPowerOff(%this, %inclient)
{
	%client = %inclient;
	if(%this.IsLogicBrick && %this.IsWire)
	{
		
		$InputTarget_["Self"] = %this;
		if(!isObject(%client))
		{
			%client = %this.getGroup().client;
		}
		
		$InputTarget_["Client"] = %client;
		$InputTarget_["Player"] = %client.player;
		
		//process the event
		//we need to pass a client object to this, thats why the if statement is above.
		%this.processInputEvent("onPowerOff", %client);
	}
}

//base function to be overwritten by individual logic Gates
//this is for user created powered bricks..with events.
function fxDTSBrickData::DoLog(%data, %gate, %statestack, %client)
{
	%out = %statestack.outs[0];
	SetPEPowered(%gate.PE[0], %out, %client);
}

//Gate Specific Functions.
function DoLogic(%gate, %client)
{	
	%gate.busy = 0;//open the gate up for more tick opertunities.
	
	//current input values
	%statestack = new ScriptObject(inputstack);
	
	//before the bricks particular logic function, we need to package in/outs into the statestack
	for(%i = 0; %i < %gate.getdatablock().numIE; %i++)
	{
		%statestack.ins[%i] = %gate.IE[%i].WG.state;
	}
	
	for(%i = 0; %i < %gate.getdatablock().numPE; %i++)
	{
		%statestack.outs[%i] = %gate.PE[%i].on;
	}
	
	
	//call the brick individual logic function passing the state stack!
	%gate.getdatablock().DoLog(%gate, %statestack, %client);
	%statestack.delete();
	
	//store values in the input elements for memory next time.
	//usefull for flip-flops and such.
	for(%i = 0; %i < %gate.getdatablock().numIE; %i++)
	{
		%gate.IE[%i].previousState = %gate.IE[%i].WG.state;
	}
}

//////////////////////////////////////////////////////////////
//fxbrick functions
/////////////////////////////////////////////////////////

//generic function to get wire value.
function fxDTSBrick::GetWirePower(%this)
{
	if(%this.IsLogicBrick && %this.IsWire)
	{
		return(%this.WG.state);
	}
	else
	{
		return(0);
	}
}

//for output event
function fxDTSBrick::SetPower(%this, %pow, %client)
{	
	//When we use this Event We can convert regular bricks into powered bricks too!
	if(!%this.IsLogicBrick)
	{
		%this.IsLogicBrick = 1;
		%this.IsGate = 1;
		%this.GateName = "Powered Brick";
		%this.DontDisplayTips = 1;
		
		//first put one streached powerelement on the brick.
		//calc size
		%xs = getWord(%this.getWorldBox(),3) - getWord(%this.getWorldBox(),0);
		%ys = getWord(%this.getWorldBox(),4) - getWord(%this.getWorldBox(),1);
		%zs = getWord(%this.getWorldBox(),5) - getWord(%this.getWorldBox(),2);

		%this.numPE = 1;
		%this.PE[0] = CreatePowerElement(%this, "0 0 0", %xs SPC %ys SPC %zs);
	
		RegisterNewGateBrick(%this);
	}
	
	if(%this.IsLogicBrick && %this.IsGate)
	{
		%p = 0;
		//see if we can get variable input from the replacement system on VCE
		if($VCE::Server::Version && ($AddOn__Event_Variables == 1))
		{
			%p = filterVariableString(%pow, %this, %client, %client.player, "");
		}
		else
		{
			%p = %pow;
		}

		%this.PE[0].on = %p;
		//wait until next tick. (Just like any other logic brick)
		%this.AwaitingTick = 1;
		%this.clickinclient = %client;
	}
}

function fxDTSBrick::SetIsWire(%this, %on, %client)
{
	if(%this.isLogicBrick && %this.isGate)
	{
		//echo("Converting from Gate to wire brick...");
		
		PrepareGateForDeletion(%this,1);
		
		//we need to use the $deletion box this will update the wiregroups and do a update state.
		$GlobalRefreshSystem.AddBox(%this.getWorldBox());
		$GlobalRefreshSystem.SuggestWipe();
		
		%this.isLogicBrick = true;
		%this.isWire = true;
		PlantMerger(%this.data, %this,0);
		
		return 0;
	}
	
	if(%on)
	{	
		//make sure we are not already a wire...
		if(%this.isLogicBrick && %this.isWire)
		{
			return;
		}
	
		%this.isLogicBrick = true;
		%this.isWire = true;
		PlantMerger(%this.data, %this,0);
	}
	else
	{
		%this.isLogicBrick = false;
		%this.isWire = false;
		
		//COPIED FROM ONDEATH.
		$GlobalRefreshSystem.AddBox(%this.getWorldBox());
		$GlobalRefreshSystem.SuggestWipe();
	}
}

function PlantMerger(%data, %this, %onload)
{
	if(%data.IsLogicBrick || %this.IsLogicBrick)//this is for the setiswire event that will call this after the brick exsists
	{
		%this.IsLogicBrick = true;
		%this.justloaded = %onload;

		if(%data.IsWire || %this.IsWire)
		{
			%this.IsWire = true;
			%this.state = 0;
			%this.WG = null;
			
			BakeNeighbors(%this,1);

			if(%onload)
			{
				RegisterNewWireBrick(%this);
			}
			else
			{
				RegisterNewWireBrick(%this);
			}
		}

		if(%data.IsGate)
		{
			%this.IsGate = true;
			%this.GateName = %data.GateName;
			%this.DontDisplayTips = %data.DontDisplayTips;
			%this.TipInfo = %data.TipInfo;
			
			%this.ISINSTANT = %data.ISINSTANT;
			
			%this.numPE = %data.numPE;
			%this.numIE = %data.numIE;
			
			for(%p=0;%p<%this.numPE;%p++)
			{
				%this.PE[%p] = CreatePowerElement(%this, %data.PEPos[%p], %data.PEScale[%p]);
				%this.PE[%p].Name = %data.PEName[%p];

				if(!%data.PENoRender[%p])
				{
					%this.PEv[%p] = CreatePowerElementVisual(%this, %data.PEpos[%p], %data.PEScale[%p]);
				}
				%this.PE[%p].On = %data.PEStart[%p];
			}
			
			for(%i=0;%i<%this.numIE;%i++)
			{
				%this.IE[%i] = CreateInputElement(%this, %data.IEpos[%i], %data.IEScale[%i]);
				%this.IE[%i].NOTRIG = %data.IENOTRIG[%i];//just in case the input is not trigerable.
				%this.IE[%i].Name = %data.IEName[%i];

				if(!%data.IENoRender[%p])
				{
					%this.IEv[%i] = CreateInputElementVisual(%this, %data.IEpos[%i], %data.IEScale[%i]);
				}
			}
			RegisterNewGateBrick(%this);
		}
	}
}

function ShowVisualElements(%brick)
{
	for(%i = 0; %i < %brick.numPE; %i++)
	{
		%brick.PEv[%i].setHidden(0);	
	}

	for(%i = 0; %i < %brick.numIE; %i++)
	{
		%brick.IEv[%i].setHidden(0);	
	}
}

function getMinBits(%n)
{
	return mceil(mlog(%n)/mlog(2)+0.00001);
}

function not(%n)
{
	return %n ^ (( 1 << getMinBits(%n)) -1);
}

package Logic2_System
{
	//This Makes it so an OnPlant doesnt have to be specified for every kind of brick.
	function fxDTSBrickData::onplant(%data, %this)
	{
		Parent::onPlant(%this);
		PlantMerger(%data, %this, 0);
	}

	function fxDTSBrickData::onloadplant(%data, %this)
	{
		Parent::onloadPlant(%this);
		PlantMerger(%data, %this, 1);
	}

	function fxDTSBrickData::onDeath(%data, %this)
	{
		Parent::onDeath(%this);
		if(%this.IsLogicBrick)
		{
			if(%this.IsGate)
				PrepareGateForDeletion(%this, 0);
			
			//we need to use the $deletion box this will update the wiregroups and do a update state.
			$GlobalRefreshSystem.AddBox(%this.getWorldBox());
			$GlobalRefreshSystem.SuggestWipe();
		}
	}

	function fxDTSBrickData::onRemove(%data, %this)//when removing (like when clearing all bricks - we want to make sure power elements and ie's are gone.
	{
		Parent::onRemove(%this);
		if(%this.IsLogicBrick && %this.IsGate)
		{
			PrepareGateForDeletion(%this, 1);
		}
	}

	function fxDTSBrick::SetColorFX(%this, %colorfx)
	{
		%origid = %this.colorFxID;
		Parent::SetColorFX(%this, %colorfx);
		
		if(%this.IsLogicBrick && %this.IsWire)
		{	
			if((%origid != %colorfx) && (!%this.LogicVisTriggered))
			{
				if(%this.oldColorid !$= "")
				{
					if(%this.fill)//for fillcan, we want to put off some of the work until later.
					{
						$GlobalRefreshSystem.AddBox(%this.getWorldBox());
						$GlobalRefreshSystem.SuggestWipe();
					}
					else
					{
						RefreshAroundBlankBox(%this.getWorldBox(), %this);
						//%this.WG.SuggestUpdateState(1,0);
					}
				}
			}

			if(%this.LogicVisTriggered)
				%this.LogicVisTriggered = 0;
		}
	}

	function fxDTSBrickData::onColorChange(%data, %this)
	{
		Parent::onColorChange(%data, %this);
		if(%this.IsLogicBrick && %this.IsWire)
		{
			
			//better way to do this????
			if(%this.oldColorid !$= "")//this was due to the color changing on duplication selection.
			{
				%this.colorid = %this.oldcolorid;//the white color that happens when duplicating through colormatchin wack.
				return;
			}

			if(%this.fill)//for fillcan, we want to put off some of the work until later.
			{
				$GlobalRefreshSystem.AddBox(%this.getWorldBox());
				$GlobalRefreshSystem.SuggestWipe();
			}
			else
			{
				%this.WG = 0;
				RegisterNewWireBrick(%this);
				RefreshAroundBlankBox(%this.getWorldBox(), %this);
			}
		}
	}

	function fxDTSBrick::onFakeDeath(%this)
	{
		Parent::onFakeDeath(%this);
		if(%this.IsLogicBrick && %this.IsGate)//clear the visual elements
		{
			for(%i = 0; %i < %this.numPE; %i++)
			{
				%this.PEv[%i].setHidden(1);
			}
			
			for(%i = 0; %i < %this.numIE; %i++)
			{
				%this.IEv[%i].setHidden(1);
			}
		}
	}

	function fxDTSBrick::onClearFakeDeath(%this)
	{
		Parent::onClearFakeDeath(%this);//reapear the visual elements
		if(%this.IsLogicBrick && %this.IsGate)
			schedule(1000, 0, "ShowVisualElements", %this);
	}
};
activatePackage("Logic2_System");
