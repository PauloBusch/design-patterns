namespace Command
{
    public interface IFile
    {
        void Open(string path);
        void Close();
    }
}
