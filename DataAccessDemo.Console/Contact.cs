namespace DataAccessDemo.Console
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Contact")]
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(400)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(400)]
        public string LastName { get; set; }

        [Required]
        [StringLength(400)]
        public string Email { get; set; }

        [Required]
        [StringLength(400)]
        public string Phone { get; set; }
        
        public void Output()
        {
            System.Console.WriteLine("First Name: {0}, Last Name: {1}, Email: {2}, Phone: {3}", FirstName, LastName, Email, Phone);
        }
    }
}
