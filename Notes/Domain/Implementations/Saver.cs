using System.IO;
using Newtonsoft.Json;

namespace Notes.Domain
{
    public class Saver : ISaver
    {
        public void DeleteDirectory(Folder folder)
        {
            Directory.Delete(folder.Path, true);
        }

        public void DeleteNote(Note note)
        {
            File.Delete(note.Path);
        }

        public void SaveOrUpdateDirectory(Folder folder)
        {
            if (!Directory.Exists(folder.Path))
                Directory.CreateDirectory(folder.Path);
            CreateOrUpdateDirectoryInfoFile(folder);
        }

        public void SaveOrUpdateNote(Note note)
        {
            var serializedNote = JsonConvert.SerializeObject(note);
            if (File.Exists(note.Path))
                File.Delete(note.Path);
            File.WriteAllText(note.Path, serializedNote);
        }

        public void SaveSettings(IServices services)
        {
            var config = Path.Combine(services.ConfigPath, "config.json");
            if (!Directory.Exists(services.ConfigPath))
                Directory.CreateDirectory(services.ConfigPath);
            if (File.Exists(config))
                File.Delete(config);
            var settings = JsonConvert.SerializeObject(services.Settings);
            File.WriteAllText(config, settings);
        }

        private void CreateOrUpdateDirectoryInfoFile(Folder folder)
        {
            var path = Path.Combine(folder.Path, "info.txt");
            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, folder.Name);
            File.SetAttributes(path, FileAttributes.Hidden);
        }
    }
}
