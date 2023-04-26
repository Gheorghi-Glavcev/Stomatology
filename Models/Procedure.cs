using System.ComponentModel.DataAnnotations;

namespace Stomatology.Models
{
    public class Procedure
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        public List<Doctor_Procedure> Doctors_Procedures { get; set; }
    }
}
