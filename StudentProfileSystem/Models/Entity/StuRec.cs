using StudentProfileSystem.Models.Request;
using System;
using System.ComponentModel.DataAnnotations;

namespace StudentProfileSystem.Models.Entity
{
    public class StuRec : BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string StudentName { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }


        public void AddStudent(StudentRequest request)
        {
            StudentName = request.Name;
            Department = request.Dept;
            Email = request.Email;
            PhoneNumber = request.MobileNo;
            Gender = request.Gender;
            CreatedBy = request.CreatedBy;
            ModifiedBy = request.CreatedBy;
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }


        public void UpdateStudent(StudentRequest request)
        {
            StudentName = request.Name;
            Department = request.Dept;
            Email = request.Email;
            PhoneNumber = request.MobileNo;
            Gender = request.Gender;
            ModifiedBy = request.CreatedBy;
            ModifiedAt = DateTime.UtcNow;
        }

       
    }
}
