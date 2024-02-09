public class LevelBar
{
    int _level;
    public void GetLevel(int points)
    {
        _level = points / 1000;
        Console.Write($"Lvl {_level} ");
        DisplayLevelBar();
        Console.Write(" Lvl 20\n");
    }

    public void DisplayLevelBar()
    {
        if (20 <= _level)
        {
            Console.Write("|* * * * * * * * * *|");
        }
        else if (18 <= _level)
        {
            Console.Write("|* * * * * * * * * _|");
        }
        else if (16 <= _level)
        {
            Console.Write("|* * * * * * * * _ _|");
        }
        else if (14 <= _level)
        {
            Console.Write("|* * * * * * * _ _ _|");
        }
        else if (12 <= _level)
        {
            Console.Write("|* * * * * * _ _ _ _|");
        }
        else if (10 <= _level)
        {
            Console.Write("|* * * * * _ _ _ _ _|");
        }
        else if (8 <= _level)
        {
            Console.Write("|* * * * _ _ _ _ _ _|");
        }
        else if (6 <= _level)
        {
            Console.Write("|* * * _ _ _ _ _ _ _|");
        }
        else if (4 <= _level)
        {
            Console.Write("|* * _ _ _ _ _ _ _ _|");
        }
        else if (2 <= _level)
        {
            Console.Write("|* _ _ _ _ _ _ _ _ _|");
        }
        else if (0 <= _level)
        {
            Console.Write("|_ _ _ _ _ _ _ _ _ _|");
        }
    }
}