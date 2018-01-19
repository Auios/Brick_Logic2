datablock fxDTSBrickData (PoweredSwitchOnData : PowerBrick1x1Data)
{
	category = "";
	subCategory = "";
	uiName = "SwitchOn";
	brickFile = "Add-Ons/Brick_Logic2/bricks/SwitchOn.blb";
	iconName = "";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "SWITCH";//so in code we can do special things
	DontDisplayTips = 1;
	//////////////
	ISINSTANT = 0;
	//////////////
	numPE = 2;
	PEPos[0] = "0 -0.25 0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.2";
	PENoRender[0] = 1;//dont render the PE
	PEStart[0] = 1;

	PEPos[1] = "0 0.25 0";//where the first power element will be in local cords relative to center of brick.
	PEScale[1] = "0.5 0.5 0.2";
	PENoRender[1] = 1;//dont render the PE
	PEStart[1] = 1;

	numIE = 0;
	IEPos[0] = "0 0 0";
};

datablock fxDTSBrickData (PoweredSwitchOffData : PoweredSwitchOnData)
{
	category = "Logic Bricks";
	subCategory = "Inputs";
	uiName = "Switch";
	brickFile = "Add-Ons/Brick_Logic2/bricks/SwitchOff.blb";
	iconName = "Add-Ons/Brick_Logic/Switch";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "SWITCH";//so in code we can do special things
	DontDisplayTips = 1;
	//////////////
	ISINSTANT = 0;
	//////////////
	numPE = 2;
	PEPos[0] = "0 -0.25 0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.2";
	PENoRender[0] = 1;//dont redeer the PE
	PEStart[0] = 0;

	PEPos[1] = "0 0.25 0";//where the first power element will be in local cords relative to center of brick.
	PEScale[1] = "0.5 0.5 0.2";
	PENoRender[1] = 1;//dont redeer the PE
	PEStart[1] = 0;

	numIE = 0;
	IEPos[0] = "0 0 0";
};

function PoweredSwitchOnData::onplant(%data,%brick)//note that this will not be called when loading bricks, which is good
{
	Parent::onplant(%data,%brick);

	%brick.clearEvents();

	//AddEvent(%obj.getGroup().client, %enabled, %inputEventIdx, %delay, %targetIdx, %NamedTargetNameIdx, %outputEventIdx" @ %obj.dataBlock.contentType.eventParameterString[%i] @ ")
	%brick.AddEvent( 1, "0", "onActivate", "Self", "toggleEventEnabled", "1 2");
	%brick.AddEvent( 0, "0", "onActivate", "Self", "SetPower", 1);
	%brick.AddEvent( 1, "0", "onActivate", "Self", "SetPower", 0);

	%brick.flipped = 1;
}

function PoweredSwitchOffData::onplant(%data,%brick)//note that this will not be called when loading bricks, which is good
{
	Parent::onplant(%data,%brick);

	%brick.clearEvents();

	//AddEvent(%obj.getGroup().client, %enabled, %inputEventIdx, %delay, %targetIdx, %NamedTargetNameIdx, %outputEventIdx" @ %obj.dataBlock.contentType.eventParameterString[%i] @ ")
	%brick.AddEvent( 1, "0", "onActivate", "Self", "toggleEventEnabled", "1 2");
	%brick.AddEvent( 1, "0", "onActivate", "Self", "SetPower", 1);
	%brick.AddEvent( 0, "0", "onActivate", "Self", "SetPower", 0);

	%brick.flipped = 0;
}

//for setting flip value upon loading.
function PoweredSwitchOnData::onLoadplant(%data,%brick)
{
	parent::onLoadplant(%data,%brick);
	%brick.flipped = 1;
}

function PoweredSwitchOffData::onLoadplant(%data,%brick)
{
	parent::onLoadplant(%data,%brick);
	%brick.flipped = 0;
}

function PoweredSwitchOnData::DoLog(%data,%gate,%statestack,%client)
{
	%out = %statestack.outs[0];

	SetPEPowered(%gate.PE[0],%out,%client);
	SetPEPowered(%gate.PE[1],%out,%client);
}

function PoweredSwitchOffData::DoLog(%data,%gate,%statestack,%client)
{
	%out = %statestack.outs[0];

	SetPEPowered(%gate.PE[0],%out,%client);
	SetPEPowered(%gate.PE[1],%out,%client);
}