using StudentProfileSystem.Data;
using StudentProfileSystem.Models.Entity;
using StudentProfileSystem.Models.Request;
using StudentProfileSystem.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;

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

            student.UpdateStudent(request);
            context.StudentInfoHub.Update(student);
            context.SaveChanges();
            return $"{student.ID} was updated";
        }

        public string DeleteStudent(int id)
        {
            var student = context.StudentInfoHub.Find(id);
            if (student == null)
            {
                return "Student not found";
            }

            context.StudentInfoHub.Remove(student);
            context.SaveChanges();
            return $"{student.ID} was deleted";
        }

        public StudentResponse GetStudent(int id)
        {
            var student = context.StudentInfoHub.Find(id);
            if (student == null)
            {
                return null;
            }

            return new StudentResponse
            {
                ID = student.ID,
                StudentName = student.StudentName,
                Department = student.Department,
                Email = student.Email,
                PhoneNumber = student.PhoneNumber,
                Gender = student.Gender,
               
            };
        }

    }
}
