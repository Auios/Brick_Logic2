datablock fxDTSBrickData (Enabler8bitBrick4x16Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Arithmetic";
	uiName = "8bit Enabler";
	iconName = "base/client/ui/brickIcons/4x16f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate4x16f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "8bit Enabler";
	TipInfo = "Allows or blocks 8bit signals";
	ISINSTANT = 0;

	numPE = 8;

	PEName[0] = "Out0";
	PEPos[0] = "-0.25 0.75 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;	

	PEName[1] = "Out1";
	PEPos[1] = "-0.75 0.75 0.0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;	

	PEName[2] = "Out2";
	PEPos[2] = "-1.25 0.75 0.0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;	

	PEName[3] = "Out3";
	PEPos[3] = "-1.75 0.75 0.0";
	PEScale[3] = "0.5 0.5 0.16666";
	PEStart[3] = 0;	

	PEName[4] = "Out4";
	PEPos[4] = "-2.25 0.75 0.0";
	PEScale[4] = "0.5 0.5 0.16666";
	PEStart[4] = 0;	

	PEName[5] = "Out5";
	PEPos[5] = "-2.75 0.75 0.0";
	PEScale[5] = "0.5 0.5 0.16666";
	PEStart[5] = 0;	

	PEName[6] = "Out6";
	PEPos[6] = "-3.25 0.75 0.0";
	PEScale[6] = "0.5 0.5 0.16666";
	PEStart[6] = 0;	

	PEName[7] = "Out7";
	PEPos[7] = "-3.75 0.75 0.0";
	PEScale[7] = "0.5 0.5 0.16666";
	PEStart[7] = 0;

	numIE = 8;

	IEName[0] = "In0";
	IEPos[0] = "-0.25 -0.75 0.0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "In1";
	IEPos[1] = "-0.75 -0.75 0.0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "In2";
	IEPos[2] = "-1.25 -0.75 0.0";
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "In3";
	IEPos[3] = "-1.75 -0.75 0.0";
	IEScale[3] = "0.5 0.5 0.16666";

	IEName[4] = "In4";
	IEPos[4] = "-2.25 -0.75 0.0";
	IEScale[4] = "0.5 0.5 0.16666";

	IEName[5] = "In5";
	IEPos[5] = "-2.75 -0.75 0.0";
	IEScale[5] = "0.5 0.5 0.16666";

	IEName[6] = "In6";
	IEPos[6] = "-3.25 -0.75 0.0";
	IEScale[6] = "0.5 0.5 0.16666";

	IEName[7] = "In7";
	IEPos[7] = "-3.75 -0.75 0.0";
	IEScale[7] = "0.5 0.5 0.16666";
};

function Enabler8bitBrick4x16Data::DoLog(%data, %gate, %statestack, %client)
{
    SetPEPowered(%gate.PE[0], %statestack.ins[0] & 1, %client);
    SetPEPowered(%gate.PE[1], %statestack.ins[1] & 1, %client);
    SetPEPowered(%gate.PE[2], %statestack.ins[2] & 1, %client);
    SetPEPowered(%gate.PE[3], %statestack.ins[3] & 1, %client);
    SetPEPowered(%gate.PE[4], %statestack.ins[4] & 1, %client);
    SetPEPowered(%gate.PE[4], %statestack.ins[4] & 1, %client);
    SetPEPowered(%gate.PE[5], %statestack.ins[5] & 1, %client);
    SetPEPowered(%gate.PE[6], %statestack.ins[6] & 1, %client);
}
