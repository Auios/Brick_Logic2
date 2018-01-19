datablock fxDTSBrickData (WireGauge1x1fData : brick1x1fPrintData)
{
	category = "Logic Bricks";
	subCategory = "Wires";
	uiName = "Wire Gauge";
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