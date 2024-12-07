using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Supplier : ISupplier
    {
        public string SupplierType { get; private set; } // Тип поставщика
        private string name; // Название поставщика
        private decimal cost; // Стоимость услуг

        public decimal GetCost()
        {
            return cost; // Вернуть стоимость услуг
        }

        public string GetName()
        {
            return name; // Вернуть название поставщика
        }

        public Supplier(string name, decimal cost, string supplierType)
        {
            this.name = name; // Инициализация названия
            this.cost = cost; // Инициализация стоимости
            SupplierType = supplierType; // Инициализация типа поставщика
        }
    }
}
