using System.Drawing;

namespace Notes.Domain
{
    public interface IContent
    {
        string Name { get; }
        int Id { get; }
        void Delete();
        Image Image { get; }
        Image DefaultImage { get; }
        Image SelectedImage { get; }
        void ResetImages();
        void SetDefaultImage();
        void SetSelectedImage();
    }
}
