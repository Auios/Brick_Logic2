datablock fxDTSBrickData (WireBrick1x1Data : brick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Basic";
	uiName = "WireBrick1x1";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsWire = 1;
};
datablock fxDTSBrickData (WireBrick1x2fData : WireBrick1x1Data)
{
	brickFile = "base/data/Bricks/flats/1x2f.blb";
	category = "LogicBricks";
	subCategory = "Basic";
	uiName = "WireBrick1x2f";
	iconName = "base/client/ui/brickIcons/1x2f";
	alwaysShowWireFrame = false;
};
datablock fxDTSBrickData (WireBrick1x4fData : WireBrick1x1Data)
{
	brickFile = "base/data/Bricks/flats/1x4f.blb";
	category = "LogicBricks";
	subCategory = "Basic";
	uiName = "WireBrick1x4f";
	iconName = "base/client/ui/brickIcons/1x4f";
	alwaysShowWireFrame = false;
};
datablock fxDTSBrickData (WireBrick1x1fData : WireBrick1x1Data)
{
	brickFile = "base/data/Bricks/flats/1x1F.blb";
	category = "LogicBricks";
	subCategory = "Basic";
	uiName = "WireBrick1x1f";
	iconName = "base/client/ui/brickIcons/1x1f";
	alwaysShowWireFrame = false;
};
datablock fxDTSBrickData (WireGauge1x1fData : brick1x1fPrintData)
{
	category = "LogicBricks";
	subCategory = "Basic";
	uiName = "WireGauge";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsWire = 1;
};


//POWER ELEMENT DATA
datablock StaticShapeData(PowerElementShapeData)
{
   shapeFile = "base/data/shapes/empty.dts";
   boxsize = "0.3 0.3 0.3";
   IsLogicBrick = 1;
};
//INPUT ELEMENT DATA
datablock StaticShapeData(InputElementShapeData)
{
   shapeFile = "base/data/shapes/empty.dts";
   boxsize = "0.3 0.3 0.3";
   IsLogicBrick = 1;
};
//visualpower element data.
datablock StaticShapeData(PowerElementVisualData)
{
   shapeFile = "./PEvisual.dts";
   boxsize = "0.3 0.3 0.3";
};
//visual input element data.
datablock StaticShapeData(InputElementVisualData)
{
   shapeFile = "./IEvisual.dts";
   boxsize = "0.3 0.3 0.3";
};






//Boolean Gates----------------------------------
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

