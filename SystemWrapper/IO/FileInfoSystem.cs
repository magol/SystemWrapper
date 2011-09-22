

namespace SystemWrapper.IO
{
    public class FileInfoSystem: IFileInfoSystem
    {
        public IFileInfoWrap GetFileInfo(string fileName)
        {
            return  new FileInfoWrap(fileName);
        }
    }
}