using System.Text.Json;
using System.IO;

public class SaveLoad{
    string path;

    public SaveLoad()
    {
        // Parse the file data up to bin
        string directory = AppContext.BaseDirectory;
        string[] splits = directory.Split($"bin");
        path = splits[0] + "journalSave.json";
    }
    public void Save(Journal journal)
    {
        var fileText = JsonSerializer.Serialize(journal);
        File.WriteAllText(path, fileText);
    }

    public Journal Load()
    {
        var fileText = File.ReadAllText(path);
        return JsonSerializer.Deserialize<Journal>(fileText);
    }
}