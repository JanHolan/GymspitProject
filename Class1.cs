using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    abstract class Animal
    {

        public virtual int getLegCount()
        {
            return 5;
        }

        abstract public void introduce2();
    }

    class Dog : Animal
    {
        private string name;
        public int dogCount = 0;

        public Dog(string name = "Vendelin")
        {
            this.name = name;
            Console.WriteLine("Vyrabim psa");
            dogCount++;
        }

        public override int getLegCount()
        {
            return 4;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name.ToUpper();
        }

        public override void introduce2()
        {
            Console.WriteLine("WOOF " + name + " and my leg count is " + this.getLegCount());
            Console.WriteLine("And count of dogs is " + dogCount);
        }
    }
}
