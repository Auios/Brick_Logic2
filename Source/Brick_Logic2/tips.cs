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
			centerPrint(%client,"Value:<color:FFFFFF>" SPC %brick.state, 1);
			return;
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
				centerPrint(%client, %brick.GateName @ "\n<color:FFFF00>" @ %closestElement.Name @ ": <color:ffffff>" @ %closestElement.WG.state,2);
			}
			else if(%closestElement.isPowerElement)
			{	
				centerPrint(%client, %brick.GateName @ "\n<color:00FFFF>" @ %closestElement.Name @ ": <color:ffffff>" @ %closestElement.On,2);
			}
		}
	}
};

activatepackage(Logic_Tips);