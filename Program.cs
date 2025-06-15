namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // Variable Declaration and Initialization
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            string ageInput = Console.ReadLine();
            Console.Write("Height (in cm): ");
            double heightInput = Convert.ToDouble(Console.ReadLine());
            Console.Write("Is student (true/false): ");
            bool isStudentInput = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Hi, my name is {name}. I'm {ageInput} years old. My height is {heightInput}. Student: {isStudentInput}");

            // Arithmetic Operations
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            double quotient = (double)num1 / num2;
            double remainder = num1 % num2;
            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");

            // Conditional Statements
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("You are a minor.");
            else if (age >= 18 && age < 65)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are a senior citizen.");

            // Switch case
            Console.Write("Enter your age: ");
            int ageOfUser = Convert.ToInt32(Console.ReadLine());
            switch (ageOfUser)
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
            }

            // Loops
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Current number: {i}");
            }

            Console.Write("Input string: ");
            string userString = Console.ReadLine();
            int start = 0;
            int end = 5;
            while (start < end)
            {
                Console.WriteLine(userString);
                start++;
            }

            // Try Parse
            int parsedAge;
            while (true)
            {
                Console.Write("Input age: ");
                string ageInputTry = Console.ReadLine();
                if (int.TryParse(ageInputTry, out parsedAge))
                    break;
                Console.WriteLine("Error input. Please repeat!");
            }

            // Console Calculator
            double a, b;
            while (true)
            {
                Console.Write("num1: ");
                if (double.TryParse(Console.ReadLine(), out a)) break;
                Console.WriteLine("Error input. Try again!");
            }
            while (true)
            {
                Console.Write("num2: ");
                if (double.TryParse(Console.ReadLine(), out b)) break;
                Console.WriteLine("Error input. Try again!");
            }

            Console.Write("Operator (+,-,*,/): ");
            string userOper = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userOper))
            {
                Console.WriteLine("Error Operator!");
                return;
            }
            char userOperator = userOper[0];
            double result = 0;
            switch (userOperator)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Error division to 0.");
                        return;
                    }
                    result = a / b; break;
                default:
                    Console.WriteLine("Error");
                    return;
            }
            Console.WriteLine($"{a} {userOperator} {b} = {result}");

            // Strings and Methods
            string nameDemo = "Duman";
            Console.WriteLine(nameDemo);

            string fullName = "Duman Kondybay";
            string[] parts = fullName.Split(' ');
            string initials = $"{parts[0][0]}.{parts[1][0]}.";
            Console.WriteLine($"Initials {fullName}: {initials}");

            string text = "Hello world";
            int count = 0;
            foreach (char c in text.ToLower())
            {
                if ("aeiouаеёиоуыэюя".Contains(c)) count++;
            }
            Console.WriteLine($"Vowels in {text}: {count}");

            /*SayHello();
            int sumTwo = SumOfTwoNum(15, 25);
            Console.WriteLine(sumTwo);
            SayHelloTo("Duman");
            int square = Square(3);
            Console.WriteLine(square);
            double calcResult = Calculator(15, 7, '+');
            Console.WriteLine(calcResult);
            double calcZero = Calculator(15, 0, '/');
            Console.WriteLine(calcZero);*/
        }

        /*static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        static int SumOfTwoNum(int a, int b)
        {
            return a + b;
        }

        static void SayHelloTo(string s)
        {
            Console.WriteLine($"Hello {s}");
        }

        static int Square(int a)
        {
            return a * a;
        }

        static double Calculator(double a, double b, char oper)
        {
            switch (oper)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
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
            }
        }*/
    }
}