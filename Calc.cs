using System;




namespace Calculator.Calculating
{
    class Calc : Program
    {
        //method that adds
        public static void Add()
        {
            decimal num1;
            decimal num2;

            Console.WriteLine("Pick the first number you would like to add.");
            num1 = GetNum();
            Console.WriteLine("Pick the second number you would like to add");
            num2 = GetNum();

            decimal aAdd = num1 + num2;
            Console.WriteLine($"Your answer is: {num1} + {num2} = {aAdd}");

            Console.WriteLine("If you would like to restart the calculator, type \"y\". If you would like to end the calculator type \"n\" ");
            string restart = Console.ReadLine();
            if (restart.ToLower() == "y")
            {
                Console.Clear();
                Console.Beep();
            }
            else if (restart.ToLower() == "n")
            {
                Environment.Exit(0);
            }
        }

        //method that takes away
        public static void Minus()
        {
            decimal num1;
            decimal num2;

            Console.WriteLine("Pick the first number you would like to subtract.");
            num1 = GetNum();
            Console.WriteLine("Pick the second number you would like to add");
            num2 = GetNum();

            decimal aMinus = num1 - num2;
            Console.WriteLine($"Your answer is: {num1} - {num2} = {aMinus}");

            Console.WriteLine("If you would like to restart the calculator, type \"y\". If you would like to end the calculator type \"n\" ");
            string restart = Console.ReadLine();
            if (restart.ToLower() == "y")
            {
                Console.Clear();
                Console.Beep();
            }
            else if (restart.ToLower() == "n")
            {
                Environment.Exit(0);
            }
        }

        //method that multiplies
        public static void Times()
        {
            decimal num1;
            decimal num2;

            Console.WriteLine("Pick the first number you would like to multiply.");
            num1 = GetNum();
            Console.WriteLine("Pick the second number you would like to multiply");
            num2 = GetNum();

            decimal aTimes = num1 * num2;
            Console.WriteLine($"Your answer is:  {num1} * {num2} = {aTimes}");

            Console.WriteLine("If you would like to restart the calculator, type \"y\". If you would like to end the calculator type \"n\" ");
            string restart = Console.ReadLine();
            if (restart.ToLower() == "y")
            {
                Console.Clear();
                Console.Beep();
            }
            else if (restart.ToLower() == "n")
            {
                Environment.Exit(0);
            }
        }

        //method that divides
        public static void Divide()
        {
            decimal num1;
            decimal num2;

            Console.WriteLine("Pick the first number you would like to divide.");
            num1 = GetNum();
            Console.WriteLine("Pick the second number you would like to divide");
            num2 = GetNum();

            decimal aDivide = num1 / num2;
            Console.WriteLine($"Your answer is: {num1} / {num2} = {aDivide}");

            Console.WriteLine("If you would like to restart the calculator, type \"y\". If you would like to end the calculator type \"n\" ");
            string restart = Console.ReadLine();
            if (restart.ToLower() == "y")
            {
                Console.Clear();
                Console.Beep();
            }
            else if (restart.ToLower() == "n")
            {
                Environment.Exit(0);
            }
        }

        //method that makes sure the user is passing a decimal value into the console, otherwise to try again.
        public static decimal GetNum()
        {
            decimal num;
            
            bool parseCheck = Decimal.TryParse(Console.ReadLine(), out num);
            while (!parseCheck)
            {
                Console.WriteLine("Try again with numbers.");
                parseCheck = Decimal.TryParse(Console.ReadLine(), out num);
            }
            return num;

        }


            public static void UserOut()
            {
            
                bool keepRunning = true;

                while (keepRunning == true)
                {

                    Console.WriteLine("This is a calculator. \n....................... \nWould you like to multiply(*), divide(/), add(+) or subtract(-)? \n ....................... \nPlease press enter after each of your choices.");
                    string opAnswer = Console.ReadLine();

                    switch (opAnswer)
                    {
                        case "*":
                            Times();
                            break;

                        case "/":
                            Divide();
                            break;

                        case "+":
                            Add();
                            break;

                        case "-":
                            Minus();
                            break;

                        default:
                            Console.WriteLine("Please pick a suitable operator");

                            break;

                    }
                       

                }

            }

    }
}
