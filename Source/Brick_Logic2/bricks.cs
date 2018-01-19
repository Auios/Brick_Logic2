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

exec("./bricks/wires/1x1.cs");