//events.cs

registerInputEvent("fxDTSBrick","onPowerChange","Self fxDTSBrick" TAB "Client GameConnection" TAB "Player Player",1);
registerInputEvent("fxDTSBrick","onPowerOn","Self fxDTSBrick" TAB "Client GameConnection" TAB "Player Player",1);
registerInputEvent("fxDTSBrick","onPowerOff","Self fxDTSBrick" TAB "Client GameConnection" TAB "Player Player",1);

registerOutputEvent(fxDTSBrick, SetPower, "string 30 50", 1);
registerOutputEvent(fxDTSBrick, SetIsWire, "bool 1", 1);
