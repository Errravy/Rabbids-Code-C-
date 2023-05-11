public class Grid
{
    //Todo: delete temp
    int temp = 0;
    private int widht;
    private int height;
    private string[,] grid;
    private Dictionary<(int x, int y), Cell> cells;

    public Grid(int widht, int height)
    {
        this.widht = widht;
        this.height = height;
        grid = new string[widht, height];
        cells = new Dictionary<(int x, int y), Cell>();
        GenerateGrid();
        RenderGrid();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < widht; x++)
        {
            for (int y = 0; y < height; y++)
            {
                temp++;
                grid[x, y] = temp.ToString();
                // Console.WriteLine(grid[x, y] + " ");
                cells.Add((x, y), new Cell(x, y));
            }
        }
    }

    private void RenderGrid()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < widht; x++)
            {
                Console.Write(grid[x, y] + " ");
            }
            Console.WriteLine();
        }
    }

    public void CheckCell(IObjects obj)
    {
        if (obj.GetPosition().x < widht && obj.GetPosition().y < height)
        {
            cells[obj.GetPosition()].CheckObject(obj);
        }
        else
        {
            Console.WriteLine("Object is out of grid!");
        }
    }

    public void CheckGridPos(int x, int y)
    {
        Console.WriteLine(grid[x, y]);
    }
}