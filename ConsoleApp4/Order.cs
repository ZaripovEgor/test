using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Order
    {
        public enum OrderStatus
        {
            Created,
            InProgress,
            Completed
        }
        public int OrderId { get; private set; } // Уникальный идентификатор заказа
        public string Description { get; set; } // Описание заказа
        public Employee AssignedEmployee { get; set; } // Ответственный сотрудник
        public OrderStatus Status { get; set; } // Статус заказа
        public DateTime CreatedAt { get; private set; } // Дата создания заказа

        // Статический идентификатор для генерации уникальных идентификаторов заказов
        private static int nextId = 1;

        public Order(string description)
        {
            OrderId = nextId++; // Автоматическая генерация идентификатора
            Description = description;
            OrderStatus created = OrderStatus.Created; // Статус при создании заказа "Создан"
            CreatedAt = DateTime.Now; // Установка даты создания заказа
        }
    }
}
