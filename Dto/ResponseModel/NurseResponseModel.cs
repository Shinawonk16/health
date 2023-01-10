namespace Ex_ample.Dto.ResponseModel
{
    public class NurseResponseModel:BaseResponse
    {
        public NurseDto NurseDtos{get;set;}
    }
    public class NursesResponseModel:BaseResponse
    {
        public ICollection<NurseDto>NurseDtos{get;set;}
    }
}