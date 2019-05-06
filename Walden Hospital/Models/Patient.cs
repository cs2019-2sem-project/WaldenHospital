using System;

namespace Walden_Hospital.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public DateTime DoB { get; set; }
        public DateTime dateBecomePatient { get; set; }
        public string Email { get; set; }
        public string MedicalRecord { get; set; }
    }
}