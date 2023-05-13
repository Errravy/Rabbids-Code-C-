using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

public class FileReader
{
    private static string levelFolder = "Levels";

    public static string relativePath = $"{Environment.CurrentDirectory}/{levelFolder}";

    public static FileInfo[] GetAllLevelFiles()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(relativePath);
        FileInfo[] fileInfos = directoryInfo.GetFiles();

        return fileInfos;
    }

    public static T Read<T>(string fileName)
    {
        string text = File.ReadAllText($"{relativePath}/{fileName}");
        return JsonSerializer.Deserialize<T>(text);
    }
}