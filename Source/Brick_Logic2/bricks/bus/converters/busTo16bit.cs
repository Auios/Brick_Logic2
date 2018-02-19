datablock fxDTSBrickData (busTo16bitData : Powerbrick1x1Data)
{
	category = "Bus Bricks";
	subCategory = "Converters";
	uiName = "Bus to 16bit";
	iconName = "base/client/ui/brickIcons/4x16f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate4x16f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Bus to 16bit Converter";
	TipInfo = "Converts bus to 16bit";
	ISINSTANT = 0;

	numPE = 16;

	PEName[0] = "Out0";
	PEPos[0] = "3.75 0.75 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;	

	PEName[1] = "Out1";
	PEPos[1] = "3.25 0.75 0.0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;	

	PEName[2] = "Out2";
	PEPos[2] = "2.75 0.75 0.0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;	

	PEName[3] = "Out3";
	PEPos[3] = "2.25 0.75 0.0";
	PEScale[3] = "0.5 0.5 0.16666";
	PEStart[3] = 0;	

	PEName[4] = "Out4";
	PEPos[4] = "1.75 0.75 0.0";
	PEScale[4] = "0.5 0.5 0.16666";
	PEStart[4] = 0;	

	PEName[5] = "Out5";
	PEPos[5] = "1.25 0.75 0.0";
	PEScale[5] = "0.5 0.5 0.16666";
	PEStart[5] = 0;	

	PEName[6] = "Out6";
	PEPos[6] = "0.75 0.75 0.0";
	PEScale[6] = "0.5 0.5 0.16666";
	PEStart[6] = 0;	

	PEName[7] = "Out7";
	PEPos[7] = "0.25 0.75 0.0";
	PEScale[7] = "0.5 0.5 0.16666";
	PEStart[7] = 0;

	PEName[8] = "Out8";
	PEPos[8] = "-0.25 0.75 0.0";
	PEScale[8] = "0.5 0.5 0.16666";
	PEStart[8] = 0;

	PEName[9] = "Out9";
	PEPos[9] = "-0.75 0.75 0.0";
	PEScale[9] = "0.5 0.5 0.16666";
	PEStart[9] = 0;

	PEName[10] = "Out10";
	PEPos[10] = "-1.25 0.75 0.0";
	PEScale[10] = "0.5 0.5 0.16666";
	PEStart[10] = 0;

	PEName[11] = "Out11";
	PEPos[11] = "-1.75 0.75 0.0";
	PEScale[11] = "0.5 0.5 0.16666";
	PEStart[11] = 0;

	PEName[12] = "Out12";
	PEPos[12] = "-2.25 0.75 0.0";
	PEScale[12] = "0.5 0.5 0.16666";
	PEStart[12] = 0;

	PEName[13] = "Out13";
	PEPos[13] = "-2.75 0.75 0.0";
	PEScale[13] = "0.5 0.5 0.16666";
	PEStart[13] = 0;

	PEName[14] = "Out14";
	PEPos[14] = "-3.25 0.75 0.0";
	PEScale[14] = "0.5 0.5 0.16666";
	PEStart[14] = 0;

	PEName[15] = "Out15";
	PEPos[15] = "-3.75 0.75 0.0";
	PEScale[15] = "0.5 0.5 0.16666";
	PEStart[15] = 0;

	numIE = 1;

	IEName[0] = "Bus in";
	IEPos[0] = "3.75 -0.75 0.0";
	IEScale[0] = "0.5 0.5 0.16666";
};

function busTo16bitData::DoLog(%data, %gate, %statestack, %client)
{
    SetPEPowered(%gate.PE[0],  (%statestack.ins[0] & 1    ) > 0, %client);
    SetPEPowered(%gate.PE[1],  (%statestack.ins[0] & 2    ) > 0, %client);
    SetPEPowered(%gate.PE[2],  (%statestack.ins[0] & 4    ) > 0, %client);
    SetPEPowered(%gate.PE[3],  (%statestack.ins[0] & 8    ) > 0, %client);
    SetPEPowered(%gate.PE[4],  (%statestack.ins[0] & 16   ) > 0, %client);
    SetPEPowered(%gate.PE[5],  (%statestack.ins[0] & 32   ) > 0, %client);
    SetPEPowered(%gate.PE[6],  (%statestack.ins[0] & 64   ) > 0, %client);
    SetPEPowered(%gate.PE[7],  (%statestack.ins[0] & 128  ) > 0, %client);
    SetPEPowered(%gate.PE[8],  (%statestack.ins[0] & 256  ) > 0, %client);
    SetPEPowered(%gate.PE[9],  (%statestack.ins[0] & 512  ) > 0, %client);
    SetPEPowered(%gate.PE[10], (%statestack.ins[0] & 1024 ) > 0, %client);
    SetPEPowered(%gate.PE[11], (%statestack.ins[0] & 2048 ) > 0, %client);
    SetPEPowered(%gate.PE[12], (%statestack.ins[0] & 4096 ) > 0, %client);
    SetPEPowered(%gate.PE[13], (%statestack.ins[0] & 8192 ) > 0, %client);
    SetPEPowered(%gate.PE[14], (%statestack.ins[0] & 16384) > 0, %client);
    SetPEPowered(%gate.PE[15], (%statestack.ins[0] & 32768) > 0, %client);
}
