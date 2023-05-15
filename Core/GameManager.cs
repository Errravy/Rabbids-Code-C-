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
            int move = InputManager.GetMove();

            if (move == 1)
            {
                currentLevel.GetInvoker().AddCommand(currentLevel.GetControlable().GetCommand(Commands.Left));
            }
            else if (move == 2)
            {
                currentLevel.GetInvoker().AddCommand(currentLevel.GetControlable().GetCommand(Commands.Right));
            }
            else if (move == 3)
            {
                currentLevel.GetInvoker().AddCommand(currentLevel.GetControlable().GetCommand(Commands.Forward));
            }
            else if (move == 4)
            {
                currentLevel.GetInvoker().AddCommand(currentLevel.GetControlable().GetCommand(Commands.Backward));
            }
            else if (move == 5)
            {
                currentLevel.GetInvoker().ExecuteCommands();
                GameDataManager.SaveGame(currentLevel);
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
