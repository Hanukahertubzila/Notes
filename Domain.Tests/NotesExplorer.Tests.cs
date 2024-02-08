using FakeItEasy;
using Notes.Domain;

namespace Domain.Tests
{
    public class DomainTests
    {
        private Keeper _keeper;

        [SetUp]
        public void Setup()
        {
            var loader = A.Fake<ILoader>();
            var saver = A.Fake<ISaver>();
            var services = new Services("", A.Fake<Settings>(),  loader, saver);
            _keeper = new Keeper(services);
        }

        [Test]
        public void KeeperHasDefaultFolder()
        {
            var folder = _keeper.RootFolder;
            Assert.NotNull(folder);
            Assert.That(folder.Name, Is.EqualTo("Notes"));
            Assert.That(folder.Id, Is.EqualTo(1));
            Assert.That(folder.GetFolders().Count(), Is.EqualTo(0));
            Assert.That(folder.GetNotes().Count(), Is.EqualTo(0));
        }

        [Test]
        public void CanRenameFolder()
        {
            AddFolders();
            
            var folder = _keeper.RootFolder.GetFolders().First();
            Assert.That(folder.Name, Is.EqualTo("Test3"));
            folder.Rename("NiceFolder");
            Assert.That(folder.Name, Is.EqualTo("NiceFolder"));
        }

        [Test]
        public void CanAddNewFolders()
        {
            Assert.That(_keeper.RootFolder.GetFolders().Count(), Is.EqualTo(0));
            AddFolders();
            Assert.That(_keeper.RootFolder.GetFolders().Count(), Is.EqualTo(3));
            Assert.That(_keeper.RootFolder.GetFolders().First().Id, Is.EqualTo(13));
        }

        [Test]
        public void CanDeleteInnerFolders()
        {
            AddFolders();
            Assert.That(_keeper.RootFolder.GetFolders().Count(), Is.EqualTo(3));
            _keeper.RootFolder.DeleteInnerFolder(11);
            Assert.That(_keeper.RootFolder.GetFolders().Count(), Is.EqualTo(2));
            Assert.That(_keeper.RootFolder.GetFolders().First().Id, Is.EqualTo(13));
        }

        [Test]
        public void CanDeleteFolder()
        {
            AddFolders();
            Assert.That(_keeper.RootFolder.GetFolders().Count(), Is.EqualTo(3));
            _keeper.RootFolder.GetFolders().First().Delete();
            Assert.That(_keeper.RootFolder.GetFolders().Count(), Is.EqualTo(2));
            Assert.That(_keeper.RootFolder.GetFolders().First().Id, Is.EqualTo(12));
        }

        [Test]
        public void CanAddNotes()
        {
            Assert.That(_keeper.RootFolder.GetNotes().Count(), Is.EqualTo(0));
            AddNotes();
            Assert.That(_keeper.RootFolder.GetNotes().Count(), Is.EqualTo(3));
            Assert.That(_keeper.RootFolder.GetNotes().First().Id, Is.EqualTo(13));
        }

        [Test]
        public void CanDeleteInnerNotes()
        {
            AddNotes();
            Assert.That(_keeper.RootFolder.GetNotes().Count(), Is.EqualTo(3));
            _keeper.RootFolder.DeleteNote(11);
            Assert.That(_keeper.RootFolder.GetNotes().Count(), Is.EqualTo(2));
            Assert.That(_keeper.RootFolder.GetNotes().First().Id, Is.EqualTo(13));
        }

        [Test]
        public void CanRenameNote()
        {
            AddNotes();
            var note = _keeper.RootFolder.GetNotes().First();
            Assert.That(note.Name, Is.EqualTo("TestNote3"));
            note.Rename("NiceNote");
            Assert.That(note.Name, Is.EqualTo("NiceNote"));
        }

        [Test]
        public void CanEditNoteText()
        {
            AddNotes();
            var note = _keeper.RootFolder.GetNotes().First();
            Assert.That(note.Text, Is.EqualTo(""));
            note.EditText("TextTextText");
            Assert.That(note.Text, Is.EqualTo("TextTextText"));
        }

        [Test]
        public void CanDeleteNote()
        {
            AddNotes();
            Assert.That(_keeper.RootFolder.GetNotes().Count(), Is.EqualTo(3));
            _keeper.RootFolder.GetNotes().First().Delete();
            Assert.That(_keeper.RootFolder.GetNotes().Count(), Is.EqualTo(2));
            Assert.That(_keeper.RootFolder.GetNotes().First().Id, Is.EqualTo(12));
        }

        private void AddFolders()
        {
            _keeper.RootFolder.AddFolder("Test1");
            _keeper.RootFolder.AddFolder("Test2");
            _keeper.RootFolder.AddFolder("Test3");
        }

        private void AddNotes()
        {
            _keeper.RootFolder.AddNote("TestNote1");
            _keeper.RootFolder.AddNote("TestNote2");
            _keeper.RootFolder.AddNote("TestNote3");
        }
    }
}