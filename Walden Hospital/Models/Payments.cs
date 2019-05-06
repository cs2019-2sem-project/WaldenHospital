namespace Walden_Hospital.Models
{
    public class Payments
    {
        public int PaymentID { get; set; }
        public int PatientID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}