using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVcPractice1.Entities
{
    public class Employee
    {
        [Range(1,20)]
        public int Id { get; set; }
        [Required]
        [DisplayName("Username")]
        public string Firstname { get; set; }
        [Required]
        [DisplayName("User Surname")]
        public string Lastname { get; set; }

        public int CityId { get; set; }

    }
}
