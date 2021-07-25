using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 220;
            //  Console.WriteLine(number == 10 ? "number is 10" : "Number is not 10");
            //if(number == 10) {
            //      console.writeline("number is 10 ");
            //          }
            //else if (number == 20)
            //  {
            //      console.writeline("number is 20");
            //  }
            //else {
            //      console.writeline("number is not 10 or 20 ");
            //  }
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("number is not 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}

            if (number >= 0 && number < 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <=200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number <0) // || veya crtl alt küçüktür
            {
                Console.WriteLine("Number is less than0 or greater than 200");
            }
            Console.ReadLine();

        }

    }
}
