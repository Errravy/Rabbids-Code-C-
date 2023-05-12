public class InputManager
{
    public static ICommand GetMove()
    {
        var key = Console.ReadKey().Key;

        switch (key)
        {
            case ConsoleKey.NumPad1:
                return null;
            case ConsoleKey.NumPad2:
                return null;
            case ConsoleKey.NumPad3:
                return null;
            case ConsoleKey.NumPad4:
                return null;
            case ConsoleKey.NumPad5:
                return null;
            case ConsoleKey.NumPad6:
                return null;
            case ConsoleKey.NumPad7:
                return null;
            case ConsoleKey.NumPad8:
                return null;
            case ConsoleKey.NumPad9:
                return null;
            default:
                return null;
        }
    }
}