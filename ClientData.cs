

using System.Collections.Generic;

namespace CarRentalSystem
{
    public static class ClientData
    {
        public static List<Client> Clients = new List<Client>();

        public static void LoadDefaultClients()
        {
            if (Clients.Count > 0)
            {
                return;
            }

            Clients.Add(new Client { Name = "Ahmad Ali", Phone = "0791234567", NationalID = "2000123456", Address = "Amman", Email = "ahmad@gmail.com", LicenseNumber = "1001" });
            Clients.Add(new Client { Name = "Sara Omar", Phone = "0789876543", NationalID = "2000987654", Address = "Zarqa", Email = "sara@gmail.com", LicenseNumber = "1002" });
            Clients.Add(new Client { Name = "Mohammad Khaled", Phone = "0771122334", NationalID = "1999123456", Address = "Irbid", Email = "mohammad@gmail.com", LicenseNumber = "1003" });
            Clients.Add(new Client { Name = "Lana Saleh", Phone = "0794455667", NationalID = "2001567890", Address = "Amman", Email = "lana@gmail.com", LicenseNumber = "1004" });
            Clients.Add(new Client { Name = "Omar Nasser", Phone = "0783344556", NationalID = "1998765432", Address = "Madaba", Email = "omar@gmail.com", LicenseNumber = "1005" });
            Clients.Add(new Client { Name = "Yazan Sami", Phone = "0799988776", NationalID = "2001456789", Address = "Salt", Email = "yazan@gmail.com", LicenseNumber = "1006" });
            Clients.Add(new Client { Name = "Huda Mahmoud", Phone = "0776677889", NationalID = "2001789456", Address = "Aqaba", Email = "huda@gmail.com", LicenseNumber = "1007" });
            Clients.Add(new Client { Name = "Khaled Mansour", Phone = "0785566778", NationalID = "1999345678", Address = "Jerash", Email = "khaled@gmail.com", LicenseNumber = "1008" });
            Clients.Add(new Client { Name = "Rama Hassan", Phone = "0792233445", NationalID = "2001678901", Address = "Karak", Email = "rama@gmail.com", LicenseNumber = "1009" });
            Clients.Add(new Client { Name = "Laith Taha", Phone = "0778899001", NationalID = "2001123987", Address = "Mafraq", Email = "laith@gmail.com", LicenseNumber = "1010" });
        }
    }
}