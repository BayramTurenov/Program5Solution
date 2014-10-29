using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string myName = "Bayram";
            //2
            int myAge = 34;
            //3
            bool myBool = true;
            //4
            List<string> productList = new List<string>() { "baskeball","baseball glove","tennis shoes","hockey puck"};
            //5
            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer");
            //6
            Console.WriteLine("I am " + myAge + " years awesome.");
            //7
            Console.WriteLine("I set my boolean value equal to " + myBool);
            //8
            for (int i = 0; i < productList.Count(); i = i + 1)
            {
                Console.WriteLine(productList[i]);
            }

            //9
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            
            //10
            for (int i = 10; i >0; i--)
            {
                Console.WriteLine(i); 
            }

            //11
            for (int i = 10; i < 31; i = i + 2)
            {
                Console.WriteLine(i);   
            }

            //12
            for (int i = 100; i > 74; i = i - 5)
            {
              Console.WriteLine(i);      
            }

            //13
            int a = 0;
            while (a < 11)
            {
                Console.WriteLine(a);
                a++;
            }

            //14

            int b = 10
                while (b)
	{
	         
	}

        Console.ReadKey();

        }
    }
}
