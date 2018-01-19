datablock fxDTSBrickData (WireGauge1x1fData : brick1x1fPrintData)
{
	category = "LogicBricks";
	subCategory = "Wires";
	uiName = "WireGauge";
	alwaysShowWireFrame = false;
	IsLogicBrick = 1;
	IsWire = 1;
};

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