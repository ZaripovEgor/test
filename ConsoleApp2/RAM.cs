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
    }
}
