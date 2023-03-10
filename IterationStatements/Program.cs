namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintAll()

        {
            for (int x = 1000; x >= -1000; x--)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("End of numerals from 1000 to -1000, program init complete.");
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void TripleUp()
        {

            for (int y = 3; y <= 999; y += 3)
            {

                Console.WriteLine(y);
            }

        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void NumCheck(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("These numbers match and are equal.");
            }
            else
            {
                Console.WriteLine("These numbers do not match and are not equal");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenCheck(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("This is an even number.");
            }
            else
            {
                Console.WriteLine("This is an odd number.");
            }

        }

        //Write a method to check whether a given number is positive or negative

        public static void PosNeg(int num3)
        {

            if (num3 > 0)
            {
                Console.WriteLine("Above zero is always a good thing!");
            }
            else
            {
                Console.WriteLine("Please make sure you're staying warm!");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void VoteCheck(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"You're eligible to vote!");
                
            }
            else
            {
                Console.WriteLine("You're ineligible to vote at your current age.");
                
            }
        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void RangeCheck(int num3)
        {
            if ((num3 >= -10) && (num3 <= 10))
            {                 
                Console.WriteLine("Gosh that's cold!");
            }

            else
            {
                Console.WriteLine("You're probably comfy!");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void DisplayTable(int tableNumber)
        {
            for (int z = 0; z <= 12; z++)
            {
                int printNumber = tableNumber * z;
                Console.WriteLine($"{printNumber}") ;
            }



        }



        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            int ageInput;
            string? userInput;
            int num1;
            int num2;
            int degrees;
            int tableNumber;



            //init start with userInput

            Console.WriteLine("Would you like to begin the program by running the numeral counter?");
            userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                PrintAll();
            }

            else
            {
                Console.WriteLine("Please restart the program when you're ready.");
            }

            //next function + 3s sleep

            Console.WriteLine("Multiples of 3 running now.");
            Thread.Sleep(3000);

            TripleUp();

            //next function, userInput

            Console.WriteLine("Please define two integers to check if they are equal.");

            Thread.Sleep(1500);

                Console.WriteLine("First integer:");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Second integer:");
                num2 = int.Parse(Console.ReadLine());

            //method call for userInput

            NumCheck(num1, num2);


            Thread.Sleep(1500);
            Console.WriteLine("We'll now determine if the first number is even or odd.");

            Thread.Sleep(1500);
            EvenCheck(num1);

            Thread.Sleep(1500);

            Console.WriteLine("What's the current temperature in degrees celsius right now?");
            degrees = int.Parse(Console.ReadLine());

            PosNeg(degrees);

            // utilizing the same userInput for both method calls, I could make another variable
            // but this makes more sense for the application.
            Thread.Sleep(1500);

            RangeCheck(degrees);

            Thread.Sleep(1500);

            Console.WriteLine("We'll now determine your voting eligibility based on age. How old are you?");
            ageInput = int.Parse(Console.ReadLine());

            VoteCheck(ageInput);

            Thread.Sleep(1500);

            Console.WriteLine("Lastly, we'll display a quick multiplication table to assist in any calculations you may have.\n" +
                "Please give us a number.");

            tableNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Generating multiplication table.");

            Thread.Sleep(1500);

            DisplayTable(tableNumber);







            }
            
            
        }


    }
