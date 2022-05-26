using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace demo1.Dtos
{
    public class CustomerUpdateDto
    {
        [Required]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [Required]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [Required]
        [JsonPropertyName("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [JsonPropertyName("created_date")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [JsonPropertyName("updated_date")]
        public DateTime UpdatedDate { get; set; }
    }
}
