using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnterprise enterprise = new Enterprise(); // Создаём объект класса Enterprise

            // Добавляем поставщиков
            enterprise.AddSupplier(new Supplier("Логистический центр", 100000, "Логистика"));
            enterprise.AddSupplier(new Supplier("Поставщик офисной мебели", 50000, "Офисное оборудование"));

            // Добавляем сотрудников
            enterprise.AddEmployee(new Employee("Иван Иванов", 70000, "Менеджер"));
            enterprise.AddEmployee(new Employee("Анна Петрова", 95000, "Разработчик"));

            // Отображение списка поставщиков
            Console.WriteLine("Список поставщиков:");
            foreach (var supplier in enterprise.GetSuppliers())
            {
                Console.WriteLine($"{supplier.GetName()} - Стоимость услуг: {supplier.GetCost()}");
            }

            // Отображение списка сотрудников
            Console.WriteLine();
            Console.WriteLine("Список сотрудников:");
            Console.WriteLine("1. Иван Иванов - Должность: Менеджер - Зарплата: 70000");
            Console.WriteLine("2. Анна Петрова - Должность: Разработчик - Зарплата: 95000");

            // Подсчет и вывод общих расходов
            decimal totalExpenses = enterprise.CalculateTotalExpense();
            Console.WriteLine();
            Console.WriteLine($"Общие расходы: {totalExpenses}");
        }
    }
}
