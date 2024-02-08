using Newtonsoft.Json;
using System.Drawing;
using System.Linq;

namespace Notes.Domain
{
    public class Note : IContent
    {
        public Note(string name, Folder parent)
        {
            Name = name;
            Text = "";
            Id = parent.Id * 10 + parent.GetNotes().Count() + 1;
            ParentFolder = parent;
            Services = parent.Services;
            Path = System.IO.Path.Combine(parent.Path, "Note" + Id + ".note");
            Image = Image.FromFile(System.IO.Path.Combine("D:\\Notes\\Notes\\Notes\\View\\Images\\", "Note.png"));
            DefaultImage = new Bitmap(Image);
            SelectedImage = new Bitmap(Image);
            ResetImages();
        }

        [JsonIgnore]
        public int Id { get; private set; }
        [JsonProperty("Name")]
        public string Name { get; private set; }
        [JsonProperty("Text")]
        public string Text { get; private set; }
        [JsonIgnore]
        public string Path { get; private set; }
        [JsonIgnore]
        public Folder ParentFolder { get; private set; }
        [JsonIgnore]
        public IServices Services { get; private set; }
        [JsonIgnore]
        public Image Image { get; private set; }
        [JsonIgnore]
        public Image DefaultImage { get; private set; }
        [JsonIgnore]
        public Image SelectedImage { get; private set; }

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

        public void Rename(string name, bool save = true)
        {
            Name = name.Trim();
            if (save)
                Services.Saver.SaveOrUpdateNote(this);
        }

        public void EditText(string text, bool save = true)
        {
            Text = text.Trim();
            if (save)
                Services.Saver.SaveOrUpdateNote(this);
        }

        public void Delete()
        {
            ParentFolder.DeleteNote(Id);
        }

        public void Save()
        {
            Services.Saver.SaveOrUpdateNote(this);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Note)) return false;
            return Id == ((Note)obj).Id;
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
