namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8; // Fix typo: Console.InputEncoding

            //Variable Declaration and Initialization
            /*Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            string ageInput = Console.ReadLine();
            Console.Write("Height (in cm): ");
            double heightInput = Convert.ToDouble(Console.ReadLine());
            Console.Write("Is student (true/false): ");
            bool isStudentInput = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Hi,my name is {name}.I'm {ageInput} years old. My height {heightInput}. Student: {isStudentInput}");*/

            //Arithmetic Operations
            /*Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            double quotient = (double)num1 / num2; // Cast to double for accurate division
            double remainder = num1 % num2;
            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");*/

            //Conditional Statements
            /* Console.Write("Age:");
             int ageInput = Convert.ToInt32(Console.ReadLine());
             if(ageInput < 18)
             {
                 Console.WriteLine("You are a minor.");
             }
             else if (ageInput >= 18 && ageInput < 65)
             {
                 Console.WriteLine("You are an adult.");
             }
             else
             {
                 Console.WriteLine("You are a senior citizen.");
             }*/
            //Switch case
            /*Console.Write("Enter your age: ");
            int ageOfUser = Convert.ToInt32(Console.ReadLine());

            switch(ageOfUser)
            {
                case < 18:
                    Console.WriteLine("You are a minor.");
                    break;
                case >= 18 and < 65:
                    Console.WriteLine("You are an adult.");
                    break;
                default:
                    Console.WriteLine("You are a senior citizen.");
                    break;
            }*/

            //Loops

            /*for(int i = 0;i <= 10; i++)
            {
                Console.WriteLine($"Current number: {i}");
            }

            Console.Write("Input string:");
            string userString = Console.ReadLine();
            int start = 0;
            int end = 5;
            while(start < end)
            {
                Console.WriteLine(userString);
                start++;
            }*/

            //Try Parse
            /*int age;
            while (true)
            {
                Console.Write("Input age:");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out age))
                    break;

                Console.WriteLine("Error Input,Please Repeat!!!");
            }*/


            //Console Calculator
            //Enter Number 1
            /* double num1;
             while (true)
             {
                 Console.Write("num1: ");
                 string num1Input = Console.ReadLine();
                 if (double.TryParse(num1Input, out num1))
                     break;

                 Console.WriteLine("Error input.Try again!!!");
             }

             //Enter Number 2
             double num2;
             while (true)
             {
                 Console.Write("num2: ");
                 string num2Input = Console.ReadLine();
                 if (double.TryParse(num2Input, out num2))
                     break;

                 Console.WriteLine("Error input.Try again!!!");
             }

             //Operator
             Console.Write("Operator(+,-,*,/): ");
             string userOper = Console.ReadLine();

             if (string.IsNullOrWhiteSpace(userOper))
             {
                 Console.WriteLine("Error Operator!");
                 return;
             }
             char userOperator = userOper[0];

             double sum=0;
             switch (userOperator)
             {
                 case '+':
                     sum = num1 + num2;
                     break;
                 case '-':
                     sum = num1 - num2;
                     break;
                 case '*':
                     sum = num1 * num2;
                     break;
                 case '/':
                     if(num2 == 0)
                     {
                         Console.WriteLine("Error division to 0.");
                         return;
                     }
                     sum = num1 / num2;
                     break;
                 default:
                     Console.WriteLine("Error");
                     return;
             }
             Console.WriteLine($"{num1} {userOperator} {num2} = {sum}");*/


            //Methods 

            /*SayHello();
            int a = SumOfTwoNum(15, 25);
            Console.WriteLine(a);
            SayHelloTo("Duman");
            int n = Square(3);
            Console.WriteLine(n);
            double num = Calculator(15, 7, '+');
            Console.WriteLine(num);
            double num2 = Calculator(15, 0, '/');
            Console.WriteLine(num2);
        }

        //Simple Method to Say Hello!
        static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        //Sum of two numbers
        static int SumOfTwoNum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        //Hello with name
        static void SayHelloTo(string s)
        {
            Console.WriteLine($"Hello {s}");
        }

        //Square of number
        static int Square(int a)
        {
            return a * a;
        }


        //Simple Calculator with methods
        static double Calculator(double a, double b, char oper)
        {
            switch (oper)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Error division to 0");
                        return 0;
                    }
                    return a / b;
                default:
                    Console.WriteLine("Error Input");
                    return 0;
            }*/


            //String
            string name = "Duman";
            Console.WriteLine(name);


            //Initials
            string fullName = "Duman Kondybay";
            string[] parts = fullName.Split(' ');
            string initials = $"{parts[0][0]}.{parts[1][0]}.";
            Console.WriteLine($"Intials {fullName}: {initials}");

            //Vowels
            string text = "Hello world";
            int count = 0;
            foreach (char c in text.ToLower())
            {
                if ("aeiouаеёиоуыэюя".Contains(c)) count++;
            }
            Console.WriteLine($"Vowels in {text}: {count}");
        }
    }
}
