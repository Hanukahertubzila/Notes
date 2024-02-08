namespace Notes.Domain
{
    public class Keeper : IFolder
    {
        public Keeper(IServices services)
        {
            Services = services;
            Path = services.Settings.RootPath;
            Name = "Notes";
            Id = 1;
            LoadContent();
        }

        public Folder RootFolder { get; private set; }
        public IServices Services { get; private set; }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Path { get; private set; }

        private void LoadContent()
        {
            RootFolder = new Folder(Name, this);
            LoadFolder(RootFolder);
        }

        private void LoadFolder(Folder folder)
        {
            folder.LoadInnerFolders(Services.Loader.LoadFolders(folder));
            folder.LoadInnerNotes(Services.Loader.LoadNotes(folder));
            foreach (var f in folder.GetFolders())
                LoadFolder(f);
        }
    }
}
