datablock fxDTSBrickData (PixelLowBrick1x2Data : Powerbrick1x1Data)
{
	category = "Bus Bricks";
	subCategory = "Special";
	uiName = "Pixel Low";
	brickFile = "base/data/bricks/bricks/1x2.blb";
	iconName = "base/client/ui/brickIcons/1x2";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Pixel_Low";
	TipInfo = "";
	ISINSTANT = 0;
	numPE = 0;

	numIE = 1;
	IEName[0] = "Input";
	IEPos[0] = "-0.25 0 -0.2";
	IEScale[0] = "0.5 0.5 0.16666";
};

function PixelLowBrick1x2Data::DoLog(%data, %gate, %statestack, %client)
{
	if(%statestack.ins[0] > 0)
	{
		%gate.setColorFX(3);
		%gate.setColor((%statestack.ins[0]-1) % 63);
	}
	else
	{
		%gate.setColorFX(0);
		%gate.setColor(53);
	}
}