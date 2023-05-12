public class Program
{
    public static void Main(string[] args)
    {
        Grid grid = new Grid(10, 3);
        IObjects bag = new Bag();
        bag.SetPosition(4, 0);
        grid.CheckGridPos(4, 0);
        grid.CheckCell(bag);
        grid.RenderGrid();
    }
}
