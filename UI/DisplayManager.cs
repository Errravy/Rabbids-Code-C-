using System.IO;

public class DisplayManager
{
    #region RenderColors
    private static ConsoleColor redColor = ConsoleColor.Red;
    private static ConsoleColor greenColor = ConsoleColor.Green;
    private static ConsoleColor blueColor = ConsoleColor.Blue;
    private static ConsoleColor defaultColor = Console.BackgroundColor;
    #endregion

    public static void RenderLevel(Level level)
    {
        // TODO: Create display direction
        // TODO: If 2 object at the same cell
        // TODO: Blank cell
        // TODO: Blocked cell
        // Console.Clear();

        Grid grid = level.GetGrid();

        grid.CheckCell(level.GetControlable());

        int x = 0;
        int y = 0;

        for (int i = 0; i < grid.GetHeight() * 4; i++)
        {
            if (i % 4 == 0)
            {
                for (int j = 0; j < grid.GetWidth(); j++)
                {
                    Console.Write("|");
                    Console.Write("=======");
                }
                Console.Write("|");
            }

            if (i % 4 == 1)
            {
                for (int j = 0; j < grid.GetWidth(); j++)
                {
                    Cell currentCell = grid.GetCells()[(x, y)];

                    Console.Write("|");

                    if (currentCell.IsWalkable())
                    {
                        Console.BackgroundColor = greenColor;
                        Console.Write("       ");
                        Console.BackgroundColor = defaultColor;
                    }
                    else
                    {
                        if (currentCell.IsBlocked())
                        {
                            Console.BackgroundColor = defaultColor;
                            Console.Write("       ");
                            Console.BackgroundColor = defaultColor;
                        }
                        else
                        {
                            Console.BackgroundColor = redColor;
                            Console.Write("       ");
                            Console.BackgroundColor = defaultColor;
                        }
                    }
                    x++;
                }
                Console.Write("|");
                x = 0;
            }

            if (i % 4 == 2)
            {
                for (int j = 0; j < grid.GetWidth(); j++)
                {
                    Cell currentCell = grid.GetCells()[(x, y)];

                    Console.Write("|");

                    if (currentCell.IsWalkable())
                    {
                        Console.BackgroundColor = greenColor;
                        Console.Write("   " + currentCell.GetCellObj() + "   ");
                        Console.BackgroundColor = defaultColor;
                    }
                    else
                    {
                        if (currentCell.IsBlocked())
                        {
                            Console.BackgroundColor = defaultColor;
                            Console.Write("       ");
                            Console.BackgroundColor = defaultColor;
                        }
                        else
                        {
                            Console.BackgroundColor = redColor;
                            Console.Write("   " + currentCell.GetCellObj() + "   ");
                            Console.BackgroundColor = defaultColor;
                        }
                    }
                    x++;
                }
                Console.Write("|");
                x = 0;
            }

            if (i % 4 == 3)
            {
                for (int j = 0; j < grid.GetWidth(); j++)
                {
                    Cell currentCell = grid.GetCells()[(x, y)];

                    Console.Write("|");

                    if (currentCell.IsWalkable())
                    {
                        Console.BackgroundColor = greenColor;
                        Console.Write("       ");
                        Console.BackgroundColor = defaultColor;
                    }
                    else
                    {
                        if (currentCell.IsBlocked())
                        {
                            Console.BackgroundColor = defaultColor;
                            Console.Write("       ");
                            Console.BackgroundColor = defaultColor;
                        }
                        else
                        {
                            Console.BackgroundColor = redColor;
                            Console.Write("       ");
                            Console.BackgroundColor = defaultColor;
                        }
                    }
                    x++;
                }
                Console.Write("|");
                x = 0;
                y++;
            }

            Console.WriteLine();
        }


        for (int j = 0; j < grid.GetWidth(); j++)
        {
            Console.Write("|");
            Console.Write("=======");
        }
        Console.Write("|");
        Console.WriteLine();

        grid.CheckCell(level.GetControlable());
    }
}