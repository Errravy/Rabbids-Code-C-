public class Grid
{
    //Todo: delete temp
    int temp = 0;
    private int widht;
    private int height;
    private string[,] grid;
    private Dictionary<(int x, int y), Cell> cells;

    private Cell previousCell;
    private IObjects previousObject;

    public Grid(int widht, int height)
    {
        InitializeGridAndCell(widht, height);
        GenerateGrid();
    }

    private void InitializeGridAndCell(int widht, int height)
    {
        this.widht = widht;
        this.height = height;
        grid = new string[widht, height];
        cells = new Dictionary<(int x, int y), Cell>();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < widht; x++)
        {
            for (int y = 0; y < height; y++)
            {
                temp++;
                grid[x, y] = temp.ToString();
                cells.Add((x, y), new Cell(x, y));
            }
        }
    }

    public void CheckCell(IObjects obj)
    {
        if (previousCell == null)
        {
            previousCell = cells[obj.GetPosition()];
            previousObject = obj;
        }
        else
        {
            previousCell.CheckObject(previousObject);
            previousCell = cells[obj.GetPosition()];
            previousObject = obj;
        }

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

    public int GetWidth()
    {
        return widht;
    }

    public int GetHeight()
    {
        return height;
    }

    public Dictionary<(int x, int y), Cell> GetCells()
    {
        return cells;
    }
}