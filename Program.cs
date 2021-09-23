using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Divisible_Modulus
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Random generator = new Random();

            int numInput;
            int randNum = generator.Next(2 , 6);


            Console.WriteLine(randNum);
            Console.WriteLine (" Please input a higher number ");

             

            

            if (int.TryParse(Console.ReadLine(), out numInput)) 
            {

                    Console.WriteLine(( numInput % randNum));
            int total = Convert.ToInt32((numInput % randNum));
                
                
                if (numInput < randNum)
                {
                    Console.WriteLine("That Number is not higher.");
                }

                else if (numInput <= 0)
                {
                    Console.WriteLine("That is not a number.");
                }

                else if (total == 0)
                {
                    Console.WriteLine("It is divisable.");
                }
                Console.ReadLine();








            }
            else
            {
                Console.WriteLine("We only want NUMBERS.");
            }


            Console.ReadLine();






        } 
        

    }
}
