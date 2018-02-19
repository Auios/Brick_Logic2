datablock fxDTSBrickData (busNotBrick1x2Data : Powerbrick1x1Data)
{
	category = "Bus Bricks";
	subCategory = "Basic Gates";
	uiName = "Bus NOT Gate";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate1x2f.blb";
	iconName = "base/client/ui/brickIcons/1x2f";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Bus NOT Gate";//so in code we can do special things
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

function busNotBrick1x2Data::DoLog(%data, %gate, %statestack, %client)
{
	SetPEPowered(%gate.PE[0], not(%statestack.ins[0]), %client);
}
