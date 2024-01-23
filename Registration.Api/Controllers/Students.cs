using Microsoft.AspNetCore.Mvc;
using Registration.Api.Dtos;
using Registration.Api.Models;
using Registration.Api.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Registration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ControllerBase
    {
        private readonly IStudentService studentService;
        public Students(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        // GET: api/<Students>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Students>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Students>
        [HttpPost]
        public string Post([FromBody] StudentDto studentDetails)
        {
            return this.studentService.AddNewStudent(studentDetails);
        }

        // PUT api/<Students>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StudentDto studentDetails)
        {
        }

        // DELETE api/<Students>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
