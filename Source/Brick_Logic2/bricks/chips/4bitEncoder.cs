datablock fxDTSBrickData (Encoder4BitData : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Chips";
	uiName = "4bit decoder";
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

	numPE = 4;

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
};

datablock fxDTSBrickData (Decoder4BitData : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Chips";
	uiName = "4bit decoder";
	iconName = "base/client/ui/brickIcons/4x16f";
	brickFile = "base/data/bricks/flats/4x16F.blb";
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "4bit Decoder";
	TipInfo = "Converts 4bit binary to their own respective outputs 0 - 15";

	numIE = 4;
	IEName[0] = "In0"; //Right most
	IEPos[0] = "3.75 -0.75 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "In1";
	IEPos[1] = "3.25 -0.75 0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "In2";
	IEPos[2] = "2.75 -0.75 0";
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "In3"; 
	IEPos[3] = "2.25 -0.75 0";
	IEScale[3] = "0.5 0.5 0.16666";

	numPE = 16;

	PEName[0] = "0";
	PEPos[0] = "-3.75 0.75 0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 1;

	PEName[1] = "1";
	PEPos[1] = "-3.25 0.75 0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;

	PEName[2] = "2";
	PEPos[2] = "-2.75 0.75 0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;

	PEName[3] = "3";
	PEPos[3] = "-2.25 0.75 0";
	PEScale[3] = "0.5 0.5 0.16666";
	PEStart[3] = 0;

	PEName[4] = "4";
	PEPos[4] = "-1.75 0.75 0";
	PEScale[4] = "0.5 0.5 0.16666";
	PEStart[4] = 0;

	PEName[5] = "5";
	PEPos[5] = "-1.25 0.75 0";
	PEScale[5] = "0.5 0.5 0.16666";
	PEStart[5] = 0;

	PEName[6] = "6";
	PEPos[6] = "-0.75 0.75 0";
	PEScale[6] = "0.5 0.5 0.16666";
	PEStart[6] = 0;

	PEName[7] = "7";
	PEPos[7] = "-0.25 0.75 0";
	PEScale[7] = "0.5 0.5 0.16666";
	PEStart[7] = 0;

	PEName[8] = "8";
	PEPos[8] = "0.25 0.75 0";
	PEScale[8] = "0.5 0.5 0.16666";
	PEStart[8] = 0;

	PEName[9] = "9";
	PEPos[9] = "0.75 0.75 0";
	PEScale[9] = "0.5 0.5 0.16666";
	PEStart[9] = 0;

	PEName[10] = "10";
	PEPos[10] = "1.25 0.75 0";
	PEScale[10] = "0.5 0.5 0.16666";
	PEStart[10] = 0;

	PEName[11] = "11";
	PEPos[11] = "1.75 0.75 0";
	PEScale[11] = "0.5 0.5 0.16666";
	PEStart[11] = 0;

	PEName[12] = "12";
	PEPos[12] = "2.25 0.75 0";
	PEScale[12] = "0.5 0.5 0.16666";
	PEStart[12] = 0;

	PEName[13] = "13";
	PEPos[13] = "2.75 0.75 0";
	PEScale[13] = "0.5 0.5 0.16666";
	PEStart[13] = 0;

	PEName[14] = "14";
	PEPos[14] = "3.25 0.75 0";
	PEScale[14] = "0.5 0.5 0.16666";
	PEStart[14] = 0;

	PEName[15] = "15";
	PEPos[15] = "3.75 0.75 0";
	PEScale[15] = "0.5 0.5 0.16666";
	PEStart[15] = 0;
};

function Decoder4BitData::DoLog(%data,%gate,%statestack,%client)
{
	%i = 0;

	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;
	if(%statestack.ins[%i]){%brick.currentValue=%statestack.ins[%i]<<%i;}%i++;

    if(%currentValue != %gate.lastValue)
    {
        SetPEPowered(%gate.PE[0], (%brick.currentValue >> 0) & 1, %client);
		SetPEPowered(%gate.PE[1], (%brick.currentValue >> 1) & 1, %client);
		SetPEPowered(%gate.PE[2], (%brick.currentValue >> 2) & 1, %client);
		SetPEPowered(%gate.PE[3], (%brick.currentValue >> 3) & 1, %client);
    }

    %gate.lastValue = %brick.currentValue;
}