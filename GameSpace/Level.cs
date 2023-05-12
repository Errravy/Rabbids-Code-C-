public class Level
{
    private string levelName;

    private MoveForward moveForward;
    private bool isCompleted = false;

    public Level(string levelName)
    {
    }

    public void ShowAvailableMoves()
    {
        // Show available moves
    }

    public bool IsCompleted()
    {
        return isCompleted;
    }

    public string GetLevelName()
    {
        return levelName;
    }

    public void SetObjectToGrid()
    {

    }
}