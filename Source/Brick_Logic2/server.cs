//Brick_Logic2

if($RTB::Hooks::ServerControl)
{
	RTB_registerPref("Show Wire Tips", "Logic Bricks", "$Pref::Server::LogicBricks::ShowWireTips", "bool", "Logic_Bricks", true, 0, 0, "");
	RTB_registerPref("Show Gate Tips", "Logic Bricks", "$Pref::Server::LogicBricks::ShowGateTips", "bool", "Logic_Bricks", true, 0, 0, "");
}
else
{
	if($Pref::Server::LogicBricks::ShowWireTips $= "") $Pref::Server::LogicBricks::ShowWireTips = true;
	if($Pref::Server::LogicBricks::ShowGateTips $= "") $Pref::Server::LogicBricks::ShowGateTips = true;
}

//lets start up spacetick, it may be already up due to other mods, but we'll check.
//This handles the tick based method that this mod uses, the whole logic system runs off 1 schedule.
//All Credits to SpaceGuy!

if(!isEventPending($SpaceMods::SpaceTick))
{
	exec("./spaceTicks.cs");
}

//See If Variables Events are on the server
if($VCE::Server::Version)
{
	exec("./VCEGlew.cs");
}

exec("./bricks.cs"); 
exec("./logic.cs"); 
exec("./tips.cs"); 

//Extra stuff

function getBinary(%decimalNumber, %position)
{
	return (%decimalNumber >> %position) & 1;
}