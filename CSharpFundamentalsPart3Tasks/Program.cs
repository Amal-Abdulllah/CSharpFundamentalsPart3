namespace CSharpFundamentalsPart3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Fundamentals Part 3 Tasks");
            Console.WriteLine("Choose task number from 1 to 12:");
            Console.WriteLine("1 - Absolute Difference");
            Console.WriteLine("2 - Power and Root Explorer");
            Console.WriteLine("3 - Name Formatter");
            Console.WriteLine("4 - Subscription End Date");
            Console.WriteLine("5 - Grade Rounding System");
            Console.WriteLine("6 - Password Strength Checker");
            Console.WriteLine("7 - Clean Name Comparator");
            Console.WriteLine("8 - Membership Expiry Checker");
            Console.WriteLine("9 - Round Up / Round Down Explorer");
            Console.WriteLine("10 - Word Position Finder");
            Console.WriteLine("11 - OTP Generator");
            Console.WriteLine("12 - Birthday Insights");

            Console.Write("Enter task number: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());

            switch(tasknumber)
            {
                case 1: 
                  // absolute diffrence(task 1) 

            Console.Write("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double difference = number1 - number2;
            double positiveDifference = Math.Abs(difference);

            Console.WriteLine("Positive difference: " + positiveDifference);
            break;

                case 2:

            // power and root explorer( task 2) 


            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine() ?? "";


            string upperName = fullName.ToUpper();
            string lowerName = fullName.ToLower();
            int characterCount = fullName.Length;

            Console.WriteLine("Uppercase: " + upperName);
            Console.WriteLine("Lowercase: " + lowerName);
            Console.WriteLine("Number of characters: " + characterCount);
            break;

                case 3:
            // name formatter(task 3) 

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine() ?? "";

            string upperName = fullName.ToUpper();
            string lowerName = fullName.ToLower();
            int characterCount = fullName.Length;

            Console.WriteLine("Uppercase: " + upperName);
            Console.WriteLine("Lowercase: " + lowerName);
            Console.WriteLine("Number of characters: " + characterCount);
            break;

                case 4:
                    // subscribtion end date (task4)

                    Console.Write("Enter number of free trial days: ");
                    int trialDays = Convert.ToInt32(Console.ReadLine());

                    DateTime startDate = DateTime.Today;
                    DateTime endDate = startDate.AddDays(trialDays);

                    Console.WriteLine("Trial ends on: " + endDate.ToString("yyyy-MM-dd"));
                    break;

                case 5:
                    // grade grounding system (task 5) 
                    Console.Write("enter your raw marks score:");
                    double roundedScore = Math.Round(rawScore, 0);
                    if (roundedScore >= 60)
                    {
                        Console.WriteLine("Result: Pass");
                    }
                    else
                    {
                        Console.WriteLine("Result: Fail");
                    }
                    break;

            }


        }

    }
    
}
