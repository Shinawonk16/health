using Ex_ample.Data.Context;
using Ex_ample.Data.Entities;
using Ex_ample.Interfaces.Respository;

namespace Ex_ample.Implementation.Repository
{
    public class ElifeSaverManagementRespository : IElifeSaverManagementRespository
    {
        private readonly ContextClass _contextClass;
        public ElifeSaverManagementRespository()
        {
            _contextClass = new ContextClass();
        }
        public ElifeSaverManagement CreateManagement(ElifeSaverManagement eLIFESAVERMANAGEMENT)
        {
            _contextClass.ElifeSaverManagements.Add(eLIFESAVERMANAGEMENT);
            _contextClass.SaveChanges();
            return eLIFESAVERMANAGEMENT;
        }

        public ElifeSaverManagement UpdateManagement(ElifeSaverManagement eLIFESAVERMANAGEMENT)
        {
            _contextClass.ElifeSaverManagements.Update(eLIFESAVERMANAGEMENT);
            _contextClass.SaveChanges();
            return eLIFESAVERMANAGEMENT;


        }

    }
}