using System.Collections.Generic;

namespace CarRentalSystem
{
    public static class CarData
    {
        public static List<RentalCar> Cars = new List<RentalCar>();
        public static void LoadDefaultCars()
        {
            if (Cars.Count > 0)
            {
                return;
            }

            Cars.Add(new RentalCar
            {
                Brand = "Toyota",
                Type = "Eco",
                Model = "Toyota Eco",
                Year = "2022",
                PlateNumber = "12-34567",
                Color = "White",
                DailyPrice = 35,
                Status = "Available",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "BMW",
                Type = "Luxury",
                Model = "BMW Luxury",
                Year = "2024",
                PlateNumber = "23-98765",
                Color = "Black",
                DailyPrice = 80,
                Status = "Available",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Hyundai",
                Type = "Classic",
                Model = "Hyundai Classic",
                Year = "2021",
                PlateNumber = "45-11223",
                Color = "Silver",
                DailyPrice = 30,
                Status = "Available",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Mercedes",
                Type = "Luxury",
                Model = "Mercedes Luxury",
                Year = "2023",
                PlateNumber = "78-44556",
                Color = "Gray",
                DailyPrice = 95,
                Status = "Maintenance",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Kia",
                Type = "Sport",
                Model = "Kia Sport",
                Year = "2020",
                PlateNumber = "34-55667",
                Color = "Red",
                DailyPrice = 40,
                Status = "Available",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Nissan",
                Type = "4x4",
                Model = "Nissan 4x4",
                Year = "2022",
                PlateNumber = "56-77889",
                Color = "Blue",
                DailyPrice = 55,
                Status = "Available",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Ford",
                Type = "4x4",
                Model = "Ford 4x4",
                Year = "2021",
                PlateNumber = "91-23456",
                Color = "Black",
                DailyPrice = 60,
                Status = "Available",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Chevrolet",
                Type = "Classic",
                Model = "Chevrolet Classic",
                Year = "2019",
                PlateNumber = "67-89012",
                Color = "White",
                DailyPrice = 28,
                Status = "Maintenance",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Audi",
                Type = "Luxury",
                Model = "Audi Luxury",
                Year = "2024",
                PlateNumber = "88-34521",
                Color = "Dark Blue",
                DailyPrice = 85,
                Status = "Available",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Honda",
                Type = "Eco",
                Model = "Honda Eco",
                Year = "2023",
                PlateNumber = "14-76543",
                Color = "Silver",
                DailyPrice = 33,
                Status = "Available",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Mazda",
                Type = "Sport",
                Model = "Mazda Sport",
                Year = "2022",
                PlateNumber = "31-99887",
                Color = "Red",
                DailyPrice = 45,
                Status = "Available",
                ImageFileName = "default.jpg"
            });

            Cars.Add(new RentalCar
            {
                Brand = "Tesla",
                Type = "Electric",
                Model = "Tesla Electric",
                Year = "2024",
                PlateNumber = "99-55441",
                Color = "White",
                DailyPrice = 100,
                Status = "Available",
                ImageFileName = "default.jpg"
            });
        }
    }
}