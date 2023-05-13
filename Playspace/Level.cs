public class Level
{
    private Grid grid;
    private IControlable controlable;

    private bool isCompleted = false;

    public Level()
    {
        grid = new Grid(10, 10);
    }

    public Grid GetGrid()
    {
        return grid;
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