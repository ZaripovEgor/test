using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class RAM : Component, IInstallable
    {
        public string Class;
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Вид оперативной памяти: {Class}");
        }
        public void Install()
        {
            Console.WriteLine("Установка оперативной памти в материнскую плату");
        }
        public static bool operator ==(RAM r1, RAM r2)
        {
            return r1.Name == r2.Name && r1.Class == r2.Class && r1.Price == r2.Price;
        }

        public static bool operator !=(RAM r1, RAM r2)
        {
            return !(r1 == r2);
        }

        public override bool Equals(object obj)
        {
            return obj is RAM ram && this == ram;
        }
    }
}
