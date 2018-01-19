package SpaceTick
{
    function SpaceTick(%ticknum)
    {
        //Controller Ticks
        for(%i=1;(%str = getField($SpaceMods::SpaceTick::Controllers,%i)) !$= "";%i++)
        {
            if(isObject(%str))
                %str.tick();
        }

        $SpaceMods::SpaceTick = schedule(33,0,spacetick);
    }

    function disconnect()
    {
        cancel($SpaceMods::SpaceTick);
        $SpaceMods::SpaceTick = 0;
        for(%i=1;(%str = getField($SpaceTick::SpaceTick::Controllers,%i)) !$= "";%i++)
        {
            if(isObject(%str))
                %str.delete();
        }
        Parent::disconnect();
    }

    function SimSet::tick(%this) //Can't call "XCtrlSO::Tick()" for some reason
    {
        call(%this.callFn,%this);
    }
};
activatepackage(SpaceTick);

$SpaceMods::SpaceTick = schedule(33,0,SpaceTick);