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
            this.StudentName = request.Name;
            this.Department = request.Dept;
            this.Email = request.Email;
            this.PhoneNumber = request.MobileNo;
            this.Gender = request.Gender;
            this.CreatedBy = request.CreatedBy;
            this.ModifiedBy = request.CreatedBy;
            this.CreatedAt = DateTime.Now;
            this.ModifiedAt = DateTime.Now;
        }


        public void UpdateStudent(StudentRequest request)
        {
            this.StudentName = request.Name;
            this.Department = request.Dept;
            this.Email = request.Email;
            this.PhoneNumber = request.MobileNo;
            this.Gender = request.Gender;
            this.ModifiedBy = request.CreatedBy;
            this.ModifiedAt = DateTime.Now;
        }

       
    }
}
