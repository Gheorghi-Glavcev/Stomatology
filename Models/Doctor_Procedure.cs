namespace Stomatology.Models
{
    public class Doctor_Procedure
    {
        public int DoctorId { get; set; } 
        public Doctor Doctor { get; set; }

        public int ProcedureId { get; set; }
        public Procedure Procedure { get; set; }
    }
}
