public class GameDataManager
{
    private const string USER_DATA_PATH = "GameProgress/UserData.json";

    public struct DataItem
    {
        public List<Data> datas { get; set; }

        public struct Data
        {
            public string level { get; set; }
            public int score { get; set; }
        }
    }

    public static void SaveGame(Level currentLevel)
    {
        DataItem dataItem = FileHandler.ReadFromJson<DataItem>(USER_DATA_PATH);

        DataItem.Data data = new DataItem.Data();
        data.level = currentLevel.GetLevelName();
        data.score = currentLevel.GetScore();
        dataItem.datas.Add(data);

        FileHandler.WriteToJson<DataItem>(USER_DATA_PATH, dataItem);
    }
}