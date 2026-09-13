using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRentalSystem
{
    public static class RentalData
    {
        public static List<Rental> Rentals = new List<Rental>();

        public static void LoadSampleRentals()
        {
            if (Rentals.Count > 0)
            {
                return;
            }

            CarData.LoadDefaultCars();
            ClientData.LoadDefaultClients();

            AddSampleRental("2000123456", "12-34567", DateTime.Today.AddDays(-5), DateTime.Today.AddDays(3));
            AddSampleRental("2000987654", "45-11223", DateTime.Today.AddDays(-3), DateTime.Today);
            AddSampleRental("1999123456", "34-55667", DateTime.Today.AddDays(-7), DateTime.Today.AddDays(-1));
            AddSampleRental("2001567890", "91-23456", DateTime.Today.AddDays(-1), DateTime.Today.AddDays(8));
        }

        private static void AddSampleRental(string nationalID, string plateNumber, DateTime rentDate, DateTime returnDate)
        {
            Client client = ClientData.Clients
                .FirstOrDefault(c => c.NationalID == nationalID);

            RentalCar selectedCar = CarData.Cars
                .FirstOrDefault(c => c.PlateNumber == plateNumber);

            if (client == null || selectedCar == null)
            {
                return;
            }

            if (selectedCar.Status == "Maintenance")
            {
                return;
            }

            int days = (returnDate.Date - rentDate.Date).Days;

            if (days <= 0)
            {
                days = 1;
            }

            decimal totalPrice = days * selectedCar.DailyPrice;

            Rentals.Add(new Rental
            {
                ClientName = client.Name,
                ClientNationalID = client.NationalID,
                PlateNumber = selectedCar.PlateNumber,
                RentDate = rentDate,
                ReturnDate = returnDate,
                TotalPrice = totalPrice,
                IsFinished = false
            });

            selectedCar.Status = "Rented";
        }

        public static string GetRentalStatus(Rental rental)
        {
            if (rental.IsFinished)
            {
                return "Finished";
            }

            if (DateTime.Today > rental.ReturnDate.Date)
            {
                return "Expired";
            }

            if (DateTime.Today == rental.ReturnDate.Date)
            {
                return "Due Today";
            }

            return "Active";
        }

        public static bool CanFinishRental(Rental rental)
        {
            return !rental.IsFinished && DateTime.Today >= rental.ReturnDate.Date;
        }

        public static void FinishRental(Rental rental)
        {
            if (rental == null)
            {
                return;
            }

            rental.IsFinished = true;

            RentalCar car = CarData.Cars
                .FirstOrDefault(c => c.PlateNumber == rental.PlateNumber);

            if (car != null)
            {
                car.Status = "Available";
            }
        }

        public static void UpdateFinishedRentals()
        {

        }
        }
}