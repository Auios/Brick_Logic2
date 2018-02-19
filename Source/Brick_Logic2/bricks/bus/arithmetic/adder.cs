datablock fxDTSBrickData (busAdderBrick2x2Data : Powerbrick1x1Data)
{
	category = "Bus Bricks";
	subCategory = "Arithmetic";
	uiName = "Bus Adder";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Bus Adder";
	TipInfo = "Gets the sum of A and B";
	ISINSTANT = 0;

	numPE = 1;

	PEName[0] = "Sum";
	PEPos[0] = "0.25 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;	

	numIE = 2;

	IEName[0] = "A";
	IEPos[0] = "-0.25 -0.25 0.0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "B";
	IEPos[1] = "0.25 -0.25 0.0";
	IEScale[1] = "0.5 0.5 0.16666";
};

function busAdderBrick2x2Data::DoLog(%data, %gate, %statestack, %client)
{
    SetPEPowered(%gate.PE[0], %statestack.ins[0] + %statestack.ins[1], %client);
}
