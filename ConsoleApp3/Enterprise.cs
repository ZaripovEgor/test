using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Enterprise : IEnterprise
    {
        protected List<ISupplier> suppliers = new List<ISupplier>();
        protected List<IEmployee> employees = new List<IEmployee>();
        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee); // Добавить сотрудника в список
        }

        public void AddSupplier(ISupplier supplier)
        {
            suppliers.Add(supplier); // Добавить поставщика в список
        }

        public decimal CalculateTotalExpense()
        {
            decimal total = 0;
            // Рассчитываем расходы на поставщиков
            foreach (var supplier in suppliers)
            {
                total += supplier.GetCost();
            }
            // Рассчитываем расходы на сотрудников
            foreach (var employee in employees)
            {
                total += employee.GetSalary();
            }
            return total; // Возвращаем общие расходы
        }

        public List<ISupplier> GetSuppliers()
        {
            return suppliers; // Вернуть список поставщиков
        }
    }
}
