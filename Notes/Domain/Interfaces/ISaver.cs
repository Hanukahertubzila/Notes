using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain
{
    public interface ISaver
    {
        void DeleteDirectory(Folder folder);

        void DeleteNote(Note note);

        void SaveOrUpdateDirectory(Folder folder);

        void SaveOrUpdateNote(Note note);

        void SaveSettings(IServices services);
    }
}
