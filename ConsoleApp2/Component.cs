using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Component : IInstallable
    {
        public string Name { get; set; }
        public int Price {  get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine("---Info---");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Наименование: {Name}");
        }
        public virtual int GetPrice()
        {
            return Price;
        }
        protected virtual string ToString(int I)
        {
            return I.ToString();
        }
        protected virtual string ToString(double D)
        {
            return D.ToString();
        }

        public void Install()
        {
            throw new NotImplementedException();
        }
    }
}
