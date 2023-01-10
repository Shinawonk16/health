using Ex_ample.Data.Entities;

namespace Ex_ample.Interfaces.Respository
{
    public interface INurseRespository
    {
       Nurses CreateNurse(Nurses nurses );
       Nurses UpdateNurse(Nurses nurses);
       Nurses Login(string email,string passWord);
       Nurses GetNurse(string nurseId);
       List<Nurses> GetAllNurse();
       void DeleteNurse(string nurseId);
    }
}