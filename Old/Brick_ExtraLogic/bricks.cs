datablock fxDTSBrickData (WireBrick1x3fData : WireBrick1x1Data)
{
	brickFile = "base/data/Bricks/flats/1x3f.blb";
	category = "LogicBricks";
	subCategory = "Basic";
	uiName = "WireBrick1x3f";
	iconName = "base/client/ui/brickIcons/1x3f";
	alwaysShowWireFrame = false;
};

datablock fxDTSBrickData (logButtonBrickData : brick1x1fData) //avoid conflict with any JVS content or props named buttonBrickData
{
	category = "LogicBricks";
	subCategory = "Special";
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

datablock fxDTSBrickData (logPresPlateBrickData : brick4x4fData) //avoid conflict with any JVS content or props named presPlateBrickData
{
	category = "LogicBricks";
	subCategory = "Special";
	uiName = "PressurePlate";
	brickFile = "base/data/Bricks/Bricks/1x1f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "PRESPLATE";
	TipInfo = "Stand on it to provide power!";
	numPE = 1;
	PEPos[0] = "0 0 0";
	PEScale[0] = "2 2 0.25";
	PEStart[0] = 0;
	numIE = 0;
	IEPos[0] = "0 0 0";
};
datablock fxDTSBrickData (DiodeBrick1x2Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Special";
	uiName = "DiodeGate";
	brickFile = "Add-Ons/Brick_Logic/Gate1x2f.blb";
	iconName = "base/client/ui/brickIcons/1x2f";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "DIODE";
	TipInfo = "Allows only the wire on the OUTPUT side to be affected.";
	ISINSTANT = 0;
	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0 -0.25 0";
	PEScale[0] = "0.5 0.5 0.16666";
	numIE = 1;
	IEName[0] = "In";
	IEPos[0] = "0 0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
};
//1 to 4 line Demultiplexor
datablock fxDTSBrickData (DEMUX4X1Brick4x4Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Special";
	uiName = "1X4 DEMUX";
	iconName = "base/client/ui/brickIcons/4x4f";
	brickFile = "Add-Ons/Brick_Logic/Gate4x4f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "De-Multiplexor";
	TipInfo = "Input is sent to Out1-4\nThe route depends on the Switch inputs";
	ISINSTANT = 0;
	numPE = 4;
	PEName[0] = "Out0";
	PEPos[0] = "-0.75 -0.75 0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;
	PEName[1] = "Out1";
	PEPos[1] = "-0.25 -0.75 0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;
	PEName[2] = "Out2";
	PEPos[2] = "0.25 -0.75 0";
	PEScale[2] = "0.5 0.5 0.16666";
	PEStart[2] = 0;
	PEName[3] = "Out3";
	PEPos[3] = "0.75 -0.75 0";
	PEScale[3] = "0.5 0.5 0.16666";
	PEStart[3] = 0;
	numIE = 3;
	IEName[0] = "Input";
	IEPos[0] = "0.75 0.75 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "Switch0";
	IEPos[1] = "-0.75 0.75 0";
	IEScale[1] = "0.5 0.5 0.16666";
	IEName[2] = "Switch1";
	IEPos[2] = "-0.25 0.75 0";
	IEScale[2] = "0.5 0.5 0.16666";
};
datablock fxDTSBrickData (IMPLIESBrick2x2Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "IMPLIESGate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "IMPLIES Gate";
	TipInfo = "Outputs False if A but not B";
	ISINSTANT = 0;
	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0.25 -0.25 0.0";
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
datablock fxDTSBrickData (IMPLIEDBrick2x2Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "IMPLIEDGate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "IMPLIED Gate";
	TipInfo = "Outputs False if B but not A";
	ISINSTANT = 0;
	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0.25 -0.25 0.0";
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
datablock fxDTSBrickData (NIMPLIESBrick2x2Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "NIMPLIESGate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "NIMPLIES Gate";
	TipInfo = "Outputs True if A but not B";
	ISINSTANT = 0;
	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0.25 -0.25 0.0";
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
datablock fxDTSBrickData (NIMPLIEDBrick2x2Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "NIMPLIEDGate";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "NIMPLIED Gate";
	TipInfo = "Outputs True if B but not A";
	ISINSTANT = 0;
	numPE = 1;
	PEName[0] = "Out(Binary)";
	PEPos[0] = "0.25 -0.25 0.0";
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
datablock fxDTSBrickData (HalfAdderBrick2x2Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "Half Adder";
	iconName = "base/client/ui/brickIcons/2x2f";
	brickFile = "Add-Ons/Brick_Logic/Gate2x2f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "HALFADDER Gate";
	TipInfo = "Binary addition.";
	ISINSTANT = 0;
	numPE = 2;
	PEName[0] = "Sum";
	PEPos[0] = "0.25 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;
	PEName[1] = "Carry";
	PEPos[1] = "0.25 -0.25 0.0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;
	numIE = 2;
	IEName[0] = "A";
	IEPos[0] = "-0.25 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "-0.25 0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
};
datablock fxDTSBrickData (FullAdderBrick2x3Data : Powerbrick1x1Data)
{
	category = "LogicBricks";
	subCategory = "Gates";
	uiName = "Full Adder";
	iconName = "base/client/ui/brickIcons/2x3f";
	brickFile = "Add-Ons/Brick_Logic/Gate2x3f.blb";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsGate = 1;
	GateName = "HALFADDER Gate";
	TipInfo = "Binary addition.";
	ISINSTANT = 0;
	numPE = 2;
	PEName[0] = "Co";
	PEPos[0] = "-0.5 0.25 0.0";
	PEScale[0] = "0.5 0.5 0.16666";
	PEStart[0] = 0;
	PEName[1] = "Sum";
	PEPos[1] = "0 0.25 0.0";
	PEScale[1] = "0.5 0.5 0.16666";
	PEStart[1] = 0;
	numIE = 3;
	IEName[0] = "A";
	IEPos[0] = "-0.5 -0.25 0";
	IEScale[0] = "0.5 0.5 0.16666";
	IEName[1] = "B";
	IEPos[1] = "0 -0.25 0";
	IEScale[1] = "0.5 0.5 0.16666";
	IEName[2] = "Ci";
	IEPos[2] = "0.5 -0.25 0";
	IEScale[2] = "0.5 0.5 0.16666";
};
package Think_Logic_Bricks
{
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
function logPresPlateBrickData::onplant(%data,%brick)
{
		Parent::onplant(%data,%brick);
		%brick.clearEvents();
		%brick.AddEvent( 1, "0", "onPlayerTouch", "Self", "fireRelay");
		%brick.AddEvent( 1, "0", "onPlayerTouch", "Self", "setEventEnabled", "0 1", 0);
		%brick.AddEvent( 1, "0", "onRelay", "Self", "SetPower", 1);
		%brick.AddEvent( 1, "2000", "onRelay", "Self", "SetPower", 0);
		%brick.AddEvent( 1, "2000", "onRelay", "Self", "setEventEnabled", "0 1", 1);
		//player.isTouching test?
}
function DiodeBrick1x2Data::DoLog(%data,%gate,%statestack,%client)
{
	%out = %statestack.ins[0];	
	SetPEPowered(%gate.PE[0],%out,%client);
}
function HalfAdderBrick2x2Data::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0] != %statestack.ins[1])
	{
		%out1 = 1;
		%out2 = 0;
	}
	else if (%statestack.ins[0] == 1)
	{
		%out1 = 1;
		%out2 = 1;
	}
	else
	{
		%out1 = 0;
		%out2 = 0;
	}
	SetPEPowered(%gate.PE[0],%out1,%client);
	SetPEPowered(%gate.PE[1],%out2,%client);
}
function FullAdderBrick2x3Data::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0] == %statestack.ins[1] && %statestack.ins[0] == %statestack.ins[2]) {
		if(%statestack.ins[0] == 0) {
			%out1 = 0;
			%out2 = 0;
		}
		else
		{
			%out1 = 1;
			%out2 = 1;
		}
	}
	else if(%statestack.ins[0] == %statestack.ins[1]) {
		if(%statestack.ins[0] == 1){
			%out1 = 1;
			%out2 = 0;
		}
		else
		{
			%out1 = 0;
			%out2 = 1;
		}
	}
	else if(%statestack.ins[0] == %statestack.ins[2]) {
		if(%statestack.ins[0] == 1) {
			%out1 = 1;
			%out2 = 0;
		}
		else
		{
			%out1 = 0;
			%out2 = 1;
		}
	}
	else if(%statestack.ins[1] == %statestack.ins[2]) {
		if(%statestack.ins[1] == 1) {
			%out1 = 1;
			%out2 = 0;
		}
		else
		{
			%out1 = 0;
			%out2 = 1;
		}
	}
	SetPEPowered(%gate.PE[0],%out1,%client);
	SetPEPowered(%gate.PE[1],%out2,%client);
}
function NIMPLIESBrick2x2Data::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0] != 0 && %statestack.ins[1] != 1)
	{
		%out = 1;
	}
	else
	{
		%out = 0;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}
