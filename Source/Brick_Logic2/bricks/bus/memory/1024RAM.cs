datablock fxDTSBrickData (RAM1024Brick2x4Data : Powerbrick1x1Data)
{
	category = "Bus Bricks";
	subCategory = "Memory";
	uiName = "1Kb RAM";
	iconName = "base/client/ui/brickIcons/2x4f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate2x4f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "1Kb RAM";
	TipInfo = "";

	numPE = 1;

	PEName[0] = "Output";
	PEPos[0] = "0.75 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	numIE = 5;

	IEName[0] = "Input";
	IEPos[0] = "-0.75 0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "Address";
	IEPos[1] = "-0.75 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "Read";
	IEPos[2] = "-0.25 -0.25 0";
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "Write";
	IEPos[3] = "0.25 -0.25 0";
	IEScale[3] = "0.5 0.5 0.16666";

	IEName[4] = "Clock";
	IEPos[4] = "0.75 -0.25 0";
	IEScale[4] = "0.5 0.5 0.16666";
};

function RAM1024Brick2x4Data::DoLog(%data, %gate, %statestack, %client)
{
	if(!%gate.IE[4].previousState && %statestack.ins[4]) //Positive clock edge
	{
		if(%statestack.ins[1] >= 0 && %statestack.ins[1] < 1024)
		{
			if(%statestack.ins[2]) //if read enabled
		{
			SetPEPowered(%gate.PE[0],%gate.data[%statestack.ins[1]],%client);
		}

		if(%statestack.ins[3]) //if write enable
		{
			%gate.data[%statestack.ins[1]] = %statestack.ins[0];
		}
	}
	SetPEPowered(%gate.PE[0], %statestack.ins[0] | %statestack.ins[1]), %client);
}
