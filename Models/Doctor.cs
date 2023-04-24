using System.ComponentModel.DataAnnotations;

namespace Stomatology.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
