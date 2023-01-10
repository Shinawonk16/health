namespace Ex_ample.Dto.ResponseModel
{
    public class NonMedicalStaffsResponseModel : BaseResponse
    {
        public NonMedicalStaffsDto NonMedicalStaffsDto { get; set; }
    }
    public class NonMedicalStaffsResponseModels : BaseResponse
    {
        public ICollection<NonMedicalStaffsDto> NonMedicalStaffsDto { get; set; }
    }
}