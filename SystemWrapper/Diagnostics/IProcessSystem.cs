using SystemWrapper.Diagnostics;

namespace ThomsonReuters.CommonOffice.Presentation.Views.Services
{
    public interface IProcessSystem
    {
        IProcessWrap Start(string fileName);
    }
}