using Ex_ample.Data.Entities;

namespace Ex_ample.Interfaces.Respository
{
    public interface IElifeSaverManagementRespository
    {
      ElifeSaverManagement CreateManagement(ElifeSaverManagement eLIFESAVERMANAGEMENT);
      ElifeSaverManagement UpdateManagement(ElifeSaverManagement eLIFESAVERMANAGEMENT);
    
    }
}