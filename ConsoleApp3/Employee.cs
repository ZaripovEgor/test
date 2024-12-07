using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Employee : IEmployee
    {
        private string fullName; // Полное имя сотрудника
        private decimal salary; // Зарплата

        public string Position { get; private set; } // Должность сотрудника

        public Employee(string fullName, decimal salary, string position)
        {
            this.fullName = fullName; // Инициализация полного имени
            this.salary = salary; // Инициализация зарплаты
            Position = position; // Инициализация должности
        }
        public string GetFullName()
        {
            return fullName; // Вернуть полное имя
        }

        public decimal GetSalary()
        {
            return salary; // Вернуть зарплату
        }

        public string Positions()
        {
            return Position; // Инициализация должности
        }
    }
}
