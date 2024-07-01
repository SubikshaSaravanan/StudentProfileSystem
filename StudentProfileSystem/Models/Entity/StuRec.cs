using StudentProfileSystem.Models.Request;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentProfileSystem.Models.Entity
{
    public class StuRec : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        public string StudentName { get; set; }
       
        public string Gender { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey("DID")]
        public int DID { get; set; }
        public StuDep StuDep { get; set; }


        public void AddStudent(StudentRequest request)
        {
            StudentName = request.StudentName;
            DID = request.DID;
            Email = request.Email;
            PhoneNumber = request.MobileNo;
            Gender = request.Gender;
            CreatedBy = request.CreatedBy;
            ModifiedBy = request.CreatedBy;
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }


        public void UpdateStudent(StudentRequestUpdate request)
        {
            StudentName = request.StudentName;
            DID = request.DID;
            Email = request.Email;
            PhoneNumber = request.MobileNo;
            Gender = request.Gender;
            ModifiedBy = request.ModifiedBy;
            ModifiedAt = DateTime.UtcNow;
        }

       
    }
}
