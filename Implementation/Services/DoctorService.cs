using Ex_ample.Data.Entities;
using Ex_ample.Dto;
using Ex_ample.Dto.RequestModel;
using Ex_ample.Dto.ResponseModel;
using Ex_ample.Interfaces.Respository;
using Ex_ample.Interfaces.Services;

namespace Ex_ample.Implementation.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRespository _doctorrespository;
        public DoctorService(IDoctorRespository doctorRespository)
        {
            _doctorrespository = doctorRespository;
        }
        public BaseResponse AddDoctor(CreateDoctorRequestModel model)
        {
            if (model == null)
            {
                return new BaseResponse
                {
                    Message = "Pls fill the form completely",
                    Success = false
                };
            }
            var doctor = new Doctors
            {
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                Age = model.Age,
                User = new User
                {
                    Email = model.Email,
                    PassWord = model.PassWord,
                }
            };
            _doctorrespository.CreateDoctor(doctor);
            return new BaseResponse
            {
                Message = "Your Account Was Created Successfully",
                Success = true
            };
        }

        public BaseResponse EditDoctor(UpdateDoctorRequestModel requestModel, string doctorId)
        {
            if (requestModel == null)
            {
                return new BaseResponse
                {
                    Message = "Pls fill the form completely",
                    Success = false
                };
            }
            var doctor = _doctorrespository.GetDoctor(doctorId);
            if (doctor == null)
            {
                return new BaseResponse
                {
                    Message = "Cannot match DoctorId",
                    Success = false
                };
            }
            doctor.Name = requestModel.Name;
            doctor.Age = requestModel.Age;
            doctor.PhoneNumber = requestModel.PhoneNumber;
            doctor.User.Email = requestModel.Email;
            doctor.User.PassWord = requestModel.PassWord;
            _doctorrespository.UpdateDoctor(doctor);
            return new BaseResponse
            {
                Message = $"Doctor with {doctor.DoctorId} is Updated Successfully ",
                Success = true
            };
        }
        public BaseResponse DeleteDoctor(string doctorId)
        {
            if (doctorId == null)
            {
                return new BaseResponse
                {
                    Message = "Can't Find DoctorId",
                    Success = false,
                };
            }
            var doc = _doctorrespository.GetDoctor(doctorId);
            if (doc == null)
            {
                return new BaseResponse
                {
                    Message = "DoctorId does not exist",
                    Success = false,
                };
            }
            _doctorrespository.DeleteDoctor(doc);
            return new BaseResponse
            {
                Message = "Doctor deleted Successfully",
                Success = true,
            };
        }

        public DoctorsResponseModel ViewAllDoctors()
        {
            var get = _doctorrespository.GetAllDoctor();
            if (get == null)
            {
                return new DoctorsResponseModel
                {
                    Message = " Having some problem try again",
                    Success = false,
                };
            }
            return new DoctorsResponseModel
            {
                Message = "Track Successfully",
                Success = true,

            };
        }

        public DoctorResponseModel ViewDoctor(string doctorId)
        {
            var retor = _doctorrespository.GetDoctor(doctorId);
            if (retor == null)
            {
                return new DoctorResponseModel
                {
                    Message = "Can't find doctorId",
                    Success = false,

                };
            }
            return new DoctorResponseModel
            {
                Message = "doctorId track successfully",
                Success = true,
                DoctorDtos = new DoctorDto
                {
                    Name = retor.Name,
                    Email = retor.User.Email,
                    DoctorId = retor.DoctorId,
                }
            };
        }


        public Doctors Login(string email, string passWord)
        {
            return _doctorrespository.Login(email, passWord);
        }
        public Doctors ApproveDoctor(string doctorId)
        {
            var doctor = _doctorrespository.GetDoctor(doctorId);
            if (doctor == null)
            {
                return doctor;
            }
            doctor.IsApproved = true;
            return _doctorrespository.UpdateDoctor(doctor);
        }


    }
}