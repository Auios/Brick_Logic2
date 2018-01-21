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
	GateName = "Memory Cell [0]";
	TipInfo = "Stores 1 bit with read and write access";
	ISINSTANT = 0;

	numPE = 1;

	PEName[0] = "Output";
	PEPos[0] = "-0.25 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	numIE = 3;

	IEName[0] = "Input";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "Execute (Clock)";
	IEPos[1] = "0.25 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "Reset (Clock)";
	IEPos[2] = "0.25 0.25 0.0";
	IEScale[2] = "0.5 0.5 0.16666";
};

datablock fxDTSBrickData (MemoryCellBrickOn2x2Data : MemoryCellBrickOff2x2Data)
{
	category = "";
	subCategory = "";
	uiName = "Memory Cell On";
	iconName = "";
	GateName = "Memory Cell [1]";

	numPE = 1;

	PEName[0] = "Output";
	PEPos[0] = "-0.25 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 1;

	numIE = 3;

	IEName[0] = "Input";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "Execute (Clock)";
	IEPos[1] = "0.25 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "Reset (Clock)";
	IEPos[2] = "0.25 0.25 0.0";
	IEScale[2] = "0.5 0.5 0.16666";
};

function MemoryCellBrickOff2x2Data::DoLog(%data, %gate, %statestack, %client)
{
	if(!%gate.IE[1].previousState && %statestack.ins[1])
	{
		if(%statestack.ins[0])
			%gate.setDatablock(MemoryCellBrickOn2x2Data);

		SetPEPowered(%gate.PE[0], %statestack.ins[0], %client);
	}
}

function MemoryCellBrickOn2x2Data::DoLog(%data, %gate, %statestack, %client)
{
	if(!%gate.IE[1].previousState && %statestack.ins[1])
	{
		if(!%statestack.ins[0])
			%gate.setDatablock(MemoryCellBrickOff2x2Data);

		SetPEPowered(%gate.PE[0], %statestack.ins[0], %client);
	}

	if(!%gate.IE[2].previousState && %statestack.ins[2])
	{
		%statestack.ins[0] = 0;
		%gate.setDatablock(MemoryCellBrickOff2x2Data);
		SetPEPowered(%gate.PE[0], %statestack.ins[0], %client);
	}
}

function MemoryCellBrickOn2x2Data::onLoadPlant(%this, %obj)
{
	%obj.data = 1;
	SetPEPowered(%gate.PE[0], 1, %client);
	PlantMerger(%this, %obj, 1);
}

function MemoryCellBrickOn2x2Data::onPlant(%this, %obj)
{
	%obj.data = 1;
	SetPEPowered(%gate.PE[0], 1, %client);
	PlantMerger(%this, %obj, 0);
}
