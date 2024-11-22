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
    }
}
