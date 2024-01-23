using System.ComponentModel.DataAnnotations;

namespace Registration.Api.Models
{
    public class Students
    {
        [Key]
        public Guid id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Students(string firstName,string lastName,string emailAddress,string phoneNumber,DateTime dateOfBirth
            ) {
            id = Guid.NewGuid();
            FirstName = firstName;
            LastName = !string.IsNullOrEmpty(lastName) ? firstName : "";
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;

        }

        public Students(string firstName, string lastName, string phoneNumber, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }

        public static Students AddNewStudent(string firstName,string lastName,string phoneNumber,DateTime dateOfBirth)
        {
            return new Students(firstName, lastName, phoneNumber, dateOfBirth);
        }
        
    }
}
