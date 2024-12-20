using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Customer
    {
        public string FirstName { get; set; } // Имя заказчика
        public string LastName { get; set; }  // Фамилия заказчика
        public string PhoneNumber { get; set; } // Контактный номер телефона

        public Customer(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
