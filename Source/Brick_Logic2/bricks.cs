//bricks.cs

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
};
activatepackage(LogicBrick_Functions);

//Parent
exec("./bricks/special/poweredBrick.cs");

//Wires
exec("./bricks/wires/1x1.cs");
exec("./bricks/wires/1x1f.cs");
exec("./bricks/wires/1x2f.cs");
exec("./bricks/wires/1x3f.cs");
exec("./bricks/wires/1x4f.cs");
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

//Special
exec("./bricks/special/diode.cs");
exec("./bricks/special/halfAdder.cs");
exec("./bricks/special/fullAdder.cs");

//Chips
exec("./bricks/chips/7segDecoder.cs");

//Memory
exec("./bricks/memory/16byteRAM.cs");