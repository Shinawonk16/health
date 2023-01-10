namespace Ex_ample.Dto.RequestModel
{
    public class CreateNurseRequestModel
    {
        public string Name{get;set;}
        public string Email{get;set;}
        public int Age{get;set;}
        public IFormFile Qualification{get;set;}
        public string PassWord{get;set;}
        public string PhoneNumber { get; set; }
    }
}