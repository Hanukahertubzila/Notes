namespace Notes.Domain
{
    public interface IFolder
    { 
        int Id {  get; }
        string Name { get; }
        string Path { get; }
        IServices Services { get; }
    }
}
