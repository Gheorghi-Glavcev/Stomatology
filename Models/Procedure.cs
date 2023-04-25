using System.ComponentModel.DataAnnotations;

namespace Stomatology.Models
{
    public class Procedure
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Doctor_Procedure> Doctors_Procedures { get; set; }
    }
}
