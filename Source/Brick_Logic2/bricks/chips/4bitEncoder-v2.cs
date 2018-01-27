datablock fxDTSBrickData (Encoder4BitData : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Chips";
	uiName = "4bit encoder";
	iconName = "base/client/ui/brickIcons/4x16f";
	brickFile = "base/data/bricks/flats/4x16F.blb";
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "4bit Encoder";
	TipInfo = "Converts values 0 - 15 to 4bit binary\nUse one input at a time";

	numIE = 16;

	IEName[0] = "In0";
	IEPos[0] = "-3.75 -0.75 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "In1";
	IEPos[1] = "-3.25 -0.75 0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "In2";
	IEPos[2] = "-2.75 -0.75 0";
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "In3";
	IEPos[3] = "-2.25 -0.75 0";
	IEScale[3] = "0.5 0.5 0.16666";

	IEName[4] = "In4";
	IEPos[4] = "-1.75 -0.75 0";
	IEScale[4] = "0.5 0.5 0.16666";

	IEName[5] = "In5";
	IEPos[5] = "-1.25 -0.75 0";
	IEScale[5] = "0.5 0.5 0.16666";

	IEName[6] = "In6";
	IEPos[6] = "-0.75 -0.75 0";
	IEScale[6] = "0.5 0.5 0.16666";

	IEName[7] = "In7";
	IEPos[7] = "-0.25 -0.75 0";
	IEScale[7] = "0.5 0.5 0.16666";

	IEName[8] = "In8";
	IEPos[8] = "0.25 -0.75 0";
	IEScale[8] = "0.5 0.5 0.16666";

	IEName[9] = "In9";
	IEPos[9] = "0.75 -0.75 0";
	IEScale[9] = "0.5 0.5 0.16666";

	IEName[10] = "In10";
	IEPos[10] = "1.25 -0.75 0";
	IEScale[10] = "0.5 0.5 0.16666";

	IEName[11] = "In11";
	IEPos[11] = "1.75 -0.75 0";
	IEScale[11] = "0.5 0.5 0.16666";

	IEName[12] = "In12";
	IEPos[12] = "2.25 -0.75 0";
	IEScale[12] = "0.5 0.5 0.16666";

	IEName[13] = "In13";
	IEPos[13] = "2.75 -0.75 0";
	IEScale[13] = "0.5 0.5 0.16666";

	IEName[14] = "In14";
	IEPos[14] = "3.25 -0.75 0";
	IEScale[14] = "0.5 0.5 0.16666";

	IEName[15] = "In15";
	IEPos[15] = "3.75 -0.75 0";
	IEScale[15] = "0.5 0.5 0.16666";

	numPE = 5;

	PEName[0] = "Out0";
	PEPos[0] = "-2.25 0.75 0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	PEName[1] = "Out1";
	PEPos[1] = "-2.75 0.75 0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;

	PEName[2] = "Out2";
	PEPos[2] = "-3.25 0.75 0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;

	PEName[3] = "Out3"; 
	PEPos[3] = "-3.75 0.75 0";
	PEScale[3] = "0.5 0.5 0.16666";
	PEStart[3] = 0;

	PEName[4] = "Error"; 
	PEPos[4] = "-1.25 0.75 0";
	PEScale[4] = "0.5 0.5 0.16666";
	PEStart[4] = 0;
};

function Encoder4BitData::DoLog(%data,%gate,%statestack,%client)
{
	%gate.currentValue = %statestack.ins[0]*0 | %statestack.ins[1]*1 | %statestack.ins[2]*2 | %statestack.ins[3]*3 |
		%statestack.ins[4]*4 | %statestack.ins[5]*5 | %statestack.ins[6]*6 | %statestack.ins[7]*7 |
		%statestack.ins[8]*8 | %statestack.ins[9]*9 | %statestack.ins[10]*10 | %statestack.ins[11]*11 |
		%statestack.ins[12]*12 | %statestack.ins[13]*13 | %statestack.ins[14]*14 | %statestack.ins[15]*15;

	if(%gate.lastValue != %gate.currentValue)
	{
		SetPEPowered(%gate.pe[0], %gate.currentValue & 1, %client);
		SetPEPowered(%gate.pe[1], %gate.currentValue & 2, %client);
		SetPEPowered(%gate.pe[2], %gate.currentValue & 4, %client);
		SetPEPowered(%gate.pe[3], %gate.currentValue & 8, %client);
		%gate.lastValue = %gate.currentValue;
	}
}