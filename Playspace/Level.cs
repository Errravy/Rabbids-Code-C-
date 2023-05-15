public class Level
{
    private string levelName;
    private Grid grid;
    private Invoker invoker;
    private IControlable controlable;
    private int score;

    private bool isCompleted = false;

    public Level(string levelName, int width, int height, Invoker invoker)
    {
        grid = new Grid(width, height);
        this.levelName = levelName;
        this.invoker = invoker;
    }

    public Grid GetGrid()
    {
        return grid;
    }

    public string GetLevelName()
    {
        return levelName;
    }

    public Invoker GetInvoker()
    {
        return invoker;
    }

    public int GetScore()
    {
        return score;
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