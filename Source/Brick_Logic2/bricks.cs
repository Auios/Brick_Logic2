//bricks.cs

//POWER ELEMENT DATA
datablock StaticShapeData(LogicElementShapeData)
{
	shapeFile = "base/data/shapes/empty.dts";
	boxsize = "0.3 0.3 0.3";
	IsLogicBrick = 1;
};
//visualpower element data.
datablock StaticShapeData(PowerElementVisualData)
{
	shapeFile = "./bricks/PEvisual.dts";
	boxsize = "0.3 0.3 0.3";
};
//visual input element data.
datablock StaticShapeData(InputElementVisualData)
{
	shapeFile = "./bricks/IEvisual.dts";
	boxsize = "0.3 0.3 0.3";
};

package LogicBrick_Functions
{
	//Switching animation
	function fxDTSBrick::onActivate(%gate, %player, %client, %globalhitpos, %unitvector)
	{
		parent::onActivate(%gate, %player, %client, %globalhitpos, %unitvector);
		if(%gate.IsLogicBrick && %gate.IsGate)
		{
			if(%gate.GateName $= "SWITCH")
			{
				if(%gate.flipped)
				{
					%gate.setdatablock(PoweredSwitchOffData);
					%gate.flipped = 0;
				}
				else
				{
					%gate.setdatablock(PoweredSwitchOnData);
					%gate.flipped = 1;
				}
			}
		}
	}
};
activatepackage("LogicBrick_Functions");

//Parent
exec("./bricks/special/poweredBrick.cs");

/////////////
////BASIC////
/////////////

//Wires
exec("./bricks/wires/1x1.cs");
exec("./bricks/wires/1x1x5.cs");
exec("./bricks/wires/1x1f.cs");
exec("./bricks/wires/1x2f.cs");
exec("./bricks/wires/1x3f.cs");
exec("./bricks/wires/1x4f.cs");
exec("./bricks/wires/1x6f.cs");
exec("./bricks/wires/wireGauge1x1f.cs");

//Gates
exec("./bricks/gates/and.cs");
exec("./bricks/gates/or.cs");
exec("./bricks/gates/xor.cs");
exec("./bricks/gates/not.cs");
exec("./bricks/gates/nand.cs");
exec("./bricks/gates/nor.cs");

//Inputs
exec("./bricks/inputs/switch.cs");
exec("./bricks/inputs/button.cs");

//Arithmetic
exec("./bricks/arithmetic/halfAdder.cs");
exec("./bricks/arithmetic/fullAdder.cs");
exec("./bricks/arithmetic/halfSubtractor.cs");
exec("./bricks/arithmetic/fullSubtractor.cs");

exec("./bricks/arithmetic/8bitAdder.cs");
exec("./bricks/arithmetic/8bitSubtractor.cs");
exec("./bricks/arithmetic/8bitMultiplier.cs");
exec("./bricks/arithmetic/8bitDivisor.cs");

//Special
exec("./bricks/special/diode.cs");
exec("./bricks/special/8bitEnabler.cs");
exec("./bricks/special/pixelLow.cs");
exec("./bricks/special/pixelHigh.cs");

//Chips
exec("./bricks/chips/4bitDecoder.cs");
exec("./bricks/chips/4bitEncoder.cs");
exec("./bricks/chips/7segDecoder.cs");

//Memory
exec("./bricks/memory/memoryCell.cs");
exec("./bricks/memory/16byteRAM.cs");
exec("./bricks/memory/256byteRAM.cs");

/////////////
////BUS//////
/////////////

//Gates
exec("./bricks/bus/gates/busAnd.cs");
exec("./bricks/bus/gates/busOr.cs");
exec("./bricks/bus/gates/busXor.cs");
exec("./bricks/bus/gates/busNot.cs");
exec("./bricks/bus/gates/busNand.cs");
exec("./bricks/bus/gates/busNor.cs");

//Arithmetic
exec("./bricks/bus/arithmetic/adder.cs");
exec("./bricks/bus/arithmetic/subtractor.cs");
exec("./bricks/bus/arithmetic/multiplier.cs");
exec("./bricks/bus/arithmetic/divisor.cs");

//Math
exec("./bricks/bus/math/mFloor.cs");
exec("./bricks/bus/math/mCeil.cs");
exec("./bricks/bus/math/mAbs.cs");
exec("./bricks/bus/math/mFloatLength.cs");

//Conditional
exec("./bricks/bus/conditional/equal.cs");
exec("./bricks/bus/conditional/notEqual.cs");
exec("./bricks/bus/conditional/greater.cs");
exec("./bricks/bus/conditional/lesser.cs");

//Converters
exec("./bricks/bus/converters/16bitToBus.cs");
exec("./bricks/bus/converters/busTo16bit.cs");