using Ex_ample.Data.Entities;

namespace Ex_ample.Interfaces.Respository
{
    public interface IDoctorRespository
    {
        Doctors CreateDoctor(Doctors doctors);
        Doctors UpdateDoctor (Doctors doctors);
        Doctors Login(string email,string passWord);
        Doctors GetDoctor(string doctorId);
        List<Doctors> GetAllDoctor();
        void DeleteDoctor(Doctors doctors);
    }
}
