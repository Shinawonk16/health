using Ex_ample.Data.Context;
using Ex_ample.Data.Entities;
using Ex_ample.Interfaces.Respository;

namespace Ex_ample.Implementation.Repository
{
    public class NurseRespository : INurseRespository
    {
        private readonly ContextClass _contextClass;
        public NurseRespository()
        {
            _contextClass = new ContextClass();
        }

        public Nurses CreateNurse(Nurses nurses)
        {
            _contextClass.Nurses.Add(nurses);
            _contextClass.SaveChanges();
            return nurses;
        }

        public void DeleteNurse(string nurseId)
        {
            var nurse = _contextClass.Nurses.Where(x => x.NurseId == nurseId).SingleOrDefault();
            _contextClass.Nurses.Remove(nurse);
            _contextClass.SaveChanges();
        }
        public Nurses UpdateNurse(Nurses nurses)
        {
            _contextClass.Nurses.Update(nurses);
            _contextClass.SaveChanges();
            return nurses;
        }

         public List<Nurses> GetAllNurse()
        {
            return _contextClass.Nurses.ToList();
        }

        public Nurses GetNurse(string nurseId)
        {
            return _contextClass.Nurses.Where(x => x.NurseId == nurseId).SingleOrDefault();
            
        }

        public Nurses Login(string email, string passWord)
        {
            return _contextClass.Nurses.Where(x =>x.User.Email == email && x.User.PassWord == passWord).SingleOrDefault();
        }
    }
}