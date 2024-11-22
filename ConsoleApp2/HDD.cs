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
        public static bool operator ==(HDD h1, HDD h2)
        {
            return h1.Name == h2.Name && h1.Space == h2.Space && h1.Price == h2.Price;
        }

        public static bool operator !=(HDD h1, HDD h2)
        {
            return !(h1 == h2);
        }

        public override bool Equals(object obj)
        {
            return obj is HDD hdd && this == hdd;
        }
    }
}
