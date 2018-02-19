datablock fxDTSBrickData (mCeilBrick1x2Data : Powerbrick1x1Data)
{
	category = "Bus Bricks";
	subCategory = "Math";
	uiName = "mCeil";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate1x2f.blb";
	iconName = "base/client/ui/brickIcons/1x2f";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "mCeil";
	TipInfo = "";
	//////////////
	ISINSTANT = 0;
	//////////////
	numPE = 1;
	PEName[0] = "Output";
	PEPos[0] = "0 0.25 0";
	PEScale[0] = "0.5 0.5 0.16666";

	numIE = 1;
	IEName[0] = "Input";
	IEPos[0] = "0 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
};

function mCeilBrick1x2Data::DoLog(%data, %gate, %statestack, %client)
{
	SetPEPowered(%gate.PE[0], mCeil(%statestack.ins[0]), %client);
}
