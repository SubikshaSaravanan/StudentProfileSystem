using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProfileSystem.Models.Request;
using StudentProfileSystem.Models.Entity;
using StudentProfileSystem.Data;
using StudentProfileSystem.Controllers;
using StudentProfileSystem.Services;

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
        public IActionResult Update(int id, StudentRequest request)
        {
            string response = stuService.UpdateStudent(id, request);
            return !string.IsNullOrEmpty(response) ? Ok(response) : NotFound(response);
        }

      
    }


}
    
