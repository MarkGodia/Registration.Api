using Registration.Api.Dtos;
using Registration.Api.Models;

namespace Registration.Api.Services
{
    public class StudentService : IStudentService
    {
        private readonly RegistrationContext registrationContext;

        public StudentService(RegistrationContext registrationContext) 
        { 
            this.registrationContext = registrationContext;
        }
        public string AddNewStudent(StudentDto student)
        {
            var registrationDetails=Students.AddNewStudent(student.FirstName, 
                student.LastName,
                student.PhoneNumber,
                student.EmailAddress,student.DateOfBirth);

            this.registrationContext.Add(registrationDetails);
            this.registrationContext.SaveChanges();

            return $"Student with Id{registrationDetails.id}successfully Created";
        }
    }
}
