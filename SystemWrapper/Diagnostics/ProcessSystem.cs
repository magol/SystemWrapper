using System.Diagnostics;
using SystemWrapper.Diagnostics;

namespace ThomsonReuters.CommonOffice.Presentation.Views.Services
{
    public class ProcessSystem : IProcessSystem
    {
        public IProcessWrap Start(string fileName)
        {
            return new ProcessWrap(Process.Start(fileName));
        }
    }
}