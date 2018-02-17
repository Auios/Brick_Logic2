datablock fxDTSBrickData (HalfSubtractorBrick2x2Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Arithmetic";
	uiName = "Half Subtractor";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Half Subtractor";
	TipInfo = "Subtracts B from A";
	ISINSTANT = 0;

	numPE = 2;

	PEName[0] = "Difference";
	PEPos[0] = "0.25 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	PEName[1] = "Borrow out";
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

function HalfSubtractorBrick2x2Data::DoLog(%data, %gate, %statestack, %client)
{
	//Difference
	SetPEPowered(%gate.PE[0], %statestack.ins[0] ^ %statestack.ins[1], %client);

	//Borrow out
	SetPEPowered(%gate.PE[1], !%statestack.ins[0] && %statestack.ins[1], %client);
}
