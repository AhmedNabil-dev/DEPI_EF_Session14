using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain.Health_Care_System
{
    internal class Appointment
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }
         public DateTime AppointmentDate { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
