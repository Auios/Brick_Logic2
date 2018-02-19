datablock fxDTSBrickData (bit16ToBusData : Powerbrick1x1Data)
{
	category = "Bus Bricks";
	subCategory = "Converters";
	uiName = "16bit to bus";
	iconName = "base/client/ui/brickIcons/4x16f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate4x16f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "16bit to bus Converter";
	TipInfo = "Converts 16bit to bus";
	ISINSTANT = 0;

	numPE = 1;

	PEName[0] = "Out0";
	PEPos[0] = "-3.75 0.75 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;	


	numIE = 16;

	IEName[0] = "In0";
	IEPos[0] = "3.75 -0.75 0.0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "In1";
	IEPos[1] = "3.25 -0.75 0.0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "In2";
	IEPos[2] = "2.75 -0.75 0.0";
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "In3";
	IEPos[3] = "2.25 -0.75 0.0";
	IEScale[3] = "0.5 0.5 0.16666";

	IEName[4] = "In4";
	IEPos[4] = "1.75 -0.75 0.0";
	IEScale[4] = "0.5 0.5 0.16666";

	IEName[5] = "In5";
	IEPos[5] = "1.25 -0.75 0.0";
	IEScale[5] = "0.5 0.5 0.16666";

	IEName[6] = "In6";
	IEPos[6] = "0.75 -0.75 0.0";
	IEScale[6] = "0.5 0.5 0.16666";

	IEName[7] = "In7";
	IEPos[7] = "0.25 -0.75 0.0";
	IEScale[7] = "0.5 0.5 0.16666";

	IEName[8] = "In8";
	IEPos[8] = "-0.25 -0.75 0.0";
	IEScale[8] = "0.5 0.5 0.16666";

	IEName[9] = "In9";
	IEPos[9] = "-0.75 -0.75 0.0";
	IEScale[9] = "0.5 0.5 0.16666";

	IEName[10] = "In10";
	IEPos[10] = "-1.25 -0.75 0.0";
	IEScale[10] = "0.5 0.5 0.16666";

	IEName[11] = "In11";
	IEPos[11] = "-1.75 -0.75 0.0";
	IEScale[11] = "0.5 0.5 0.16666";

	IEName[12] = "In12";
	IEPos[12] = "-2.25 -0.75 0.0";
	IEScale[12] = "0.5 0.5 0.16666";

	IEName[13] = "In13";
	IEPos[13] = "-2.75 -0.75 0.0";
	IEScale[13] = "0.5 0.5 0.16666";

	IEName[14] = "In14";
	IEPos[14] = "-3.25 -0.75 0.0";
	IEScale[14] = "0.5 0.5 0.16666";

	IEName[15] = "In15";
	IEPos[15] = "-3.75 -0.75 0.0";
	IEScale[15] = "0.5 0.5 0.16666";
};

function bit16ToBusData::DoLog(%data, %gate, %statestack, %client)
{
	%busValue =
		%statestack.ins[0] +
		((%statestack.ins[1]  > 0) * 2) +
		((%statestack.ins[2]  > 0) * 4) +
		((%statestack.ins[3]  > 0) * 8) +
		((%statestack.ins[4]  > 0) * 16) +
		((%statestack.ins[5]  > 0) * 32) +
		((%statestack.ins[6]  > 0) * 64) +
		((%statestack.ins[7]  > 0) * 128) +
		((%statestack.ins[8]  > 0) * 256) +
		((%statestack.ins[9]  > 0) * 512) +
		((%statestack.ins[10] > 0) * 1024) +
		((%statestack.ins[11] > 0) * 2048) +
		((%statestack.ins[12] > 0) * 4096) +
		((%statestack.ins[13] > 0) * 8192) +
		((%statestack.ins[14] > 0) * 16384) +
		((%statestack.ins[15] > 0) * 32768);

    SetPEPowered(%gate.PE[0], %busValue, %client);
}
