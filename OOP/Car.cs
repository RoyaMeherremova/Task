using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        public Car()
        {
            Console.WriteLine("Empty");
        }
        public Car(string name) : this()
        {
            Console.WriteLine(name);
        }
        public Car(string name, int n) : this(name)
        {
            Console.WriteLine(n);
        }

        public string color;
        private string name;
        protected int horsePower;
        public int Marka { get; set; }
        public DateTime Date { get; set; }
        private int _horseePower;
        public int HorsePower {
            get
            {

                if (_horseePower > 200)

                {
                    return _horseePower;
                }
                return -1;
            }







            set
            {
                _horseePower = value;

            }


        }
        
    }

}
