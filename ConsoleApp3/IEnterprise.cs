using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface IEnterprise
    {
        void AddSupplier(ISupplier supplier);
        void AddEmployee(IEmployee employee);
        List<ISupplier> GetSuppliers();
        decimal CalculateTotalExpense();
    }
}
