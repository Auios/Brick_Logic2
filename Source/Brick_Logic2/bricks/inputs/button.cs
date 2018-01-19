datablock fxDTSBrickData (logButtonBrickData : brick1x1fData) //avoid conflict with any JVS content or props named buttonBrickData
{
	category = "Logic Bricks";
	subCategory = "Inputs";
	uiName = "Button";
	brickFile = "base/data/Bricks/Bricks/1x1f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "BUTTON";
	DontDisplayTips = 1;
	numPE = 1;
	PEPos[0] = "0 0 0";
	PEScale[0] = "0.5 0.5 0.2";
	PEStart[0] = 0;
	numIE = 0;
	IEPos[0] = "0 0 0";
};

function logButtonBrickData::onplant(%data,%brick)
{
	Parent::onplant(%data,%brick);
	%brick.clearEvents();
	%brick.AddEvent( 1, "0", "onActivate", "Self", "fireRelay");
	%brick.AddEvent( 1, "0", "onActivate", "Self", "setEventEnabled", "0 1", 0);
	%brick.AddEvent( 1, "0", "onRelay", "Self", "SetPower", 1);
	%brick.AddEvent( 1, "500", "onRelay", "Self", "SetPower", 0);
	%brick.AddEvent( 1, "533", "onRelay", "Self", "setEventEnabled", "0 1", 1);
}