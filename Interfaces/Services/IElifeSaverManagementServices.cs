using Ex_ample.Data.Entities;
using Ex_ample.Dto.RequestModel;

namespace Ex_ample.Interfaces.Services
{
    public interface IElifeSaveManagementServices
    {
      ElifeSaverManagement AddManagement(CreateELIFESAVERMANAGEMENTRequestModel model);
      ElifeSaverManagement UpdateManagement(ElifeSaverManagement elifeSaverManagement);
    
    }
}
