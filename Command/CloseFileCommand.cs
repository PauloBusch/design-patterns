namespace CommandPattern
{
    public class CloseFileCommand : ICommand
    {
        private IFile _file;
        public CloseFileCommand(IFile file)
        {
            this._file = file;
        }

        public void Execute()
        {
            this._file.Close();
        }
    }
}
