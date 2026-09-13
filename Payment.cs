using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    internal class Payment
    {
        public string ClientName { get; set; }
        public string ClientNationalID { get; set; }
        public string PlateNumber { get; set; }

        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount { get; set; }

        public string PaymentMethod { get; set; }
        public string PaymentType { get; set; }
        public string PaymentStatus { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
