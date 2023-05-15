using System.Text.Json;

public class FileHandler
{
    public static string relativePath = $"{Environment.CurrentDirectory}/Data";

    public static FileInfo[] GetAllLevelFiles(string folderName)
    {
        DirectoryInfo directoryInfo = new DirectoryInfo($"{relativePath}/{folderName}");
        FileInfo[] fileInfos = directoryInfo.GetFiles();

        return fileInfos;
    }

    public static T ReadFromJson<T>(string filePath)
    {
        string text = File.ReadAllText($"{relativePath}/{filePath}");
        return JsonSerializer.Deserialize<T>(text);
    }

    public static void WriteToJson<T>(string filePath, T data)
    {
        string text = JsonSerializer.Serialize(data);
        File.WriteAllText($"{relativePath}/{filePath}", text);
    }
}