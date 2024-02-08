namespace Notes.Domain
{
    public class Services : IServices
    {
        public Services(string configPath, Settings settings, ILoader loader, ISaver saver)
        {
            ConfigPath = configPath;
            Settings = settings;
            Saver = saver;
            Loader = loader;
        }

        public Settings Settings { get; private set; }
        public ISaver Saver { get; private set; }
        public ILoader Loader { get; private set; }
        public string ConfigPath {  get; private set; }
    }
}
