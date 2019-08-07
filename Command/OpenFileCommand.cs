namespace CommandPattern
{
    public class OpenFileCommand : ICommand
    {
        public string Path { get; set; }
        private IFile _file;

        public OpenFileCommand(IFile file)
        {
            this._file = file;
        }

        public void Execute()
        {
            this._file.Open(Path);
        }
    }
}
