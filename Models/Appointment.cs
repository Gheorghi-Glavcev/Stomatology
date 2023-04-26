using System.ComponentModel.DataAnnotations;

namespace Stomatology.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Procedure Procedure { get; set; }

    }
}
