//Logic Bricks
//
//Author: Melting Plastic
//Version: 1 RTB Release 3
//
//RTB Release 2: Fixed Switch Icon, OnPowerOn, OnPowerOff work with decimals.
//RTB Release 3: Fixed Switches incorrectly loading.  Tweaked the Multiplexer

//RTB Mod Prefs////////////////////////////////////////////////////////////////
if(isFile(%file = "config/server/RTB/modprefs.cs"))
{
	exec(%file);
}
//if the preset are not set (first time), then set them
if($Pref::Logic_Bricks::ShowWireTips $= "")
{
	$Pref::Logic_Bricks::ShowWireTips = True;
}
if($Pref::Logic_Bricks::ShowGateTips $= "")
{
	$Pref::Logic_Bricks::ShowGateTips = True;
}

if(isFile("Add-Ons/System_ReturnToBlockland/server.cs"))
{
	if(!$RTB::RTBR_ServerControl_Hook)
	{
		exec("Add-Ons/System_ReturnToBlockland/RTBR_ServerControl_Hook.cs");
	}
	RTB_registerPref("Show Wire Tips","Logic_Bricks","$Pref::Logic_Bricks::ShowWireTips","bool","Logic_Bricks",25,0,0);
	RTB_registerPref("Show Gate Tips","Logic_Bricks","$Pref::Logic_Bricks::ShowGateTips","bool","Logic_Bricks",25,0,0);
}



//lets start up spacetick, it may be already up due to other mods, but we'll check.
//This handles the tick based method that this mod uses, the whole logic system runs off 1 schedule.
//All Credits to SpaceGuy!

if(!isEventPending($SpaceMods::SpaceTick))
{
  exec("./SpaceTick.cs");
}

//See If Variables Events are on the server
if($VCE::Server::Version)
{
  exec("./VCEGlew.cs");
}


exec("./bricks.cs"); 
exec("./Logic.cs"); 
exec("./Tips.cs"); 