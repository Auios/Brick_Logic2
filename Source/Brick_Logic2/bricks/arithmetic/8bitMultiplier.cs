datablock fxDTSBrickData (Multiplier8bitBrick4x16Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Arithmetic";
	uiName = "8bit Multiplication";
	iconName = "base/client/ui/brickIcons/2x3f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate4x16f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "8bit Multiplication";
	TipInfo = "Multiplies 8bit A and 8bit B together and produces a product";
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

	numIE = 16;

	IEName[0] = "A0";
	IEPos[0] = "-0.25 -0.75 0.0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "A1";
	IEPos[1] = "-0.75 -0.75 0.0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "A2";
	IEPos[2] = "-1.25 -0.75 0.0";
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "A3";
	IEPos[3] = "-1.75 -0.75 0.0";
	IEScale[3] = "0.5 0.5 0.16666";

	IEName[4] = "A4";
	IEPos[4] = "-2.25 -0.75 0.0";
	IEScale[4] = "0.5 0.5 0.16666";

	IEName[5] = "A5";
	IEPos[5] = "-2.75 -0.75 0.0";
	IEScale[5] = "0.5 0.5 0.16666";

	IEName[6] = "A6";
	IEPos[6] = "-3.25 -0.75 0.0";
	IEScale[6] = "0.5 0.5 0.16666";

	IEName[7] = "A7";
	IEPos[7] = "-3.75 -0.75 0.0";
	IEScale[7] = "0.5 0.5 0.16666";

	IEName[8] = "B0";
	IEPos[8] = "3.75 -0.75 0.0";
	IEScale[8] = "0.5 0.5 0.16666";

	IEName[9] = "B1";
	IEPos[9] = "3.25 -0.75 0.0";
	IEScale[9] = "0.5 0.5 0.16666";

	IEName[10] = "B2";
	IEPos[10] = "2.75 -0.75 0.0";
	IEScale[10] = "0.5 0.5 0.16666";

	IEName[11] = "B3";
	IEPos[11] = "2.25 -0.75 0.0";
	IEScale[11] = "0.5 0.5 0.16666";

	IEName[12] = "B4";
	IEPos[12] = "1.75 -0.75 0.0";
	IEScale[12] = "0.5 0.5 0.16666";

	IEName[13] = "B5";
	IEPos[13] = "1.25 -0.75 0.0";
	IEScale[13] = "0.5 0.5 0.16666";

	IEName[14] = "B6";
	IEPos[14] = "0.75 -0.75 0.0";
	IEScale[14] = "0.5 0.5 0.16666";

	IEName[15] = "B7";
	IEPos[15] = "0.25 -0.75 0.0";
	IEScale[15] = "0.5 0.5 0.16666";
};

function Multiplier8bitBrick4x16Data::DoLog(%data, %gate, %statestack, %client)
{
	%valueA =
		%statestack.ins[0] +
		(%statestack.ins[1] * 2) +
		(%statestack.ins[2] * 4) +
		(%statestack.ins[3] * 8) +
		(%statestack.ins[4] * 16) +
		(%statestack.ins[5] * 32) +
		(%statestack.ins[6] * 64) +
		(%statestack.ins[7] * 128);

	%valueB =
		%statestack.ins[8] +
		(%statestack.ins[9] * 2) +
		(%statestack.ins[10] * 4) +
		(%statestack.ins[11] * 8) +
		(%statestack.ins[12] * 16) +
		(%statestack.ins[13] * 32) +
		(%statestack.ins[14] * 64) +
		(%statestack.ins[15] * 128);

	%finalValue = %valueA * %valueB;

	//%temp = 1;
	//for(%i=0;%i<8;i++)
	//{
	//	if((%gate.finalValue & %temp) > 0)
	//	{
	//		SetPEPowered(%gate.PE[%i], 1, %client);
	//	}
	//	else
	//	{
	//		SetPEPowered(%gate.PE[%i], 0, %client);
	//	}
	//}

	//for(%i=0;%i<8;i++)
	//{
	//	if((%gate.finalValue & mPow(2,%i)) > 0)
	//	{
	//		SetPEPowered(%gate.PE[%i], 1, %client);
	//	}
	//	else
	//	{
	//		SetPEPowered(%gate.PE[%i], 0, %client);
	//	}
	//}

	//%temp = 1;
	//for(%i=0;%i<8;i++)
	//{
	//	SetPEPowered(%gate.PE[%i], (%gate.finalValue & %temp > 0), %client);
	//	%temp<<=1;
	//}

	//for(%i=0;%i<8;i++)
    //{
    //    SetPEPowered(%gate.PE[%i], (%finalValue & (1 << %i) > 0), %client);
    //}

    SetPEPowered(%gate.PE[0], %finalValue & 1, %client);
    SetPEPowered(%gate.PE[1], %finalValue & 2, %client);
    SetPEPowered(%gate.PE[2], %finalValue & 4, %client);
    SetPEPowered(%gate.PE[3], %finalValue & 8, %client);
    SetPEPowered(%gate.PE[4], %finalValue & 16, %client);
    SetPEPowered(%gate.PE[5], %finalValue & 32, %client);
    SetPEPowered(%gate.PE[6], %finalValue & 64, %client);
    SetPEPowered(%gate.PE[7], %finalValue & 128, %client);
}
