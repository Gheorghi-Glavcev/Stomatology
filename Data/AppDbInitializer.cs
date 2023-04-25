using Stomatology.Models;

namespace Stomatology.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        { 
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if(!context.Procedures.Any()) 
                {
                    context.Procedures.AddRange(new List<Procedure>()
                    {
                        new Procedure()
                        {
                            Name = "Procedure 1",
                            Description = "Description 1",
                            Price = 100
                        },
                        new Procedure()
                        {
                            Name = "Procedure 2",
                            Description = "Description 2",
                            Price = 200
                        }
                    });
                    context.SaveChanges();
                }

                if(!context.Doctors.Any())
                {
                    context.Doctors.AddRange(new List<Doctor>()
                    {
                        new Doctor()
                        {
                            Name = "Doctor 1"
                        },
                        new Doctor()
                        {
                            Name = "Doctor 2"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Doctors_Procedures.Any())
                {
                    context.Doctors_Procedures.AddRange(new List<Doctor_Procedure>()
                    {
                        new Doctor_Procedure()
                        {
                            DoctorId = 1,
                            ProcedureId = 1
                        },
                        new Doctor_Procedure()
                        {
                            DoctorId = 1,
                            ProcedureId = 2
                        },
                        new Doctor_Procedure()
                        {
                            DoctorId = 2,
                            ProcedureId = 1
                        },
                        new Doctor_Procedure()
                        {
                            DoctorId = 2,
                            ProcedureId = 2
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
