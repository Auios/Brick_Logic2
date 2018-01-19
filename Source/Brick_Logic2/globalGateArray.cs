//globalGateArray.cs

$GlobalGateArray = new ScriptObject(GlobalGateArray)
{
	Gates[0] = "";
	GateIndx = 0;
	
	ReferenceHoles = 0;//when logic bricks are deleted, instead of refreshing the array,  we use this to keep track of how many null spaces are in the array..
	MaxHoles = 20;
};

function GlobalGateArray::AddGate(%this,%gate)
{
	if(%gate.IsLogicBrick && %gate.IsGate)
	{
		%this.Gates[%this.Gateindx] = %gate;
		%gate.Arrayindx = %this.Gateindx;
		%this.Gateindx++;
		//Echo("Gate" SPC %gate SPC "Added to GlobalGateArray");
	}
}
function GlobalGateArray::RemoveGate(%this,%gate)
{
	if(%gate.IsLogicBrick && %gate.IsGate)
	{
		%this.Gates[%gate.Arrayindx] = "";
		%this.ReferenceHoles++;
		//Echo("Gate" SPC %gate SPC "Removed From GlobalGateArray");
		if(%this.ReferenceHoles >= %this.MaxHoles)
		{
			//echo("MaxHoles Reached");
			%this.Organize();
			%this.ReferenceHoles = 0;
		}
		
	}
}

function GlobalGateArray::Organize(%this)
{
	%temparray[0] = "";
	%tempindx = %this.Gateindx;
	for(%i=0;%i<%this.Gateindx;%i++)//loop throught the whole array
	{
		if(IsObject(%this.Gates[%i]))
		{
			%temparray[%i] = %this.Gates[%i];
			
		}
	}
	%this.Clear();//clear the list out
	for(%i=0;%i<%tempindx;%i++)//loop throught the whole array
	{
		if(IsObject(%temparray[%i]))
		{
			%this.AddGate(%temparray[%i]);
		}
	}
	
}

function GlobalGateArray::Clear(%this)
{
	for(%i=0;%i<%this.Gateindx;%i++)
	{
		%this.Gates[%i] = "";
	}
	%this.Gateindx=0;
	//Echo("GlobalGateArrayCleared");
}