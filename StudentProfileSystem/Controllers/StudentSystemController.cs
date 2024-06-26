﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProfileSystem.Models.Request;
using StudentProfileSystem.Models.Entity;
using StudentProfileSystem.Data;
using StudentProfileSystem.Controllers;
using StudentProfileSystem.Services;
using StudentProfileSystem.Models.Response;

namespace StudentProfileSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentSystemController : ControllerBase
    {
        private readonly StudentService stuService;


        public StudentSystemController(StudentService studentService)
        {
            stuService = studentService;


        }
        [HttpPost]
        public IActionResult Create(StudentRequest request)
        {
            string response = stuService.CreateStudent(request);
            return !string.IsNullOrEmpty(response) ? Ok(response) : BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, StudentRequestUpdate request)
        {
            var response = stuService.UpdateStudent(id, request);
            return !string.IsNullOrEmpty(response) ? Ok(response) : NotFound(response);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            string response = stuService.DeleteStudent(id);
            return !string.IsNullOrEmpty(response) ? Ok(response) : NotFound(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = stuService.GetStudent(id);
            return student != null ? Ok(student) : NotFound();
        }
    
       

            [HttpGet("StuDep/{DID}")]
            public ActionResult<List<StudentResponse>> GetStudentsByDID(int DID)
            {
                var students = stuService.GetStudentsByDID(DID);
                if (students == null )
                {
                    return NotFound();
                }
                return Ok(students);
            }
        }
    }






    
