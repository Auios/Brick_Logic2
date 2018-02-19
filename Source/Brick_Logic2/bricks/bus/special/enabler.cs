datablock fxDTSBrickData (enablerBrick2x2Data : Powerbrick1x1Data)//base
{
	category = "Bus Bricks";
	subCategory = "Special";
	uiName = "Enabler";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic2/bricks/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Enabler";
	TipInfo = "";
	//////////////
	ISINSTANT = 0;
	//////////////
	numPE = 1;
	PEName[0] = "Output";
	PEPos[0] = "0.25 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	numIE = 2;
	IEName[0] = "Input";
	IEPos[0] = "0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "Enable";
	IEPos[1] = "-0.25 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
};

function enablerBrick2x2Data::DoLog(%data, %gate, %statestack, %client)
{
	if(%statestack.ins[1] > 0)
	{
		SetPEPowered(%gate.PE[0], %statestack.ins[0], %client);
	}
	else
	{
		SetPEPowered(%gate.PE[0], 0, %client);
	}
}
