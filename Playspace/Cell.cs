public class Cell
{
    private int x;
    private int y;
    private string cellObj;

    // private bool isWalkable;
    public Cell(int x, int y)
    {
        this.x = x;
        this.y = y;
        cellObj = "0";
    }

    public void CheckObject(IObjects obj)
    {
        if (obj.GetPosition().x == x && obj.GetPosition().y == y)
        {
            // isWalkable = false;
            System.Console.WriteLine($"Cell {x} {y} is not walkable because {obj} inside it!");
            cellObj = "X";

        }
        else
        {
            // isWalkable = true;
        }
    }

    public string GetCellObj()
    {
        return cellObj;
    }
}