function NIMPLIEDBrick2x2Data::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0] != 1 && %statestack.ins[1] != 0)
	{
		%out = 1;
	}
	else
	{
		%out = 0;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}
function IMPLIESBrick2x2Data::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0] != 0 && %statestack.ins[1] != 1)
	{
		%out = 0;
	}
	else
	{
		%out = 1;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}
function IMPLIEDBrick2x2Data::DoLog(%data,%gate,%statestack,%client)
{
	if(%statestack.ins[0] != 1 && %statestack.ins[1] != 0)
	{
		%out = 0;
	}
	else
	{
		%out = 1;
	}
	SetPEPowered(%gate.PE[0],%out,%client);
}
	function DEMUX4X1Brick4x4Data::DoLog(%data,%gate,%statestack,%client)
	{
		%out = %statestack.ins[0];
		%n = 0;
		%comb = ((%statestack.ins[2] != 0) & 1) SPC ((%statestack.ins[1]!= 0) & 1);
			switch$(%comb) {  
				case "0 0":
					%n = 0;
				case "0 1":
					%n = 1;
				case "1 0":
					%n = 2;
				case "1 1":
					%n = 3;
			}
		
		SetPEPowered(%gate.PE[0],0,%client);
		SetPEPowered(%gate.PE[1],0,%client);
		SetPEPowered(%gate.PE[2],0,%client);
		SetPEPowered(%gate.PE[3],0,%client);
		SetPEPowered(%gate.PE[%n],%out,%client);
	}
};
activatepackage(Think_Logic_Bricks);