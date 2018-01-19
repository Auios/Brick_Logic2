datablock fxDTSBrickData (Ram16byteBrickData : Powerbrick1x1Data)//base
{
	category = "Logic Bricks";
	subCategory = "Memory";
	uiName = "16 byte RAM";
	iconName = "base/client/ui/brickIcons/4x16f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate4x16f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "16 byte RAM";//so in code we can do special things
	TipInfo = "Stores 16 8-bit words with read and write access";

	///////////////////
	ISINSTANT = 0;/////
	///////////////////

	//Main Outputs
	numPE = 8;
	PEName[0] = "Out0";
	PEPos[0] = "-3.75 0.75 0.0";
	PEScale[0] = "0.5 0.5 0.16666";

	PEName[1] = "Out1";
	PEPos[1] = "-3.25 0.75 0.0";
	PEScale[1] = "0.5 0.5 0.16666";

	PEName[2] = "Out2";
	PEPos[2] = "-2.75 0.75 0.0";
	PEScale[2] = "0.5 0.5 0.16666";

	PEName[3] = "Out3";
	PEPos[3] = "-2.25 0.75 0.0";
	PEScale[3] = "0.5 0.5 0.16666";

	PEName[4] = "Out4";
	PEPos[4] = "-1.75 0.75 0.0";
	PEScale[4] = "0.5 0.5 0.16666";

	PEName[5] = "Out5";
	PEPos[5] = "-1.25 0.75 0.0";
	PEScale[5] = "0.5 0.5 0.16666";

	PEName[6] = "Out6";
	PEPos[6] = "-0.75 0.75 0.0";
	PEScale[6] = "0.5 0.5 0.16666";

	PEName[7] = "Out7";
	PEPos[7] = "-0.25 0.75 0.0";
	PEScale[7] = "0.5 0.5 0.16666";

	//Main Inputs
	numIE = 15;
	IEName[0] = "In0";
	IEPos[0] = "-3.75 -0.75 0.0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "In1";
	IEPos[1] = "-3.25 -0.75 0.0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "In2";
	IEPos[2] = "-2.75 -0.75 0.0";
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "In3";
	IEPos[3] = "-2.25 -0.75 0.0";
	IEScale[3] = "0.5 0.5 0.16666";

	IEName[4] = "In4";
	IEPos[4] = "-1.75 -0.75 0.0";
	IEScale[4] = "0.5 0.5 0.16666";

	IEName[5] = "In5";
	IEPos[5] = "-1.25 -0.75 0.0";
	IEScale[5] = "0.5 0.5 0.16666";

	IEName[6] = "In6";
	IEPos[6] = "-0.75 -0.75 0.0";
	IEScale[6] = "0.5 0.5 0.16666";

	IEName[7] = "In7";
	IEPos[7] = "-0.25 -0.75 0.0";
	IEScale[7] = "0.5 0.5 0.16666";

	//Write Enable Pin
	IEName[8] = "Write Enable";
	IEPos[8] = "3.75 -0.75 0.0";
	IEScale[8] = "0.5 0.5 0.16666";

	//Read Enable Pin
	IEName[9] = "Read Enable";
	IEPos[9] = "3.75 -0.25 0.0";
	IEScale[9] = "0.5 0.5 0.16666";

	//Clock
	IEName[10] = "Execute";
	IEPos[10] = "3.75 0.75 0.0";
	IEScale[10] = "0.5 0.5 0.16666";

	//Address Pins
	IEName[11] = "Address0";
	IEPos[11] = "1.25 -0.75 0.0";
	IEScale[11] = "0.5 0.5 0.16666";

	IEName[12] = "Address1";
	IEPos[12] = "1.75 -0.75 0.0";
	IEScale[12] = "0.5 0.5 0.16666";

	IEName[13] = "Address2";
	IEPos[13] = "2.25 -0.75 0.0";
	IEScale[13] = "0.5 0.5 0.16666";

	IEName[14] = "Address3";
	IEPos[14] = "2.75 -0.75 0.0";
	IEScale[14] = "0.5 0.5 0.16666";
};

function Ram16byteBrickData::DoLog(%data,%gate,%statestack,%client)
{
	//first figure out the address
	%gate.currAddr = (%statestack.ins[11] * 1) + (%statestack.ins[12] * 2) + (%statestack.ins[13] * 4) + (%statestack.ins[14] * 8);

	if(!%gate.IE[10].previousState && %statestack.ins[10])//positive clock edge.
	{
		if(%statestack.ins[8])//if write enable
		{
			%gate.data[%gate.currAddr,0] = %statestack.ins[0];
			%gate.data[%gate.currAddr,1] = %statestack.ins[1];
			%gate.data[%gate.currAddr,2] = %statestack.ins[2];
			%gate.data[%gate.currAddr,3] = %statestack.ins[3];
			%gate.data[%gate.currAddr,4] = %statestack.ins[4];
			%gate.data[%gate.currAddr,5] = %statestack.ins[5];
			%gate.data[%gate.currAddr,6] = %statestack.ins[6];
			%gate.data[%gate.currAddr,7] = %statestack.ins[7];
		}
		
		if(%statestack.ins[9])//read enabled
		{
			SetPEPowered(%gate.PE[0],%gate.data[%gate.currAddr,0],%client);
			SetPEPowered(%gate.PE[1],%gate.data[%gate.currAddr,1],%client);
			SetPEPowered(%gate.PE[2],%gate.data[%gate.currAddr,2],%client);
			SetPEPowered(%gate.PE[3],%gate.data[%gate.currAddr,3],%client);
			SetPEPowered(%gate.PE[4],%gate.data[%gate.currAddr,4],%client);
			SetPEPowered(%gate.PE[5],%gate.data[%gate.currAddr,5],%client);
			SetPEPowered(%gate.PE[6],%gate.data[%gate.currAddr,6],%client);
			SetPEPowered(%gate.PE[7],%gate.data[%gate.currAddr,7],%client);
		}
	}
}