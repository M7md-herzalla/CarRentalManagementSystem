namespace CarRentalSystem
{
    public class RentalCar
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string PlateNumber { get; set; }
        public string Color { get; set; }
        public decimal DailyPrice { get; set; }
        public string Status { get; set; }
        public string ImageFileName { get; set; }

        public string DisplayText
        {
            get
            {
                return Brand + " " + Type + " " + Year +
                       " | Plate: " + PlateNumber +
                       " | " + DailyPrice + " JD/day";
            }
        }
    }
}