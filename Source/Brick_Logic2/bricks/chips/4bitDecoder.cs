datablock fxDTSBrickData (Decoder4BitData : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Chips";
	uiName = "4bit decoder";
	iconName = "base/client/ui/brickIcons/2x10f";
	brickFile = "/bricks/4x16F.blb";
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "4bit Decoder";
	TipInfo = "Converts 4bit binary to their own respective outputs 0 - 15";

	numIE = 4;

	IEName[0] = "In0"; //Right most
	IEPos[0] = "3.75 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "In1";
	IEPos[1] = "3.25 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "In2";
	IEPos[2] = "2.75 -0.25 0";
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "In3"; 
	IEPos[3] = "2.25 -0.25 0";
	IEScale[3] = "0.5 0.5 0.16666";

	numPE = 16;

	PEName[0] = "Out0";
	PEPos[0] = "-3.75 0.25 0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 1;

	PEName[1] = "Out01";
	PEPos[1] = "-3.25 0.25 0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;

	PEName[2] = "Out02";
	PEPos[2] = "-2.75 0.25 0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;

	PEName[3] = "Out03";
	PEPos[3] = "-2.25 0.25 0";
	PEScale[3] = "0.5 0.5 0.16666";
	PEStart[3] = 0;

	PEName[4] = "Out04";
	PEPos[4] = "-1.75 0.25 0";
	PEScale[4] = "0.5 0.5 0.16666";
	PEStart[4] = 0;

	PEName[5] = "Out05";
	PEPos[5] = "-1.25 0.25 0";
	PEScale[5] = "0.5 0.5 0.16666";
	PEStart[5] = 0;

	PEName[6] = "Out06";
	PEPos[6] = "-0.75 0.25 0";
	PEScale[6] = "0.5 0.5 0.16666";
	PEStart[6] = 0;

	PEName[7] = "Out07";
	PEPos[7] = "-0.25 0.25 0";
	PEScale[7] = "0.5 0.5 0.16666";
	PEStart[7] = 0;

	PEName[8] = "Out08";
	PEPos[8] = "0.25 0.25 0";
	PEScale[8] = "0.5 0.5 0.16666";
	PEStart[8] = 0;

	PEName[9] = "Out09";
	PEPos[9] = "0.75 0.25 0";
	PEScale[9] = "0.5 0.5 0.16666";
	PEStart[9] = 0;

	PEName[10] = "Out010";
	PEPos[10] = "1.25 0.25 0";
	PEScale[10] = "0.5 0.5 0.16666";
	PEStart[10] = 0;

	PEName[11] = "Out011";
	PEPos[11] = "1.75 0.25 0";
	PEScale[11] = "0.5 0.5 0.16666";
	PEStart[11] = 0;

	PEName[12] = "Out012";
	PEPos[12] = "2.25 0.25 0";
	PEScale[12] = "0.5 0.5 0.16666";
	PEStart[12] = 0;

	PEName[13] = "Out013";
	PEPos[13] = "2.75 0.25 0";
	PEScale[13] = "0.5 0.5 0.16666";
	PEStart[13] = 0;

	PEName[14] = "Out014";
	PEPos[14] = "3.25 0.25 0";
	PEScale[14] = "0.5 0.5 0.16666";
	PEStart[14] = 0;

	PEName[15] = "Out015";
	PEPos[15] = "3.75 0.25 0";
	PEScale[15] = "0.5 0.5 0.16666";
	PEStart[15] = 0;
};

function Decoder4BitData::DoLog(%data,%gate,%statestack,%client)
{
	%currentValue = %statestack.ins[0] | %statestack.ins[1] << 1 | %statestack.ins[2] << 2 | %statestack.ins[3] << 3;
    if(%currentValue != %gate.lastValue)
    {
        SetPEPowered(%gate.PE[%gate.lastValue], 0, %client);
        SetPEPowered(%gate.lastValue = %gate.PE[%currentValue], 1, %client);
    }
    %gate.lastValue = %currentValue;
}