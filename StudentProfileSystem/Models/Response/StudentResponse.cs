namespace StudentProfileSystem.Models.Response
{
    public class StudentResponse
    {
            public int ID { get; set; }
            public string StudentName { get; set; }
            public string Department { get; set; }
            public string Gender { get; set; }
            public string? Email { get; set; }
            public string PhoneNumber { get; set; }
        
    }
}
