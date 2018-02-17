datablock fxDTSBrickData (FullSubtractorBrick2x3Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Arithmetic";
	uiName = "Full Subtractor";
	iconName = "base/client/ui/brickIcons/2x3f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate2x3f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Full Subtractor";
	TipInfo = "Adds A and B with carry in";
	ISINSTANT = 0;
	numPE = 2;
	PEName[0] = "Borrow out";
	PEPos[0] = "-0.5 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;
	PEName[1] = "Difference";
	PEPos[1] = "0 0.25 0.0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;
	numIE = 3;
	IEName[0] = "A";
	IEPos[0] = "-0.5 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "0 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
	IEName[2] = "Borrow in";
	IEPos[2] = "0.5 -0.25 0";
	IEScale[2] = "0.5 0.5 0.16666";
};

function FullSubtractorBrick2x3Data::DoLog(%data, %gate, %statestack, %client)
{
	//Borrow out
	SetPEPowered(%gate.PE[0], !%statestack.ins[0] && %statestack.ins[1] || !(%statestack.ins[0] ^ %statestack.ins[1]) && %statestack.ins[2], %client);

	//Difference
	SetPEPowered(%gate.PE[1], (%statestack.ins[0] ^ %statestack.ins[1]) ^ %statestack.ins[2], %client);
}
