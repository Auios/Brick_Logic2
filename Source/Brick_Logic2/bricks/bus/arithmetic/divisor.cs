datablock fxDTSBrickData (busDivisorBrick2x2Data : Powerbrick1x1Data)
{
	category = "Bus Bricks";
	subCategory = "Arithmetic";
	uiName = "Bus Divisor";
	iconName = "base/client/ui/brickIcons/2x3f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate2x3f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Bus Divisor";
	TipInfo = "Divides A by B";
	ISINSTANT = 0;

	numPE = 3;

	PEName[0] = "Complete Quotient";
	PEPos[0] = "-0.5 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	PEName[1] = "Quotient";
	PEPos[1] = "0 0.25 0.0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;

	PEName[2] = "Remainder";
	PEPos[2] = "0.5 0.25 0.0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;

	numIE = 2;

	IEName[0] = "A";
	IEPos[0] = "-0.5 -0.25 0.0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "B";
	IEPos[1] = "0 -0.25 0.0";
	IEScale[1] = "0.5 0.5 0.16666";
};

function busDivisorBrick2x2Data::DoLog(%data, %gate, %statestack, %client)
{
    SetPEPowered(%gate.PE[0], %statestack.ins[0] / %statestack.ins[1], %client);
    SetPEPowered(%gate.PE[1], mFloor(%statestack.ins[0] / %statestack.ins[1]), %client);
    SetPEPowered(%gate.PE[2], %statestack.ins[0] - mFloor(%statestack.ins[0] / %statestack.ins[1]) * %statestack.ins[1], %client);
}
