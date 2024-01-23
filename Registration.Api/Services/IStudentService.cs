using Registration.Api.Dtos;

namespace Registration.Api.Services
{
    public interface IStudentService
    {
        string AddNewStudent(StudentDto student);
    }
}
