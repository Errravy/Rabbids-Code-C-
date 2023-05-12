using System.IO;

public class DisplayManager
{
    #region RenderColors
    private static ConsoleColor redColor = ConsoleColor.Red;
    private static ConsoleColor greenColor = ConsoleColor.Green;
    private static ConsoleColor defaultColor = Console.BackgroundColor;
    #endregion

    #region ReaderRules
    private static string gridDivider = "-";
    private static string blankCell = "*";
    #endregion

    public static void RenderLevel(Level level)
    {
        Console.Clear();


    }
}