datablock fxDTSBrickData (PoweredSwitchOnData : PowerBrick1x1Data)
{
	category = "";
	subCategory = "";
	uiName = "SwitchOn";
	brickFile = "./SwitchOn.blb";
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
	category = "LogicBricks";
	subCategory = "Basic";
	uiName = "Switch";
	brickFile = "./SwitchOff.blb";
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
datablock fxDTSBrickData (NotBrick1x2Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "NotGate";
	brickFile = "./Gate1x2f.blb";
	iconName = "base/client/ui/brickIcons/1x2f";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "NOT Gate";//so in code we can do special things
	TipInfo = "Outputs the opposite of the Input (Binary)";
	//////////////
	ISINSTANT = 0;
	//////////////
	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0 -0.25 0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";

	numIE = 1;
	IEName[0] = "In";
	IEPos[0] = "0 0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
};

datablock fxDTSBrickData (ANDBrick2x3Data : Powerbrick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "ANDGate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "./Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "AND Gate";//so in code we can do special things
	TipInfo = "Outputs True when A and B are On";
	//////////////
	ISINSTANT = 0;
	//////////////
	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0.25 -0.25 0.0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	numIE = 2;
	IEName[0] = "A";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "-0.25 0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
};

datablock fxDTSBrickData (NANDBrick2x3Data : Powerbrick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "NANDGate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "./Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "NAND Gate";//so in code we can do special things
	TipInfo = "Outputs True when A or B but not both are on\nAlso outputs 1 when no input is on";

	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0.25 -0.25 0.0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";

	numIE = 2;
	IEName[0] = "A";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "-0.25 0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
};
datablock fxDTSBrickData (ORBrick2x3Data : Powerbrick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "ORGate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "./Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "OR Gate";//so in code we can do special things
	TipInfo = "Ouputs True when A or B are on";


	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0.25 -0.25 0.0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	numIE = 2;
	IEName[0] = "A";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "-0.25 0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
};
datablock fxDTSBrickData (NORBrick2x3Data : Powerbrick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "NORGate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "./Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "NOR Gate";//so in code we can do special things
	TipInfo = "Outputs True when both A and B are off";

	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0.25 -0.25 0.0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";

	numIE = 2;
	IEName[0] = "A";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "-0.25 0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
};
datablock fxDTSBrickData (XORBrick2x3Data : Powerbrick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "XORGate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "./Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "XOR Gate";//so in code we can do special things
	TipInfo = "Ouputs True when A or B are on\nbut not both";

	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0.25 -0.25 0.0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";

	numIE = 2;
	IEName[0] = "A";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "-0.25 0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
};
datablock fxDTSBrickData (DFlipFlopBrick2x3Data : Powerbrick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Special";
	uiName = "DFlipFlop";
	iconName = "base/client/ui/brickIcons/2x3f";
	brickFile = "./Gate2x3f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "D-FlipFlop";//so in code we can do special things
	TipInfo = "Output is matched to D when the Clock has been pulsed";

	///////////////////
	ISINSTANT = 1;/////
	///////////////////

	numPE = 1;
	PEName[0] = "Out(Numeric)";
	PEPos[0] = "-0.5 0.25 0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	numIE = 2;
	IEName[0] = "D";
	IEPos[0] = "0.5 0.25 0";//D
	IEScale[0] = "0.5 0.5 0.16666";
	IENOTRIG[0] = 0;
	IEName[1] = "Clock";
	IEPos[1] = "0.0 -0.25 0";//Clock
	IEScale[1] = "0.5 0.5 0.16666";
};


datablock fxDTSBrickData (TFlipFlopBrick2x3Data : Powerbrick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Special";
	uiName = "TFlipFlop";
	iconName = "base/client/ui/brickIcons/2x3f";
	brickFile = "./Gate2x3f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "T-FlipFlop";//so in code we can do special things
	TipInfo = "Output toggles on and off when the Clock is pulsed\nBut only when Enable is on";

	///////////////////
	ISINSTANT = 1;/////
	///////////////////

	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "-0.5 0.25 0";//where the first power element will be in local cords relative to center of brick.
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;

	numIE = 2;
	IEName[0] = "Enable";
	IEPos[0] = "0.5 0.25 0";//T
	IEScale[0] = "0.5 0.5 0.16666";
	IENOTRIG[0] = 0;
	IEName[1] = "Clock";
	IEPos[1] = "0.0 -0.25 0";//Clock
	IEScale[1] = "0.5 0.5 0.16666";
};

//4 to 1 line Multiplexor
datablock fxDTSBrickData (MUX4X1Brick4x4Data : Powerbrick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Special";
	uiName = "4X1 MUX";
	iconName = "base/client/ui/brickIcons/4x4f";
	brickFile = "add-ons/brick_logic/Gate4x4f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "Multiplexor";//so in code we can do special things
	TipInfo = "Output is routed from inputs A B C or D\nWhich route depends on the Switches";

	//////////////
	ISINSTANT = 0;
	//////////////
	numPE = 1;
	PEName[0] = "Out(Numeric)";
	PEPos[0] = "0.75 0.75 0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 1;


	numIE = 6;
	//input lines
	IEName[0] = "A";
	IEPos[0] = "-0.75 -0.75 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "-0.25 -0.75 0";
	IEScale[1] = "0.5 0.5 0.16666";
	IEName[2] = "C";
	IEPos[2] = "0.25 -0.75 0";
	IEScale[2] = "0.5 0.5 0.16666";
	IEName[3] = "D";
	IEPos[3] = "0.75 -0.75 0";
	IEScale[3] = "0.5 0.5 0.16666";

	//switches
	IEName[4] = "Switch0";
	IEPos[4] = "-0.75 0.75 0";
	IEScale[4] = "0.5 0.5 0.16666";

	IEName[5] = "Switch1";
	IEPos[5] = "-0.25 0.75 0";
	IEScale[5] = "0.5 0.5 0.16666";

};


datablock fxDTSBrickData (Ram8BitBrickData : Powerbrick1x1Data)//base
{
	category = "LogicBricks";
	subCategory = "Memory";
	uiName = "8Bit Synchronous Ram";
	iconName = "base/client/ui/brickIcons/4x16f";
	brickFile = "./Gate4x16f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "8Bit synchronous RAM";//so in code we can do special things
	TipInfo = "Stores 16 8-bit words with read and write access";

	///////////////////
	ISINSTANT = 0;/////
	///////////////////

	//Main Outputs
	numPE = 8;
	PEName[0] = "Out0(Binary)";
	PEPos[0] = "-3.75 0.75 0.0";
	PEScale[0] = "0.5 0.5 0.16666";

	PEName[1] = "Out1(Binary)";
	PEPos[1] = "-3.25 0.75 0.0";
	PEScale[1] = "0.5 0.5 0.16666";

	PEName[2] = "Out2(Binary)";
	PEPos[2] = "-2.75 0.75 0.0";
	PEScale[2] = "0.5 0.5 0.16666";

	PEName[3] = "Out3(Binary)";
	PEPos[3] = "-2.25 0.75 0.0";
	PEScale[3] = "0.5 0.5 0.16666";

	PEName[4] = "Out4(Binary)";
	PEPos[4] = "-1.75 0.75 0.0";
	PEScale[4] = "0.5 0.5 0.16666";

	PEName[5] = "Out5(Binary)";
	PEPos[5] = "-1.25 0.75 0.0";
	PEScale[5] = "0.5 0.5 0.16666";

	PEName[6] = "Out6(Binary)";
	PEPos[6] = "-0.75 0.75 0.0";
	PEScale[6] = "0.5 0.5 0.16666";

	PEName[7] = "Out7(Binary)";
	PEPos[7] = "-0.25 0.75 0.0";
	PEScale[7] = "0.5 0.5 0.16666";

	//Main Inputs
	numIE = 15;
	IEName[0] = "In0(Binary)";
	IEPos[0] = "-3.75 -0.75 0.0";
	IEScale[0] = "0.5 0.5 0.16666";

	IEName[1] = "In1(Binary)";
	IEPos[1] = "-3.25 -0.75 0.0";
	IEScale[1] = "0.5 0.5 0.16666";

	IEName[2] = "In2(Binary)";
	IEPos[2] = "-2.75 -0.75 0.0";
	IEScale[2] = "0.5 0.5 0.16666";

	IEName[3] = "In3(Binary)";
	IEPos[3] = "-2.25 -0.75 0.0";
	IEScale[3] = "0.5 0.5 0.16666";

	IEName[4] = "In4(Binary)";
	IEPos[4] = "-1.75 -0.75 0.0";
	IEScale[4] = "0.5 0.5 0.16666";

	IEName[5] = "In5(Binary)";
	IEPos[5] = "-1.25 -0.75 0.0";
	IEScale[5] = "0.5 0.5 0.16666";

	IEName[6] = "In6(Binary)";
	IEPos[6] = "-0.75 -0.75 0.0";
	IEScale[6] = "0.5 0.5 0.16666";

	IEName[7] = "In7(Binary)";
	IEPos[7] = "-0.25 -0.75 0.0";
	IEScale[7] = "0.5 0.5 0.16666";

	//Write Enable Pin
	IEName[8] = "Write Enable";
	IEPos[8] = "3.75 -0.75 0.0";
	IEScale[8] = "0.5 0.5 0.16666";

	//Read Enable Pin
	IEName[9] = "Read Enable";
	IEPos[9] = "3.75 -0.25 0.0";
	IEScale[9] = "0.5 0.5 0.16666";

	//Clock
	IEName[10] = "Clock";
	IEPos[10] = "3.75 0.75 0.0";
	IEScale[10] = "0.5 0.5 0.16666";

	//Address Pins
	IEName[11] = "Address0(LSB)";
	IEPos[11] = "1.25 -0.75 0.0";
	IEScale[11] = "0.5 0.5 0.16666";

	IEName[12] = "Address1";
	IEPos[12] = "1.75 -0.75 0.0";
	IEScale[12] = "0.5 0.5 0.16666";

	IEName[13] = "Address2";
	IEPos[13] = "2.25 -0.75 0.0";
	IEScale[13] = "0.5 0.5 0.16666";

	IEName[14] = "Address3(MSB)";
	IEPos[14] = "2.75 -0.75 0.0";
	IEScale[14] = "0.5 0.5 0.16666";
};

package Basic_Logic_Bricks
{
////////////////
//Wire Gauges///
////////////////
function WireGauge1x1fData::onPlant(%data,%this)
{
	Parent::onPlant(%data,%this);

	%val = mAbs(%this.state);
	if(%val <= 9)
	{
		%val = mFloatLength(%val, 0);
		%this.setPrintCount(%val);
	}
	else
	{
		%this.setPrint(72);
	}
}


////////////////////////////////////////////////////////////////
//Switch stuff
//////////////////////////////////////////////////////

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
//switching animation
function fxDTSBrick::onActivate(%gate,%player,%client,%globalhitpos,%unitvector)
{
	parent::onActivate(%gate,%player,%client,%globalhitpos,%unitvector);
	if(%gate.IsLogicBrick && %gate.IsGate)
	{
		if(%gate.GateName $= "SWITCH")
		{
			if(%gate.flipped == 1)
			{

				%gate.setdatablock(PoweredSwitchOffData);
				%gate.flipped = 0;
				return;
			}
			if(%gate.flipped == 0)
			{
				%gate.setdatablock(PoweredSwitchOnData);

				%gate.flipped = 1;
				return;
			}
		}
	}
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



//everything else
function PowerBrick1x1Data::DoLog(%data,%gate,%statestack,%client)
{
	%out = %statestack.outs[0];
	SetPEPowered(%gate.PE[0],%out,%client);
}


function NotBrick1x2Data::DoLog(%data,%gate,%statestack,%client)
{
	%out = !%statestack.ins[0];
	SetPEPowered(%gate.PE[0],%out,%client);
}


function ANDBrick2x3Data::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0] != 0 && %statestack.ins[1] != 0)
	{
		%out = 1;
	}
	else
	{
		%out = 0;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}

function NANDBrick2x3Data::DoLog(%data,%gate,%statestack,%client)
{
	if(!(%statestack.ins[0] != 0 && %statestack.ins[1] != 0))
	{
		%out = 1;
	}
	else
	{
		%out = 0;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}

function ORBrick2x3Data ::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0]!= 0 || %statestack.ins[1]!= 0)
	{
		%out = 1;
	}
	else
	{
		%out = 0;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}
