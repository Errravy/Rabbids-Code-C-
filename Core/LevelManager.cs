public class LevelManager
{
    private List<Level> levelList = new List<Level>();
    private int currentLevelIndex = 0;

    public struct LevelItem
    {
        public List<string> commands { get; set; }
        public List<Object> objects { get; set; }

        public struct Object
        {
            public string objectType { get; set; }
            public string objectEnum { get; set; }
            public Position position { get; set; }

            public struct Position
            {
                public int x { get; set; }
                public int y { get; set; }
            }
        }
    }

    public LevelManager()
    {
        SetupLevels();
    }

    public Level GetLevel()
    {
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
        Level newLevel = new Level();

        LevelItem levelItem = FileReader.Read<LevelItem>(levelName);

        foreach (LevelItem.Object objectItem in levelItem.objects)
        {
            bool isControlable = false;
            IObjects newObject = CreateNewObject(objectItem, out isControlable);

            if (isControlable)
            {
                foreach (string command in levelItem.commands)
                {
                    ICommand iCommand = CreateNewCommand((IControlable)newObject, command);
                    ((IControlable)newObject).SetCommand(iCommand);
                }

                newLevel.SetControlable((IControlable)newObject);
            }

            newLevel.GetGrid().CheckCell(newObject);
        }

        levelList.Add(newLevel);
    }

    private IObjects CreateNewObject(LevelItem.Object iObject, out bool isControlable)
    {
        IObjects newObject = Factory.CreateObject((Objects)Enum.Parse(typeof(Objects), ((LevelItem.Object)iObject).objectType));
        SetObjectPosition(newObject, ((LevelItem.Object)iObject).position);

        if (((LevelItem.Object)iObject).objectEnum == "Controlable")
        {
            isControlable = true;
        }
        else
        {
            isControlable = false;
        }

        return newObject;
    }

    private ICommand CreateNewCommand(IControlable controlable, string command)
    {
        ICommand newCommand = Factory.CreateCommands(controlable, (Commands)Enum.Parse(typeof(Commands), command));
        return newCommand;
    }

    private void SetObjectPosition(IObjects iObject, LevelItem.Object.Position position)
    {
        iObject.SetPosition(position.x, position.y);
    }

    public void NextLevel()
    {
        currentLevelIndex++;
    }
}