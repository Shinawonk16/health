namespace Ex_ample.Data.Entities
{
    public class User
    {
        public int Id {get;set;}
        public Doctors Doctors {get;set;}
        public Nurses Nurses {get;set;}
        public ElifeSaverManagement ElifeSaverManagement {get;set;}
        public NonMedicalStaff NonMedicalStaff {get;set;}
        public string Email {get;set;}
        public string PassWord {get;set;}
    }
}