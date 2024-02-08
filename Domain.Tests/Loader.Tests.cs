using FakeItEasy;
using Newtonsoft.Json;
using Notes.Domain;

namespace Domain.Tests
{
    public class LoaderTests
    {
        private IServices _services;

        [SetUp]
        public void Setup()
        {
            _services = new Services("", new Settings("D:\\Notes\\Notes\\Domain.Tests\\TestData\\"), new Loader(), A.Fake<ISaver>());
            Directory.CreateDirectory(Path.Combine(_services.Settings.RootPath, "Root"));
        }

        [TearDown]
        public void TearDown()
        {
            Directory.Delete(_services.Settings.RootPath, true);
        }

        [Test]
        public void NoFoldersExceptRoot()
        {
            var keeper = new Keeper(_services);
            Assert.That(keeper.RootFolder.GetFolders().Count(), Is.EqualTo(0));
            Assert.That(keeper.RootFolder.GetNotes().Count(), Is.EqualTo(0));
        }

        [Test]
        public void CanLoadInnerFolder()
        {
            CreateInnerFolder(Path.Combine(_services.Settings.RootPath, "Root"), "nice folder");
            var keeper = new Keeper(_services);
            Assert.That(keeper.RootFolder.GetFolders().Count(), Is.EqualTo(1));
            Assert.That(keeper.RootFolder.GetFolders().First().Name, Is.EqualTo("nice folder"));
        }

        [Test]
        public void CanLoadNote()
        {
            CreateNote(Path.Combine(_services.Settings.RootPath, "Root"), "nice note");
            var keeper = new Keeper(_services);
            Assert.That(keeper.RootFolder.GetNotes().Count(), Is.EqualTo(1));
            Assert.That(keeper.RootFolder.GetNotes().First().Name, Is.EqualTo("nice note"));
        }

        private void CreateNote(string path, string name)
        {
            var keeper = new Keeper(_services);
            var notePath = Path.Combine(path, "Note1.note");
            var note = new Note(name, keeper.RootFolder);
            File.WriteAllText(notePath, JsonConvert.SerializeObject(note));
        }

        private void CreateInnerFolder(string path, string name)
        {
            var innerFolderPath = Path.Combine(path, "NotesFolder11");
            Directory.CreateDirectory(innerFolderPath);
            File.WriteAllText(Path.Combine(innerFolderPath, "info.txt"), name);
        }
    }
}
