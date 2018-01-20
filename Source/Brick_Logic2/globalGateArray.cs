//globalGateArray.cs

if(!isObject($GlobalGateArray))
{
	$GlobalGateArray = new ScriptObject(GlobalGateArray)
	{
		Gates[0] = "";
		Gateindx = 0;
	};
}

function GlobalGateArray::AddGate(%this, %gate)
{
	if(%gate.IsLogicBrick && %gate.IsGate)
	{
		%this.Gates[%this.Gateindx] = %gate;
		%gate.Arrayindx = %this.Gateindx;
		%this.Gateindx++;
		//Echo("Gate" SPC %gate SPC "Added to GlobalGateArray");
	}
}

function GlobalGateArray::RemoveGate(%this, %gate)
{
	%this.print();
	if(%gate.IsLogicBrick && %gate.IsGate)
	{
		%lastIndx = %this.Gateindx-1;

		%this.Gates[%gate.Arrayindx] = %this.Gates[%lastIndx];
		%this.Gates[%lastIndx].Arrayindx = %gate.Arrayindx;
		%this.Gates[%lastIndx] = "";
		%this.Gateindx--;
	}
	%this.print();
}

function GlobalGateArray::Print(%this)
{
	echo("-----------");
	for(%i = 0; %i < %this.Gateindx; %i++)
	{
		echo(%this.Gates[%i].Arrayindx, " - ", %this.Gates[%i], " - ", %this.Gates[%i].getDatablock().getName());
	}
}

function GlobalGateArray::Clear(%this)
{
	for(%i = 0; %i < %this.Gateindx; %i++)
	{
		%this.Gates[%i] = "";
	}
	%this.Gateindx = 0;
	//Echo("GlobalGateArrayCleared");
}
