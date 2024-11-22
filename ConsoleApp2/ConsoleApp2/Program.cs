using static ConsoleApp2.Computer;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
    internal class Program
    {
        public class CpntCollection<T> where T : Component
        {
            private List<T> _components = new List<T>();
            public void Add(T component)
            {
                _components.Add(component);
            }
            public void Remove(T component)
            {
                _components.Remove(component);
            }
            public void GetTotalPrice()
            {
                int S = 0;
                foreach (var component in _components)
                {
                    S += component.GetPrice();
                }
                Console.WriteLine("");
                Console.WriteLine($"Стоимость составляющих: {S}");
            }
            public void Display()
            {
                foreach (var component in _components)
                {
                    component.GetInfo();
                }
            }
        }
        static void Main(string[] args)
        {
            CpntCollection<Component> cpnt = new CpntCollection<Component>();
            cpnt.Add(new CPU {Price =  11699, Name="I7-7700", Frequency = 3.6});
            cpnt.Add(new GPU { Price = 12199,  Name = "GTX 1060", Volume=3 });
            cpnt.Add(new HDD { Price = 5229, Name = "Seagate Barracuda", Space=1024 });
            cpnt.Add(new RAM { Price = 2200, Name = "Kingston FURY Beast 8 gb", Class="DDR4" });
            cpnt.Display();
            cpnt.GetTotalPrice();
            Console.ReadLine();
        }
    }
}

        
        

       
    