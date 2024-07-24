using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Donar
{
    public class Data
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BloodGroup { get; set; }
        public string City { get; set; }
        public int Gender { get; set; }
        public string Password { get; set; }
    }


    public class Manager
    {
        public static List<Data> DonarInformationManager()
        {
            return new List<Data>
            {
                new Data { Name = "Basharul Alam", Email = "basharulalam6@gmail.com", PhoneNumber = "01813890622", BloodGroup = "O+", City = "Dhaka", Gender = 1, Password = "1" },
                new Data { Name = "Rumpa Akter", Email = "rumpaakter@gmail.com", PhoneNumber = "01813890622", BloodGroup = "A+", City = "Feni", Gender = 2, Password = "1" },
                new Data { Name = "Baharul Karim", Email = "basharulkarim@gmail.com", PhoneNumber = "01813890622", BloodGroup = "O+", City = "Fulgazi", Gender = 1, Password = "1" },
                new Data { Name = "Basharul Alam", Email = "b@gmail.com", PhoneNumber = "01813890622", BloodGroup = "O+", City = "Dhaka", Gender = 1, Password = "1" },
                new Data { Name = "Basharul Alam", Email = "bm@gmail.com", PhoneNumber = "01813890622", BloodGroup = "O+", City = "Dhaka", Gender = 1, Password = "1" }
            };
        }
    }

    
    
}
