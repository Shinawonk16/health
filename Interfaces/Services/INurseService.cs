using Ex_ample.Data.Entities;
using Ex_ample.Dto.RequestModel;
using Ex_ample.Dto.ResponseModel;

namespace Ex_ample.Interfaces.Services
{
    public interface INurseService
    {
        BaseResponse AddNurse(CreateNurseRequestModel createNurseRequest);
        BaseResponse EditNurse(UpdateNurseRequestModel updateNurseRequest,string nurseId);
        NurseResponseModel ViewNurse(string nurseId);
        Nurses Login(string email, string passWord);
        NursesResponseModel ViewAllNurse();
        BaseResponse DeleteNurse(string nurseId);
        public Nurses ApproveNurse(string nurseId);

    }
}