using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee
    {
        public string FirstName { get; set; } // Имя сотрудника
        public string LastName { get; set; }  // Фамилия сотрудника
        public string Position { get; set; }   // Должность
        public int OrdersProcessed { get; set; } = 0; // Количество обработанных заказов

        public Employee(string firstName, string lastName, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }
    }
}
