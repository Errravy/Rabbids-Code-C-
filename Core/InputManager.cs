public class InputManager
{
    public static int GetMove()
    {
        var key = Console.ReadKey().Key;

        switch (key)
        {
            case ConsoleKey.A:
                return 1;
            case ConsoleKey.D:
                return 2;
            case ConsoleKey.W:
                return 3;
            case ConsoleKey.S:
                return 4;
            case ConsoleKey.Spacebar:
                return 5;
            case ConsoleKey.NumPad6:
                return 6;
            case ConsoleKey.NumPad7:
                return 7;
            case ConsoleKey.NumPad8:
                return 8;
            case ConsoleKey.NumPad9:
                return 9;
            default:
                return 0;
        }
    }
}