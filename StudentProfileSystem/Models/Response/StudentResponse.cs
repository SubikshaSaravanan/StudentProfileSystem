using StudentProfileSystem.Models.Entity;

namespace StudentProfileSystem.Models.Response
{
    public class StudentResponse
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string DepartmentName { get; set; }
        public int DID { get; set; }
        public string Gender { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }

        public static StudentResponse FromStudentRecord(StuRec stuRec)
        {
            return new StudentResponse
            {
                ID = stuRec.ID,
                StudentName = stuRec.StudentName,
                DID = stuRec.DID,
                DepartmentName = stuRec.StuDep?.DepartmentName,
                Gender = stuRec.Gender,
                Email = stuRec.Email,
                PhoneNumber = stuRec.PhoneNumber,
                CreatedBy = stuRec.CreatedBy,
                ModifiedBy = stuRec.ModifiedBy,
                CreatedAt = stuRec.CreatedAt,
                ModifiedAt = stuRec.ModifiedAt,




            };
        }
    } 
}

