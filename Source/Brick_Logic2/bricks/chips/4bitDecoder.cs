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

	numIE = 5;

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

	IEName[4] = "Disable"; 
	IEPos[4] = "1.25 -0.75 0";
	IEScale[4] = "0.5 0.5 0.16666";

	numPE = 16;

	PEName[0] = "Out0";
	PEPos[0] = "-3.75 0.75 0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 1;

	PEName[1] = "Out1";
	PEPos[1] = "-3.25 0.75 0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;

	PEName[2] = "Out2";
	PEPos[2] = "-2.75 0.75 0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;

	PEName[3] = "Out3";
	PEPos[3] = "-2.25 0.75 0";
	PEScale[3] = "0.5 0.5 0.16666";
	PEStart[3] = 0;

	PEName[4] = "Out4";
	PEPos[4] = "-1.75 0.75 0";
	PEScale[4] = "0.5 0.5 0.16666";
	PEStart[4] = 0;

	PEName[5] = "Out5";
	PEPos[5] = "-1.25 0.75 0";
	PEScale[5] = "0.5 0.5 0.16666";
	PEStart[5] = 0;

	PEName[6] = "Out6";
	PEPos[6] = "-0.75 0.75 0";
	PEScale[6] = "0.5 0.5 0.16666";
	PEStart[6] = 0;

	PEName[7] = "Out7";
	PEPos[7] = "-0.25 0.75 0";
	PEScale[7] = "0.5 0.5 0.16666";
	PEStart[7] = 0;

	PEName[8] = "Out8";
	PEPos[8] = "0.25 0.75 0";
	PEScale[8] = "0.5 0.5 0.16666";
	PEStart[8] = 0;

	PEName[9] = "Out9";
	PEPos[9] = "0.75 0.75 0";
	PEScale[9] = "0.5 0.5 0.16666";
	PEStart[9] = 0;

	PEName[10] = "Out10";
	PEPos[10] = "1.25 0.75 0";
	PEScale[10] = "0.5 0.5 0.16666";
	PEStart[10] = 0;

	PEName[11] = "Out11";
	PEPos[11] = "1.75 0.75 0";
	PEScale[11] = "0.5 0.5 0.16666";
	PEStart[11] = 0;

	PEName[12] = "Out12";
	PEPos[12] = "2.25 0.75 0";
	PEScale[12] = "0.5 0.5 0.16666";
	PEStart[12] = 0;

	PEName[13] = "Out13";
	PEPos[13] = "2.75 0.75 0";
	PEScale[13] = "0.5 0.5 0.16666";
	PEStart[13] = 0;

	PEName[14] = "Out14";
	PEPos[14] = "3.25 0.75 0";
	PEScale[14] = "0.5 0.5 0.16666";
	PEStart[14] = 0;

	PEName[15] = "Out15";
	PEPos[15] = "3.75 0.75 0";
	PEScale[15] = "0.5 0.5 0.16666";
	PEStart[15] = 0;
};

function Decoder4BitData::DoLog(%data,%gate,%statestack,%client)
{
	%gate.currentValue = %statestack.ins[0] | %statestack.ins[1] << 1 | %statestack.ins[2] << 2 | %statestack.ins[3] << 3;

	if(!%statestack.ins[4])
	{
        SetPEPowered(%gate.PE[%gate.lastValue+0], 0, %client);
        SetPEPowered(%gate.lastValue = %gate.PE[%gate.currentValue+0], 1, %client);
        %gate.lastValue = %gate.currentValue;
	}
    else
    {
    	SetPEPowered(%gate.PE[%gate.lastValue+0], 0, %client);
    }
}
