namespace Clinic_Management_System.Models
{

    //Patient entity for clinic management system
    public class Patient
    {
        public Guid Id { get; set; }=Guid.NewGuid(); // Unique identifier for the patient i.e Primary Key

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsDeleted { get; set; } = false; // Soft delete flag




    }
}
