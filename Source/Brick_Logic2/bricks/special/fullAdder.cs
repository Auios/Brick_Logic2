datablock fxDTSBrickData (FullAdderBrick2x3Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Special";
	uiName = "Full Adder";
	iconName = "base/client/ui/brickIcons/2x3f";
	brickFile = "../Gate2x3f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Full Adder";
	TipInfo = "...";
	ISINSTANT = 0;
	numPE = 2;
	PEName[0] = "Carry out";
	PEPos[0] = "-0.5 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;
	PEName[1] = "Sum";
	PEPos[1] = "0 0.25 0.0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;
	numIE = 3;
	IEName[0] = "A";
	IEPos[0] = "-0.5 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "0 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
	IEName[2] = "Carry in";
	IEPos[2] = "0.5 -0.25 0";
	IEScale[2] = "0.5 0.5 0.16666";
};

function FullAdderBrick2x3Data::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0] == %statestack.ins[1] && %statestack.ins[0] == %statestack.ins[2]) {
		if(!%statestack.ins[0]) {
			%out1 = 0;
			%out2 = 0;
		}
		else
		{
			%out1 = 1;
			%out2 = 1;
		}
	}
	else if(%statestack.ins[0] == %statestack.ins[1]) {
		if(%statestack.ins[0]){
			%out1 = 1;
			%out2 = 0;
		}
		else
		{
			%out1 = 0;
			%out2 = 1;
		}
	}
	else if(%statestack.ins[0] == %statestack.ins[2]) {
		if(%statestack.ins[0]) {
			%out1 = 1;
			%out2 = 0;
		}
		else
		{
			%out1 = 0;
			%out2 = 1;
		}
	}
	else if(%statestack.ins[1] == %statestack.ins[2]) {
		if(%statestack.ins[1]) {
			%out1 = 1;
			%out2 = 0;
		}
		else
		{
			%out1 = 0;
			%out2 = 1;
		}
	}
	SetPEPowered(%gate.PE[0],%out1,%client);
	SetPEPowered(%gate.PE[1],%out2,%client);
}