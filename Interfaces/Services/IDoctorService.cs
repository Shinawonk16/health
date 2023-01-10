using Ex_ample.Data.Entities;
using Ex_ample.Dto.RequestModel;
using Ex_ample.Dto.ResponseModel;

namespace Ex_ample.Interfaces.Services
{
    public interface IDoctorService
    {
        BaseResponse AddDoctor(CreateDoctorRequestModel model);
        BaseResponse DeleteDoctor(string doctorId);
        Doctors Login(string email,string passWord);
        BaseResponse EditDoctor(UpdateDoctorRequestModel requestModel, string doctorId);
        DoctorResponseModel ViewDoctor(string doctorId);
        DoctorsResponseModel ViewAllDoctors();
        public Doctors ApproveDoctor(string doctorId);
    }
}