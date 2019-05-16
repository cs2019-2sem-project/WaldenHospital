namespace Walden_Hospital.Models
{
    public class Medicine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        public int Quantity { get; set; }
        public bool OverTheCounter { get; set; }
    }
}