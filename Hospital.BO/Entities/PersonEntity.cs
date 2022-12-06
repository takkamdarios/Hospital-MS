using Hospital.BO.Extensions;

namespace Hospital.BO.Entities
{
    public class PersonEntity : BaseEntity
    {
        public int Id { get; set;}
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public int Contact { get; set; }
        public string? Description { get; set; }
        public string? Gender { get; set; }
        public PersonEntity() { }
        public PersonEntity(int id, string? firstName, string? lastName, DateTime dateOfBirth, 
            string? address, int contact, string? description, string? gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
            Contact = contact;
            Description = description;
            Gender = gender;
        }
    }
}
