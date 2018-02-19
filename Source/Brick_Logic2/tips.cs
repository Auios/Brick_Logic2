package Logic_Tips
{
	//tips
	function fxDTSBrick::onActivate(%brick,%player,%client,%globalhitpos,%unitvector)
	{
		parent::onActivate(%brick,%player,%client,%globalhitpos,%unitvector);
		if(%brick.IsLogicBrick)// if it's a logic brick!
		{
			DisplayLogicTips(%brick,%globalHitPos,%client);
		}
	}
	
	//displays Tips and Info on what a particular logic brick does.
	function DisplayLogicTips(%brick,%globalHitPos,%client)
	{
		if(%brick.DontDisplayTips)
		{
			return;
		}
		
		if(%brick.IsWire && $Pref::Server::LogicBricks::ShowWireTips)
		{
			centerPrint(%client,"Value: <color:FFFFFF>" SPC %brick.state, 1);

			//if(%brick.state == 1)
			//{
			//	centerPrint(%client,"<color:00FF00>On",1);
			//}
			//else if(%brick.state == 0)
			//{
			//	centerPrint(%client,"<color:FF0000>Off",1);
			//}
			//else if((%brick.state > 0) && (%brick.state < 1))
			//{
			//	centerPrint(%client,"Power Value: <color:00FF00>" SPC%brick.state,1);
			//}
			//else if(%brick.state > 1)
			//{
			//	centerPrint(%client,"Power Value: <color:00FF00>" SPC%brick.state,1);
			//}
			//else if(%brick.state < 0)
			//{
			//	centerPrint(%client,"Power Value: <color:FF0000>" SPC%brick.state,1);
			//}
		}

		if(%brick.IsGate && $Pref::Server::LogicBricks::ShowGateTips)
		{
			//first we need to which element the raycast was closer to.
			%SmallestDist = 100;
			%closestElement = "";
			%display1 = "False";
			%currcolor = "<color:FF0000>";
			
			%x1 = GetWord(%globalHitPos,0);
			%y1 = GetWord(%globalHitPos,1);
			%z1 = GetWord(%globalHitPos,2);
			
			for(%i = 0; %i < %brick.numPE ; %i++)
			{	
				%x2 = GetWord(%brick.PE[%i].getTransform(),0);
				%y2 = GetWord(%brick.PE[%i].getTransform(),1);
				%z2 = GetWord(%brick.PE[%i].getTransform(),2);
			
				//compare distance
				%dist = mSqrt(mPow((%x2 - %x1),2.0) + mPow((%y2 - %y1),2.0) + mPow((%z2 - %z1),2.0));
				
				if(%dist < %SmallestDist)
				{
					%SmallestDist = %dist;
					%closestElement = %brick.PE[%i];
				}
			}

			for(%i = 0; %i < %brick.numIE ; %i++)
			{	
				%x2 = GetWord(%brick.IE[%i].getTransform(),0);
				%y2 = GetWord(%brick.IE[%i].getTransform(),1);
				%z2 = GetWord(%brick.IE[%i].getTransform(),2);
			
				//compare distance
				%dist = mSqrt(mPow((%x2 - %x1),2.0) + mPow((%y2 - %y1),2.0) + mPow((%z2 - %z1),2.0));

				if(%dist < %SmallestDist)
				{
					%SmallestDist = %dist;
					%closestElement = %brick.IE[%i];
				}
			}

			//if we didnt click close enough to any of the elements, show general gate information
			if(%SmallestDist > 0.3)
			{
				centerPrint(%client, %brick.GateName @ "\n<color:FFFFFF>" @ %brick.TipInfo ,3);
				return;
			}
			
			if(%closestElement.isInputElement)
			{
				if(%closestElement.WG.state == 1)
				{
					%display1 = "On";
					%currcolor = "<color:00FF00>";
				}
				else if(%closestElement.WG.state == 0)
				{
					%display1 = "Off";
					%currcolor = "<color:FF0000>";
				}
				else if(%closestElement.WG.state < 0)
				{
					%display1 = %closestElement.WG.state;
					%currcolor = "<color:FF0000>";
				}
				else
				{
					%display1 = %closestElement.WG.state;
					%currcolor = "<color:00FF00>";
				}
				centerPrint(%client, %brick.GateName @ "\n<color:FFFF00>" @ %closestElement.Name @ ": " @ %currcolor @ %display1,2);
			}
			else if(%closestElement.isPowerElement)
			{	
				if(%closestElement.On == 1)
				{
					%display1 = "On";
					%currcolor = "<color:00FF00>";
				}
				else if(%closestElement.On == 0)
				{
					%display1 = "Off";
					%currcolor = "<color:FF0000>";
				}
				else if(%closestElement.On < 0)
				{
					%display1 = %closestElement.On;
					%currcolor = "<color:FF0000>";
				}
				else
				{
					%display1 = %closestElement.On;
					%currcolor = "<color:00FF00>";
				}
				centerPrint(%client, %brick.GateName @ "\n<color:00FFFF>" @ %closestElement.Name @ ": " @ %currcolor @ %display1,2);
			}
		}
	}
};

activatepackage(Logic_Tips);