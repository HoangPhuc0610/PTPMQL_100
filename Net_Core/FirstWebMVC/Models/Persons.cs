using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models
{
   
    public class Persons
    {
        [Key]
        public string PersonId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }
    }
}
