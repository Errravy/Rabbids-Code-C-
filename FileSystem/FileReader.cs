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
}