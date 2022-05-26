using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo1.Models
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        
        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        public string LastName { get; set; }

        [Required]
        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Column("updated_date")]
        public DateTime UpdatedDate { get; set; }
    }
}
