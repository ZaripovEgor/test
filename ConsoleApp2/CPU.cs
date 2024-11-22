using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CPU : Component, IInstallable
    {
        public double Frequency;
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Частота процессора: {Frequency} ГГц");
        }
        public void Install()
        {
            Console.WriteLine("Установка процессора в материнскую плату");
        }

        public static bool operator ==(CPU c1, CPU c2)
        {
            return c1.Name == c2.Name && c1.Frequency == c2.Frequency && c1.Price == c2.Price;
        }

        public static bool operator !=(CPU c1, CPU c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            return obj is CPU cpu && this == cpu;
        }
    }
}
