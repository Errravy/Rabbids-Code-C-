public class LevelManager
{
    private List<Level> levelList = new List<Level>();
    private int currentLevelIndex = 0;

    public LevelManager()
    {
        SetupLevels();
    }

    public Level GetLevel()
    {
        if (levelList.Count <= 0)
        {
            return new Level("Default");
        }

        return levelList[currentLevelIndex];
    }

    public void SetupLevels()
    {
        FileInfo[] fileInfos = FileReader.GetAllLevelFiles();

        foreach (FileInfo fileInfo in fileInfos)
        {
            CreateLevel(fileInfo.Name);
        }
    }

    private void CreateLevel(string levelName)
    {
        string line;

        try
        {
            StreamReader reader = new StreamReader($"{FileReader.relativePath}/{levelName}");

            line = reader.ReadLine();
            Level newLevel = new Level(levelName);

            while (line != null)
            {
                string[] splittedLines = line.Split(" ");

                foreach (string splittedLine in splittedLines)
                {
                    string objectName = splittedLine.Split("-")[0];
                    string objectPosition = splittedLine.Split("-")[1];


                }

                line = reader.ReadLine();
            }

            reader.Close();
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
}