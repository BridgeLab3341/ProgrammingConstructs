namespace ProgrammingConstruct
{
    class Program
    {
        public static void Main(string[] args)
        {            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option To Perform,\n1.Check Number are Equal or Not\n2.Check Numbers are Even or Odd\n3.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                IfElseProblems problem = new IfElseProblems();
                switch (option)
                {
                    case 1:
                        problem.CheckIntegersEqualOrNot();
                        break;
                        case 2:
                        problem.CheckNumIsEvenOdd();
                        break;
                        case 3:
                        flag=false;
                        break;
                }
            }          
        }
    }
}
