namespace Ex_ample.Dto.ResponseModel
{
    public class ELIFESAVERMANAGEMENTResponseModel : BaseResponse
    {
        public ELIFESAVERMANAGEMENTDto ELIFESAVERMANAGEMENTDto { get; set; }
    }
    public class ELIFESAVERMANAGEMENTSResponseModel : BaseResponse
    {
        public ICollection<ELIFESAVERMANAGEMENTDto> ELIFESAVERMANAGEMENTDto { get; set; }
    }
    
}