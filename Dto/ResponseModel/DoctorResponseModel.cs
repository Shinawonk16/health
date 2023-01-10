namespace Ex_ample.Dto.ResponseModel
{
    public class DoctorResponseModel:BaseResponse
    {
        public DoctorDto DoctorDtos{get;set;}
    }
    public class DoctorsResponseModel:BaseResponse
    {
        public ICollection<DoctorDto>DoctorDtos{get;set;}
    }
}    