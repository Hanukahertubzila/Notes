using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Notes.Domain
{
    public class Loader : ILoader
    {
        public IEnumerable<Folder> LoadFolders(Folder folder)
        {
            if (folder.Id == 1 && !Directory.Exists(folder.Path))
                Directory.CreateDirectory(folder.Path);
            foreach (var directory in Directory.GetDirectories(folder.Path))
            {
                var infoFilePath = Path.Combine(directory, "info.txt");
                if (File.Exists(infoFilePath))
                {
                    var name = File.ReadAllText(infoFilePath);
                    var f = new Folder(name, folder);
                    if (!Directory.Exists(f.Path))
                        Directory.Move(directory, f.Path);
                    yield return f;
                }
            }
        }

        public IEnumerable<Note> LoadNotes(Folder folder)
        {
            foreach (var n in Directory.GetFiles(folder.Path).Where(z => z.EndsWith(".note")))
            {
                var json = JObject.Parse(File.ReadAllText(n));
                var name = "";
                if (json.ContainsKey("Name"))
                    name = (string)json["Name"];
                var note = new Note(name, folder);
                if (json.ContainsKey("Text"))
                    note.EditText((string)json["Text"], false);
                yield return note;
            }
        }

        public Settings LoadSettings(string configPath, string dataPath)
        {
            if (Directory.Exists(configPath) && File.Exists(Path.Combine(configPath, "config.json")))
            {
                var config = File.ReadAllText(Path.Combine(configPath, "config.json"));
                var json = JObject.Parse(config);
                var settings = new Settings(dataPath);
                settings.BackColor = (int)json["BackColor"];
                settings.ForeColor = (int)json["ForeColor"];
                settings.AlternativeColor = (int)json["AlternativeColor"];
                return settings;
            }
            else
            {
                return new Settings(dataPath);
            }
        }
    }
}
