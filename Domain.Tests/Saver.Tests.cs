using FakeItEasy;
using Notes.Domain;

namespace Domain.Tests
{
    public class SaverTests
    {
        private Keeper _keeper;
        private IServices _services;

        [SetUp]
        public void Setup()
        {
            _services = new Services("", new Settings(@"D:\Notes\Notes\Domain.Tests\TestData\"), A.Fake<ILoader>(), new Saver());
            Directory.CreateDirectory(Path.Combine(_services.Settings.RootPath, "Root"));
            _keeper = new Keeper(_services);
        }

        [TearDown]
        public void TearDown()
        {
            Directory.Delete(_keeper.RootFolder.Path, true);
        }

        [Test]
        public void CanCreateFolderOnDisk()
        {
            var folder = CreateFolder();
            Assert.That(Directory.Exists(folder.Path), Is.True);
        }

        [Test]
        public void CanDeleteFolderOnDisk()
        {
            var folder = CreateFolder();
            Assert.That(Directory.Exists(folder.Path), Is.True);
            _services.Saver.DeleteDirectory(folder);
            Assert.That(Directory.Exists(folder.Path), Is.False);
        }

        [Test]
        public void FolderHasInfoFile()
        {
            var folder = new Folder("Test1", _keeper.RootFolder);
            _services.Saver.SaveOrUpdateDirectory(folder);
            Assert.That(Directory.Exists(folder.Path), Is.True);
            Assert.That(File.Exists(Path.Combine(folder.Path, "info.txt")), Is.True);
        }

        [Test]
        public void InfoFileUpdatesOnFolderRename()
        {
            var folder = CreateFolder();
            var info = File.ReadAllText(Path.Combine(folder.Path, "info.txt"));
            Assert.That(info, Is.EqualTo("Test1"));
            folder.Rename("NiceFolder");
            info = File.ReadAllText(Path.Combine(folder.Path, "info.txt"));
            Assert.That(info, Is.EqualTo("NiceFolder"));
        }

        [Test]
        public void CanCreateNoteOnDisk()
        {
            var note = CreateNote();
            Assert.That(File.Exists(note.Path), Is.True);
        }

        [Test]
        public void CanDeleteNoteOnDisk()
        {
            var note = CreateNote();
            Assert.That(File.Exists(note.Path), Is.True);
            _services.Saver.DeleteNote(note);
            Assert.That(File.Exists(note.Path), Is.False);
        }

        [Test]
        public void NotesUpdatesOnRename()
        {
            var note = CreateNote();
            var info = File.ReadAllText(note.Path);
            note.Rename("NiceNote");
            var edittedInfo = File.ReadAllText(note.Path);
            Assert.That(info !=  edittedInfo, Is.True);
        }

        [Test]
        public void NotesUpdatesOnTextEdit()
        {
            var note = CreateNote();
            var info = File.ReadAllText(note.Path);
            note.EditText("TextTextText");
            var edittedInfo = File.ReadAllText(note.Path);
            Assert.That(info != edittedInfo, Is.True);
        }

        private Folder CreateFolder()
        {
            var folder = new Folder("Test1", _keeper.RootFolder);
            _services.Saver.SaveOrUpdateDirectory(folder);
            return folder;
        }

        private Note CreateNote()
        {
            var note = new Note("TestNote1", _keeper.RootFolder);
            _services.Saver.SaveOrUpdateNote(note);
            return note;
        }
    }
}
