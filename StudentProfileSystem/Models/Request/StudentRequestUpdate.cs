namespace StudentProfileSystem.Models.Request
{
    public class StudentRequestUpdate
    {
        public string StudentName { get; set; }
        public int DID { get; set; }
        public string Gender { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public string? ModifiedBy{ get; set; }
    }
}
