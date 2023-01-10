using Ex_ample.Data.Context;
using Ex_ample.Data.Entities;
using Ex_ample.Interfaces.Respository;

namespace Ex_ample.Implementation.Repository
{
    public class DoctorRespository : IDoctorRespository
    {
        private readonly ContextClass _contextClass;
        public DoctorRespository()
        {
            _contextClass = new ContextClass();
        }
        public Doctors CreateDoctor(Doctors doctors)
        {
            _contextClass.Doctors.Add(doctors);
            _contextClass.SaveChanges();
            return doctors;
        }

        public void DeleteDoctor(Doctors doctors)
        {
            _contextClass.Doctors.Remove(doctors);
            _contextClass.SaveChanges();
        }
        public Doctors UpdateDoctor(Doctors doctors)
        {
            _contextClass.Doctors.Update(doctors);
            _contextClass.SaveChanges();
            return doctors;
        }

        public Doctors GetDoctor(string doctorId)
        {
            return _contextClass.Doctors.Where(x => x.DoctorId == doctorId).SingleOrDefault();
        }

        public List<Doctors> GetAllDoctor()
        {
            return _contextClass.Doctors.ToList();
        }

        public Doctors Login(string email, string passWord)
        {
            return _contextClass.Doctors.Where(x => x.User.Email == email && x.User.PassWord == passWord).SingleOrDefault();
        }
    }
}