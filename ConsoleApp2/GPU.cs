using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class GPU : Component, IInstallable
    {

        public int Volume;
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Объём видеопамяти: {Volume} ГБ");
        }
        public void Install()
        {
            Console.WriteLine("Установка видеокарты в материнскую плату");
        }
        public static bool operator ==(GPU g1, GPU g2)
        {
            return g1.Name == g2.Name && g1.Volume == g2.Volume && g1.Price == g2.Price;
        }

        public static bool operator !=(GPU g1, GPU g2)
        {
            return !(g1 == g2);
        }

        public override bool Equals(object obj)
        {
            return obj is GPU gpu && this == gpu;
        }
    }
}
