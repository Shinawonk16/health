using Ex_ample.Data.Entities;
using Ex_ample.Dto;
using Ex_ample.Dto.RequestModel;
using Ex_ample.Dto.ResponseModel;
using Ex_ample.Interfaces.Respository;
using Ex_ample.Interfaces.Services;

namespace Ex_ample.Implementation.Services
{
    public class NurseService : INurseService
    {
        private readonly INurseRespository _nurseRespository;
        public NurseService(INurseRespository nurseRespository)
        {
            _nurseRespository = nurseRespository;
        }
        public BaseResponse AddNurse(CreateNurseRequestModel createNurseRequest)
        {
            if (createNurseRequest == null)
            {
                return new BaseResponse
                {
                    Message = "Pls fill the form completely",
                    Success = false
                };
            }
            var nurse = new Nurses
            {
                Name = createNurseRequest.Name,
                PhoneNumber = createNurseRequest.PhoneNumber,
                Age = createNurseRequest.Age,
                User = new User
                {
                  Email = createNurseRequest.Email,
                  PassWord = createNurseRequest.PassWord,
                }
            };
            _nurseRespository.CreateNurse(nurse);
             return new BaseResponse
            {
                Message = "Your Account Was Created Successfully",
                Success = true
            };

        }

        public BaseResponse EditNurse(UpdateNurseRequestModel requestModel,string nurseId)
        {
              if (requestModel == null)
            {
                return new BaseResponse
                {
                    Message = "Pls fill the form completely",
                    Success = false
                };
            }
            var nurse = _nurseRespository.GetNurse(nurseId);
             if (nurse == null)
            {
                return new BaseResponse
                {
                    Message = "Cannot match NurseId",
                    Success = false
                };
            }
            nurse.Name = requestModel.Name;
            nurse.Age = requestModel.Age;
            nurse.PhoneNumber = requestModel.PhoneNumber;
            nurse.User.Email = requestModel.Email;
            nurse.User.PassWord = requestModel.PassWord;
            _nurseRespository.UpdateNurse(nurse);
            return new BaseResponse
            {
                Message = $"Doctor with {nurse.NurseId} is Updated Successfully ",
                Success = true
            };
        }
        public NurseResponseModel ViewNurse(string nurseId)
        {
            var get = _nurseRespository.GetNurse(nurseId);
            if (get == null)
            {
                return new NurseResponseModel
                {
                   Message = "can't credentials try again",
                   Success = false,

                };
            }
            return new NurseResponseModel
            {
               Message = "credentials matched successfully",
               Success =  true,
               NurseDtos = new NurseDto
               {
                Name = get.Name,
                Email = get.User.Email,
                NurseId = get.NurseId,
               }
            };
        }

        public NursesResponseModel ViewAllNurse()
        {
             var get = _nurseRespository.GetAllNurse();
            if (get == null)
            {
                return new NursesResponseModel
                {
                    Message = " Having some problem try again",
                    Success = false,
                };
            }
            return new NursesResponseModel
            {
                Message = "Track Successfully",
                Success = true,

            };
        }

        public BaseResponse DeleteNurse(string nurseId)
        {
            
            if (nurseId == null)
            {
                return new BaseResponse
                {
                    Message = "Can't Find DoctorId",
                    Success = false,
                };
            }
            var doc = _nurseRespository.GetNurse(nurseId);
            if (doc == null)
            {
                return new BaseResponse
                {
                    Message = "NurseId does not exist",
                    Success = false,
                };
            }
            _nurseRespository.DeleteNurse(nurseId);
            return new BaseResponse
            {
                Message = "Doctor deleted Successfully",
                Success = true,
            };
        }
        public Nurses Login(string email, string passWord)
        {
            return _nurseRespository.Login(email, passWord);
        }
        public Nurses ApproveNurse(string nurseId)
        {
            var nurse = _nurseRespository.GetNurse(nurseId);
            if (nurse == null)
            {
                return nurse;
            }
            nurse.IsApproved = true;
            return _nurseRespository.UpdateNurse(nurse);
        }
    }
}