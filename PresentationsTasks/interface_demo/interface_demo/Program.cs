using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals[0].Name = "Barsik";
            animals[1].Name = "sharik";
            animals[2].Name = "murka";
            animals[3].Name = "Rex";
            foreach (var item in animals)
            {
                item.Feed();
                item.Voice();
            }
            Console.ReadKey();
        }
    }

    interface IAnimal
    {
        String Name { get; set; }
        void Voice();
        void Feed();
    }

    class Dog : IAnimal
    {
        public string Name { get; set; }

        public void Feed()
        {
            Console.WriteLine("Dog {0} is eating", Name);

        }

        public void Voice()
        {
            Console.WriteLine("Dog {0} is barking", Name);

        }
    }

    class Cat : IAnimal
    {
        public string Name { get ; set; }

        public void Feed()
        {
            Console.WriteLine("Cat {0} is eating", Name);
        }

        public void Voice()
        {
            Console.WriteLine("Cat {0} is meowing", Name);
        }
    }
}
