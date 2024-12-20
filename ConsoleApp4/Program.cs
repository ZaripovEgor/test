using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp4.Order;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание компании
            Company company = new Company("Технологические Решения");

            // Подписка на событие изменения статуса заказа, лямбда-выражение
            company.OrderStatusChanged += (Order order) =>
            {
                Console.WriteLine($"Заказ ID: {order.OrderId} изменил статус на {order.Status}.");
                if (order.AssignedEmployee != null)
                {
                    order.AssignedEmployee.OrdersProcessed++; // Увеличиваем количество обработанных заказов сотрудника
                }
            };

            // Добавление сотрудников
            Employee alice = new Employee("Иван", "Иванов", "Менеджер");
            Employee bob = new Employee("Пётр", "Петров", "Разработчик");
            company.AddEmployee(alice);
            company.AddEmployee(bob);

            // Создание и добавление заказов
            Order order1 = new Order("Разработка веб-сайта");
            Order order2 = new Order("Создание мобильного приложения");
            company.AddOrder(order1);
            company.AddOrder(order2);

            // Назначение сотрудников на заказы
            company.AssignEmployeeToOrder(order1.OrderId, alice);
            company.AssignEmployeeToOrder(order2.OrderId, bob);

            // Изменение статуса заказа
            company.ChangeOrderStatus(order1.OrderId, OrderStatus.InProgress);
            company.ChangeOrderStatus(order2.OrderId, OrderStatus.Completed);

            // Получение отчета по сотрудникам
            company.PrintEmployeeReport();
        }
    }
}
