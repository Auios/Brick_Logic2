datablock fxDTSBrickData (HalfAdderBrick2x2Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Special";
	uiName = "Half Adder";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "../Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Half Adder";
	TipInfo = "...";
	ISINSTANT = 0;
	numPE = 2;
	PEName[0] = "Sum";
	PEPos[0] = "0.25 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;
	PEName[1] = "Carry";
	PEPos[1] = "-0.25 0.25 0.0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;
	numIE = 2;
	IEName[0] = "A";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "0.25 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
};

function HalfAdderBrick2x2Data::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0] != %statestack.ins[1])
	{
		%out1 = 1;
		%out2 = 0;
	}
	else if (%statestack.ins[0] == 1)
	{
		%out1 = 1;
		%out2 = 1;
	}
	else
	{
		%out1 = 0;
		%out2 = 0;
	}
	SetPEPowered(%gate.PE[0],%out1,%client);
	SetPEPowered(%gate.PE[1],%out2,%client);
}