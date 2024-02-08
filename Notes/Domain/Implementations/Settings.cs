using System.Drawing;

namespace Notes.Domain
{
    public class Settings
    {
        public Settings(string path)
        {
            RootPath = path;
            BackColor = Color.Black.ToArgb();
            ForeColor = Color.White.ToArgb();
            AlternativeColor = Color.Red.ToArgb();
        }

        public string RootPath { get; set; }
        public int BackColor { get; set; }
        public int ForeColor { get; set; }
        public int AlternativeColor { get; set; }
    }
}
