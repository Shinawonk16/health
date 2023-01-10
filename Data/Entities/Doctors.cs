using System.ComponentModel.DataAnnotations;

namespace Ex_ample.Data.Entities
{
    public class Doctors
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string PhoneNumber{get;set;}
        public int Age{get;set;}
        public User User{get;set;}
        public int UserId{get;set;}
        [Key]
        public string DoctorId{get;set;} = $"Dr{Guid.NewGuid().ToString().Replace("_","").Substring(0,6)}";
        public bool IsApproved{get;set;}=false;
        public string Qualification{get;set;}
    }
    
}