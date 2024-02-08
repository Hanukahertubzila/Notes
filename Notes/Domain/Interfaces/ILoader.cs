using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain
{
    public interface ILoader
    {
        IEnumerable<Folder> LoadFolders(Folder folder);

        IEnumerable<Note> LoadNotes(Folder folder);

        Settings LoadSettings(string configPath, string dataPath);
    }
}
