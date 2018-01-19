//refreshSystem.cs

//The global refresh system, refreshed logic bricks around holes, usually used when deleteing logic bricks.
$GlobalRefreshSystem = new ScriptObject(RefreshSystem)
{
	array[0] = "";
	count = 0;
	iswiping = 0;
};

function RefreshSystem::AddBox(%this,%worldbox)
{	
	%this.array[%this.count] = %worldbox;
	%this.count++;
}

function RefreshSystem::Clear(%this)
{
	for(%a=0;%a < %this.count;%a++)
	{
		%this.array[%a] = 0;
	}
	%this.count = 0;
}

function RefreshSystem::SuggestWipe(%this)
{
	//echo("suggested wipe");
	if(%this.iswiping == 0)
	{
		//echo("accepted wipe");
		%this.schedule(1000,"wipe");
		%this.iswiping = 1;
	}
}

function RefreshSystem::Wipe(%this)
{
	//echo("wipe");
	for(%a=0;%a < %this.count;%a++)
	{
		RefreshAroundBlankBox(%this.array[%a]);		
	}
	%this.clear();
	%this.iswiping = 0;
}