using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HDD : Component, IInstallable
    {
        public int Space;
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Объём свободного места: {Space} ГБ");
        }
        public void Install()
        {
            Console.WriteLine("Подлючение жёсткого диска к материнской плате");
        }
    }
}
