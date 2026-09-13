using System;

namespace CarRentalSystem
{
    public class Rental
    {
        public string ClientName { get; set; }
      public string ClientNationalID { get; set; }
        public string PlateNumber { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsFinished { get; set; }
    }
}