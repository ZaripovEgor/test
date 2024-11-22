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
        
    }
}
