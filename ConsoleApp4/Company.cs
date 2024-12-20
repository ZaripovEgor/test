using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp4.Order;

namespace ConsoleApp4
{
    public class Company
    {

        public string Name { get; set; } // Название компании
        private List<Employee> Employees { get; set; } = new List<Employee>(); // Список сотрудников
        private List<Order> Orders { get; set; } = new List<Order>(); // Список заказов

        // Делегат для уведомления об изменении статуса заказа
        public delegate void OrderStatusChangedHandler(Order order);
        public event OrderStatusChangedHandler OrderStatusChanged; // Событие изменения статуса заказа

        public Company(string name)
        {
            Name = name;
        }

        // Метод для добавления нового сотрудника
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            Console.WriteLine($"Сотрудник {employee.FirstName} {employee.LastName} добавлен в компанию.");
        }

        // Метод для добавления нового заказа
        public void AddOrder(Order order)
        {
            Orders.Add(order);
            Console.WriteLine($"Заказ {order.Description} добавлен. ID: {order.OrderId}");
        }

        // Метод для назначения сотрудника на заказ
        public void AssignEmployeeToOrder(int orderId, Employee employee)
        {
            // лямбда-выражение
            var order = Orders.Find(o => o.OrderId == orderId); // Поиск заказа по идентификатору
            if (order != null)
            {
                order.AssignedEmployee = employee; // Назначение сотрудника
                Console.WriteLine($"Сотрудник {employee.FirstName} {employee.LastName} назначен на заказ ID: {order.OrderId}");
            }
            else
            {
                Console.WriteLine($"Заказ с ID {orderId} не найден.");
            }
        }

        // Метод для изменения статуса заказа
        public void ChangeOrderStatus(int orderId, OrderStatus newStatus)
        {
            // лямбда-выражение
            var order = Orders.Find(o => o.OrderId == orderId); // Поиск заказа по идентификатору
            if (order != null)
            {
                order.Status = newStatus; // Изменение статуса заказа
                Console.WriteLine($"Статус заказа ID: {order.OrderId} изменен на {newStatus}.");

                // Вызываем событие для уведомления сотрудников
                OrderStatusChanged?.Invoke(order);
            }
            else
            {
                Console.WriteLine($"Заказ с ID {orderId} не найден.");
            }
        }

        // Метод для просмотра всех заказов по статусу
        public List<Order> GetOrdersByStatus(OrderStatus status)
        {
            // лямбда-выражение
            return Orders.FindAll(o => o.Status == status); // Возвращаем список заказов по статусу
        }

        // Метод для получения отчета по всем сотрудникам
        public void PrintEmployeeReport()
        {
            Console.WriteLine("\nОтчет по сотрудникам:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - обработано заказов: {employee.OrdersProcessed}");
            }
        }
    }
}
