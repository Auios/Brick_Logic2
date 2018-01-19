datablock fxDTSBrickData (NotBrick1x2Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Logic Gates";
	uiName = "NOT Gate";
	brickFile = "../Gate1x2f.blb";
	iconName = "base/client/ui/brickIcons/1x2f";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "NOT Gate";//so in code we can do special things
	TipInfo = "Outputs the inverse of the input";
	//////////////
	ISINSTANT = 0;
	//////////////
	numPE = 1;
	PEName[0] = "Output";
	PEPos[0] = "0 0.25 0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";

	numIE = 1;
	IEName[0] = "Input";
	IEPos[0] = "0 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
};