public class Level
{
    private Grid grid;
    private Invoker invoker;
    private IControlable controlable;

    private bool isCompleted = false;

    public Level(Invoker invoker)
    {
        grid = new Grid(10, 10);
        this.invoker = invoker;
    }

    public Grid GetGrid()
    {
        return grid;
    }

    public Invoker GetInvoker()
    {
        return invoker;
    }

    public void ShowAvailableMoves()
    {
        // Show available moves
    }

    public bool IsCompleted()
    {
        return isCompleted;
    }

    public void SetControlable(IControlable controlable)
    {
        this.controlable = controlable;
    }

    public IControlable GetControlable()
    {
        return controlable;
    }
}