function NORBrick2x3Data::DoLog(%data,%gate,%statestack,%client)
{
	if(!(%statestack.ins[0]!= 0 || %statestack.ins[1]!= 0))
	{
		%out = 1;
	}
	else
	{
		%out = 0;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}
function XORBrick2x3Data::DoLog(%data,%gate,%statestack,%client)
{
	if((!(%statestack.ins[0] != 0 && %statestack.ins[1] != 0))&&(%statestack.ins[0] != 0 || %statestack.ins[1] != 0))
	{
		%out = 1;
	}
	else
	{
		%out = 0;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}
function DFlipFlopBrick2x3Data::DoLog(%data,%gate,%statestack,%client)
{
	if((%gate.IE[1].previousState == 0) && %statestack.ins[1] != 0)//positive clock edge.
	{

		if(%gate.IE[0].previousState == %statestack.ins[0])
		{
			%out = %statestack.ins[0];//d
		}
		else //dont ask me why this works....
		{
			%out = !%statestack.ins[0];
		}

	}
	else
	{
		%out = %statestack.outs[0];
	}

	SetPEPowered(%gate.PE[0],%out,%client);
}


function TFlipFlopBrick2x3Data::DoLog(%data,%gate,%statestack,%client)
{
	if((%gate.IE[1].previousState == 0) && %statestack.ins[1] != 0)//positive clock edge.
	{

		if(%statestack.ins[0] != 0)//if T input is on
		{
			%out = (%statestack.outs[0] == 0);
		}
		else //dont ask me why this works....
		{
			%out = (%statestack.outs[0] != 0);
		}

	}
	else
	{
		%out = %statestack.outs[0];
	}

	SetPEPowered(%gate.PE[0],%out,%client);
}

	//MUX
	function MUX4X1Brick4x4Data::DoLog(%data,%gate,%statestack,%client)
	{
		%out = 0;

		%comb = ((%statestack.ins[5] != 0) & 1) SPC ((%statestack.ins[4]!= 0) & 1); //switches
			switch$(%comb) {
				case "0 0":
					%out = %statestack.ins[0];

				case "0 1":
					%out = %statestack.ins[1];

				case "1 0":
					%out = %statestack.ins[2];

				case "1 1":
					%out = %statestack.ins[3];

			}


		SetPEPowered(%gate.PE[0],%out,%client);

	}

	//RAM
	function Ram8BitBrickData::DoLog(%data,%gate,%statestack,%client)
	{
		//first figure out the address
		%gate.currAddr = (%statestack.ins[11] * 1) + (%statestack.ins[12] * 2) + (%statestack.ins[13] * 4) + (%statestack.ins[14] * 8);

		if((%gate.IE[10].previousState == 0) && %statestack.ins[10] != 0)//positive clock edge.
		{
			if(%statestack.ins[8] == 1)//if write enable
			{
				%gate.data[%gate.currAddr,0] = %statestack.ins[0];
				%gate.data[%gate.currAddr,1] = %statestack.ins[1];
				%gate.data[%gate.currAddr,2] = %statestack.ins[2];
				%gate.data[%gate.currAddr,3] = %statestack.ins[3];
				%gate.data[%gate.currAddr,4] = %statestack.ins[4];
				%gate.data[%gate.currAddr,5] = %statestack.ins[5];
				%gate.data[%gate.currAddr,6] = %statestack.ins[6];
				%gate.data[%gate.currAddr,7] = %statestack.ins[7];
			}
			if(%statestack.ins[9] == 1)//read enabled
			{
				SetPEPowered(%gate.PE[0],%gate.data[%gate.currAddr,0],%client);
				SetPEPowered(%gate.PE[1],%gate.data[%gate.currAddr,1],%client);
				SetPEPowered(%gate.PE[2],%gate.data[%gate.currAddr,2],%client);
				SetPEPowered(%gate.PE[3],%gate.data[%gate.currAddr,3],%client);
				SetPEPowered(%gate.PE[4],%gate.data[%gate.currAddr,4],%client);
				SetPEPowered(%gate.PE[5],%gate.data[%gate.currAddr,5],%client);
				SetPEPowered(%gate.PE[6],%gate.data[%gate.currAddr,6],%client);
				SetPEPowered(%gate.PE[7],%gate.data[%gate.currAddr,7],%client);
			}
		}
	}

};
activatepackage(Basic_Logic_Bricks);

//
