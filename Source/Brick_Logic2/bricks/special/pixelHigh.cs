datablock fxDTSBrickData (PixelHighBrick1x2Data : Powerbrick1x1Data)
{
	category = "Logic Bricks";
	subCategory = "Special";
	uiName = "Pixel High";
	brickFile = "base/data/bricks/bricks/1x2.blb";
	iconName = "base/client/ui/brickIcons/1x2";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Pixel_High";
	TipInfo = "";
	ISINSTANT = 0;
	numPE = 0;

	numIE = 1;
	IEName[0] = "Input";
	IEPos[0] = "-0.25 0 0.2";
	IEScale[0] = "0.5 0.5 0.16666";
};

function PixelHighBrick1x2Data::DoLog(%data, %gate, %statestack, %client)
{
	if(%statestack.ins[0])
	{
		%gate.setColorFX(3);
	}
	else
	{
		%gate.setColorFX(0);
	}
}