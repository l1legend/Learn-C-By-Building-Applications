using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Person
    {
        private int _age = 25; //field (data within the class)

        public int getAge()
        {
            return _age;
        }

        public void setAge(int newAge)
        {
            _age = newAge;
        }

        static public void greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
