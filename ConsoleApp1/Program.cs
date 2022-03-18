using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        public Program()
        {
        }

        public Program(int a)
        {
        }

        static void Main(string[] args)
        {
            int x = 1;
            bool y = Convert.ToBoolean(x);
            float f = x;

            object obj = 20;

            //Cast
            int a = (int)obj;

            var matriculas = new MyList<int>() { 2, 4, 58, 9, 78 };

            Console.WriteLine(matriculas.ToString());
        }

        
    }
    public class MyList<T> : List<T>
    {
        public override string ToString()
        {
            var result = "";
            
            for (var i = 0; i < Count; i++)
            {
                result += this[i];

                if (i < Count - 1)
                    result += ",";
            }

            return result;
        }
    }
}