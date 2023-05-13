public class GameManager
{
    public static GameManager Instance { get; private set; }
    private GameState gameState;

    private Level currentLevel;

    public GameManager()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        gameState = GameState.NotStarted;
        currentLevel = new LevelManager().GetLevel();
    }

    public void StartGame()
    {
        gameState = GameState.Playing;

        while (gameState == GameState.Playing)
        {
            DisplayManager.RenderLevel(currentLevel);
            currentLevel.ShowAvailableMoves();
            var move = InputManager.GetMove();

            if (move == 1)
            {
                currentLevel.GetControlable().SetPosition(currentLevel.GetControlable().GetPosition().x, currentLevel.GetControlable().GetPosition().y - 1);
            }
            else if (move == 2)
            {
                currentLevel.GetControlable().SetPosition(currentLevel.GetControlable().GetPosition().x, currentLevel.GetControlable().GetPosition().y + 1);
            }

            if (currentLevel.IsCompleted())
            {
                EndGame();
            }
        }
    }

    public void EndGame()
    {
        gameState = GameState.NotStarted;
    }

    public void LoadLevel(Level level)
    {
        currentLevel = level;
    }
}
