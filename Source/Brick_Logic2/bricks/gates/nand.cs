datablock fxDTSBrickData (NANDBrick2x2Data : Powerbrick1x1Data)//base
{
	category = "Logic Bricks";
	subCategory = "Logic Gates";
	uiName = "NAND Gate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "NAND Gate";//so in code we can do special things
	TipInfo = "Outputs false when A and B are true";

	numPE = 1;
	PEName[0] = "Output";
	PEPos[0] = "-0.25 0.25 0.0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";

	numIE = 2;
	IEName[0] = "A";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "0.25 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
};

function NANDBrick2x2Data::DoLog(%data,%gate,%statestack,%client)
{
	if(!%statestack.ins[0] && !%statestack.ins[1])
	{
		%out = 1;
	}
	else
	{
		%out = 0;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}