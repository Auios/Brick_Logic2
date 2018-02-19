datablock fxDTSBrickData (PowerBrick1x1Data : brick1x1Data)
{
	category = "";
	subCategory = "";
	uiName = "";
	brickFile = "base/data/Bricks/Bricks/1x1.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Powered Brick";
	TipInfo = "Supplies Constant Power";

	numPE = 1;
	PEName[0] = "Output";
	PEPos[0] = "0 0 0";
	PEScale[0] = "0.5 0.5 0.6";
	PEStart[0] = 1;

	numIE = 0;
	IEPos[0] = "0 0 0";
};

function PowerBrick1x1Data::DoLog(%data,%gate,%statestack,%client)
{
	%out = %statestack.outs[0];
	SetPEPowered(%gate.PE[0],%out,%client);
}