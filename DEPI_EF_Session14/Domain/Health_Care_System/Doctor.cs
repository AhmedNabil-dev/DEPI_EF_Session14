using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain.Health_Care_System
{
    internal class Doctor
    {
        public int DoctorId { get; set; }   
        public string Name { get; set; }
        public string Specialization { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
