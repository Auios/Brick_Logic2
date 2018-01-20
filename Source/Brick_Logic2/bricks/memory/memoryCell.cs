datablock fxDTSBrickData (MemoryCellBrickOff2x2Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Memory";
	uiName = "Memory Cell";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Memory Cell";
	TipInfo = "Stores 1 bit with read and write access";
	ISINSTANT = 0;

	numPE = 1;

	PEName[0] = "Output";
	PEPos[0] = "-0.25 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	numIE = 3;

	IEName[0] = "Data";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "Read/Write";
	IEPos[1] = "0.25 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "Execute";
	IEPos[2] = "0.25 0.25 0.0";
	IEScale[2] = "0.5 0.5 0.16666";
};

datablock fxDTSBrickData (MemoryCellBrickOn2x2Data : MemoryCellBrickOff2x2Data)
{
	category = "";
	subCategory = "";
	uiName = "Memory Cell On";
	iconName = "";

	numPE = 1;

	PEName[0] = "Output";
	PEPos[0] = "-0.25 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";

	numIE = 3;

	IEName[0] = "Data";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "Read/Write";
	IEPos[1] = "0.25 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "Execute";
	IEPos[2] = "0.25 0.25 0.0";
	IEScale[2] = "0.5 0.5 0.16666";
};

function MemoryCellBrickOff2x2Data::DoLog(%data, %gate, %statestack, %client)
{
	if(!%gate.IE[2].previousState && %statestack.ins[2])
	{
		if(%statestack.ins[1])
		{
			%gate.data = %statestack.ins[0];
			if(%gate.data)
				%gate.setDatablock(MemoryCellBrickOn2x2Data);
		}
		else
			SetPEPowered(%gate.PE[0], %gate.data, %client);
	}
}

function MemoryCellBrickOn2x2Data::DoLog(%data, %gate, %statestack, %client)
{
	if(!%gate.IE[2].previousState && %statestack.ins[2])
	{
		if(%statestack.ins[1])
		{
			%gate.data = %statestack.ins[0];
			if(!%gate.data)
				%gate.setDatablock(MemoryCellBrickOff2x2Data);
		}
		else
			SetPEPowered(%gate.PE[0], %gate.data, %client);
	}
}

function MemoryCellBrickOn2x2Data::onLoadPlant(%this, %obj)
{
	%obj.data = 1;
	PlantMerger(%this, %obj, 1);
}

function MemoryCellBrickOn2x2Data::onPlant(%this, %obj)
{
	%obj.data = 1;
	PlantMerger(%this, %obj, 0);
}
