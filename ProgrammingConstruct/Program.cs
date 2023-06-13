namespace ProgrammingConstruct
{
    class Program
    {
        public static void Main(string[] args)
        {            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option To Perform,\n1.Check Number are Equal or Not\n2.Check Numbers are Even or Odd\n3.To Check Vote Eligiblity\n4.Exit");
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
                        Console.WriteLine("Enter Age Number To Check Eligiblity to Vote");
                        int age=Convert.ToInt32(Console.ReadLine());
                        problem.CheckAgeEligiblity(age);
                        break;
                        case 4:
                        flag=false;
                        break;
                }
            }          
        }
    }
}
