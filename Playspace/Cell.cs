public class Cell
{
    private int x;
    private int y;
    private IObjects obj;
    private string cellObj;

    private bool isWalkable = true;
    private const string walkable = "-";
    private const string blank = " ";

    public Cell(int x, int y)
    {
        this.x = x;
        this.y = y;
        obj = null;
        cellObj = walkable;
    }

    public void CheckObject(IObjects obj)
    {
        if (obj.GetPosition().x == x && obj.GetPosition().y == y)
        {
            isWalkable = false;
            System.Console.WriteLine($"Cell {x} {y} is not walkable because {obj} inside it!");
            this.obj = obj;
            cellObj = obj.GetObjectSymbol();
        }
        else
        {
            isWalkable = true;
            this.obj = null;
            cellObj = walkable;
        }
    }

    public void SetToBlankCell()
    {
        isWalkable = false;
        cellObj = blank;
    }

    public string GetCellObj()
    {
        return cellObj;
    }

    public IObjects GetObject()
    {
        return obj;
    }

    public bool IsWalkable()
    {
        return isWalkable;
    }

    public bool IsBlocked()
    {
        return cellObj == blank;
    }
}