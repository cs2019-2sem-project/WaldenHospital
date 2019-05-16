using System;

namespace Walden_Hospital.Models
{
    public class Visit
    {
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public int VisitID { get; set; }
        public DateTime Date { get; set; }
        public float Cost { get; set; }
    }
}