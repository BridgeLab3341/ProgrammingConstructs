using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class IfElseProblems
    {
        public void CheckIntegersEqualOrNot()
        {
            Console.WriteLine("Enter Two Numbers");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            if(num1 == num2)
            {
                Console.WriteLine("{0} and {1} are Equal",num1,num2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are NotEqual", num1, num2);
            }
        }
        public void CheckNumIsEvenOdd()
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("{0} Is Even Number.", num);
            }
            else
            {
                Console.WriteLine("{0} Is Odd Number.",num);
            }
        }
        public void CheckAgeEligiblity(int age)
        {
            if(age < 18)
            {
                Console.WriteLine("Candidate age {0} is Not Eligible to Vote",age);
            }
            else
            {
                Console.WriteLine("Candidate age {0} is Eligible to Vote",age);
            }
        }
    }
}
