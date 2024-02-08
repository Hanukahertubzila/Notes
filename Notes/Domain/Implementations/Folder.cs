using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Notes.Domain
{
    public class Folder : IContent, IFolder
    {
        public Folder(string name, IFolder parent)
        {
            Id = parent is Folder ? (parent as Folder).ParentFolder.Id * 10 
                + (parent as Folder)._folders.Count + 1 : 1;
            Name = name;
            Path = System.IO.Path.Combine(parent.Path, parent is Folder ? "NotesFolder" + Id : "Root");
            ParentFolder = parent;
            Services = parent.Services;
            _folders = new List<Folder>();
            _notes = new List<Note>();
            Image = Image.FromFile(System.IO.Path.Combine("D:\\Notes\\Notes\\Notes\\View\\Images\\", "Folder.png"));
            DefaultImage = new Bitmap(Image);
            SelectedImage = new Bitmap(Image);
            ResetImages();
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Path { get; private set; }
        public IFolder ParentFolder { get; private set; }
        public IServices Services { get; private set; }
        public Image Image { get; private set; }
        public Image DefaultImage { get; private set; }
        public Image SelectedImage { get; private set; }

        private List<Folder> _folders;
        private List<Note> _notes;

        public void ResetImages()
        {
            DefaultImage = ChangeImageColor(DefaultImage, Color.FromArgb(Services.Settings.BackColor));
            SelectedImage = ChangeImageColor(DefaultImage, Color.FromArgb(Services.Settings.AlternativeColor));
            Image = DefaultImage;
        }

        public void SetDefaultImage()
        {
            Image = DefaultImage;
        }

        public void SetSelectedImage()
        {
            Image = SelectedImage; 
        }

        public Folder GetFolder(int id)
        {
            foreach (var f in _folders)
                if (f.Id == id)
                    return f;
            return null;
        }

        public IEnumerable<Folder> GetFolders()
        {
            for (int i = _folders.Count - 1; i >= 0; i--)
                yield return _folders[i];
        }

        public IEnumerable<Note> GetNotes()
        {
            for (int i = _notes.Count - 1; i >= 0; i--)
                yield return _notes[i];
        }

        public IEnumerable<IContent> GetContent()
        {
            for (int i = _folders.Count - 1; i >= 0; i--)
                yield return _folders[i];
            for (int i = _notes.Count - 1; i >= 0; i--)
                yield return _notes[i];
        }

        public void Rename(string name)
        {
            Name = name;
            Services.Saver.SaveOrUpdateDirectory(this);
        }

        public void SaveOrUpdate()
        {
            Services.Saver.SaveOrUpdateDirectory(this);
        }

        public void AddFolder(string name)
        {
            var folder = new Folder(name, this);
            Services.Saver.SaveOrUpdateDirectory(folder);
            _folders.Add(folder);
        }

        public Note AddNote(string name)
        {
            var note = new Note(name, this);   
            Services.Saver.SaveOrUpdateNote(note);
            _notes.Add(note);
            return note;
        }

        public void DeleteInnerFolder(int id)
        {
            var folder = _folders.Where(z => z.Id == id).FirstOrDefault();
            if (folder == null) return;
            Services.Saver.DeleteDirectory(folder);
            _folders.Remove(folder);
        }

        public void Delete()
        {
            if (ParentFolder is Folder)
                (ParentFolder as Folder).DeleteInnerFolder(Id);
        }

        public void DeleteNote(int id)
        {
            var note = _notes.Where(z => z.Id == id).FirstOrDefault();
            if (note == null) return;
            Services.Saver.DeleteNote(note);
            _notes.Remove(note);
        }

        public void LoadInnerFolders(IEnumerable<Folder> folders)
        {
            foreach (var folder in folders)
                _folders.Add(folder);
        }

        public void LoadInnerNotes(IEnumerable<Note> notes)
        {
            foreach (var note in notes)
                _notes.Add(note);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Folder)) return false;
            return Id == ((Folder)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id * 1256 ^ Name.GetHashCode();
        }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name;
        }

        private Image ChangeImageColor(Image img, Color newColor)
        {
            var recolored = new Bitmap(img);
            var controlColor = recolored.GetPixel(0, 0).ToString();
            for (int y = 0; y < recolored.Height; y++)
            {
                for (int x = 0; x < recolored.Width; x++)
                {
                    if (recolored.GetPixel(x, y).ToString() != controlColor)
                        recolored.SetPixel(x, y, newColor);
                }
            }
            return recolored;
        }
    }
}
