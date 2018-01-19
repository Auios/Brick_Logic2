datablock fxDTSBrickData (PowerBrick1x1Data : brick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Special";
	uiName = "PoweredBrick";
	brickFile = "base/data/Bricks/Bricks/1x1.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Powered Brick";//so in code we can do special things
	TipInfo = "Supplies Constant Power";

	numPE = 1;
	PEName[0] = "Out0";
	PEPos[0] = "0 0 0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.6";//this is the scale for a 1x1 brick.
	PEStart[0] = 1;//starts in the on state!

	numIE = 0;
	IEPos[0] = "0 0 0";
};

function PowerBrick1x1Data::DoLog(%data,%gate,%statestack,%client)
{
	%out = %statestack.outs[0];
	SetPEPowered(%gate.PE[0],%out,%client);
}