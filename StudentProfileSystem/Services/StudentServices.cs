using Microsoft.EntityFrameworkCore;
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
            context.StuInfo.Add(student);
            context.SaveChanges();
            return $"{student.ID} was added";
        }

        public string UpdateStudent(int id, StudentRequestUpdate request)
        {
            var student = context.StuInfo.Find(id);
            if (student == null)
            {
                return "Student not found";
            }

            student.UpdateStudent(request);
            context.StuInfo.Update(student);
            context.SaveChanges();
            return $"{student.ID} was updated";
        }

        public string DeleteStudent(int id)
        {
            var student = context.StuInfo.Find(id);
            if (student == null)
            {
                return "Student not found";
            }

            context.StuInfo.Remove(student);
            context.SaveChanges();
            return $"{student.ID} was deleted";
        }

        public StudentResponse GetStudent(int id)
        {
            var students = (from e in context.StuInfo where e.ID == id select e).Include(e => e.StuDep).FirstOrDefault();
            if (students == null)
            {
                return null;
            }
            return StudentResponse.FromStudentRecord(students);
        }  
        public List<StudentResponse> GetStudentsByDID(int DID)
        {  
            var employees = (from e in context.StuInfo
                             where e.DID == DID
                             orderby e.StudentName
                             select e)
                            .Include(e => e.StuDep)
                            .ToList();
            return employees.Select(StudentResponse.FromStudentRecord).ToList();


        }
    }

}

