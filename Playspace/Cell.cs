public class Cell
{
    private int x;
    private int y;

    // private bool isWalkable;
    public Cell(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void CheckObject(IObjects obj)
    {
        if (obj.GetPosition().x == x && obj.GetPosition().y == y)
        {
            // isWalkable = false;
            System.Console.WriteLine($"Cell {x} {y} is not walkable because {obj} inside it!");
        }
        else
        {
            // isWalkable = true;
        }
    }
}