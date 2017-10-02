namespace CompanyWebAPI.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        //available number format: 32/1a
        public string StreetNumber { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Nip { get; set; }
        public string Krs { get; set; }
        public string Regon { get; set; }

    }
}