using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class Problems
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
    }
}
