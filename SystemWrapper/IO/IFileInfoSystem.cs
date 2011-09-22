namespace SystemWrapper.IO
{
    public interface IFileInfoSystem
    {
        IFileInfoWrap GetFileInfo(string fileName);
    }
}