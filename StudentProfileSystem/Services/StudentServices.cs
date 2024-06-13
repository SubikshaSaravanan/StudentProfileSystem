using StudentProfileSystem.Data;
using StudentProfileSystem.Models.Entity;
using StudentProfileSystem.Models.Request;

namespace StudentProfileSystem.Services
{
    public class StudentService
    {
        private readonly ApiContext context;

        public StudentService(ApiContext stcontext)
        {
            context = stcontext;
        }

        public string CreateStudent(StudentRequest request)
        {
            StuRec student = new StuRec();
            student.AddStudent(request);
            context.StudentInfoHub.Add(student);
            context.SaveChanges();
            return $"{student.ID} was added";
        }
        public string UpdateStudent(int id, StudentRequest request)
        {
            var student = context.StudentInfoHub.Find(id);
            if (student == null)
            {
                return "Student not found";
            }

            student.StudentName = request.Name;
            student.Department = request.Dept;
            student.Email = request.Email;
            student.PhoneNumber = request.MobileNo;
            student.Gender = request.Gender;
            student.ModifiedAt = DateTime.Now;

            context.StudentInfoHub.Update(student);
            context.SaveChanges();
            return $"{student.ID} was updated";
        }

        
    }

}

