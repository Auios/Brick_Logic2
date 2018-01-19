
%error = ForceRequiredAddOn("Brick_Logic");

if(%error == $Error::AddOn_NotFound)
	error("ERROR: Brick_ThinkLogic - required add-on Brick_Logic not found. Mod cannot load.");
else
{
	exec("./bricks.cs"); 
}