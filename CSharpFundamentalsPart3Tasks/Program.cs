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

                case 6:
                    // password strength checker (task 6)

                    Console.Write("Enter a password: ");
                    string password = Console.ReadLine();

                    bool longEnough = password.Length >= 8;
                    bool containsPassword = password.ToLower().Contains("password");

                    if (longEnough && !containsPassword)
                    {
                        Console.WriteLine("Strong");
                    }
                    else
                    {
                        Console.WriteLine("Weak");

                        if (!longEnough)
                        {
                            Console.WriteLine("Reason: Password must be at least 8 characters long.");
                        }

                        if (containsPassword)
                        {
                            Console.WriteLine("Reason: Password must not contain the word password.");
                        }
                    }
                    break;

                case 7:
                    // clean name comparator (task 7)

                    Console.Write("Enter name first time: ");
                    string name1 = Console.ReadLine();

                    Console.Write("Enter name second time: ");
                    string name2 = Console.ReadLine();

                    string cleanName1 = name1.Trim().ToUpper();
                    string cleanName2 = name2.Trim().ToUpper();

                    if (cleanName1 == cleanName2)
                    {
                        Console.WriteLine("Match");
                    }
                    else
                    {
                        Console.WriteLine("No Match");
                    }
                    break;

                case 8:
                    // membership expiry checker (task 8)

                    try
                    {
                        Console.Write("Enter membership start date (yyyy-MM-dd): ");
                        DateTime membershipStartDate = DateTime.Parse(Console.ReadLine());

                        Console.Write("Enter number of valid membership days: ");
                        int validDays = Convert.ToInt32(Console.ReadLine());

                        DateTime expiryDate = membershipStartDate.AddDays(validDays);

                        Console.WriteLine("Expiry date: " + expiryDate.ToString("yyyy-MM-dd"));

                        if (expiryDate >= DateTime.Today)
                        {
                            Console.WriteLine("Membership status: Active");
                        }
                        else
                        {
                            Console.WriteLine("Membership status: Expired");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Please enter the date and days correctly.");
                    }
                    break;

                case 9:
                    // round up / round down explorer (task 9)

                    Console.Write("Enter a decimal number: ");
                    double decimalNumber = Convert.ToDouble(Console.ReadLine());

                    double nearestNumber = Math.Round(decimalNumber);
                    double roundedUp = Math.Ceiling(decimalNumber);
                    double roundedDown = Math.Floor(decimalNumber);

                    Console.WriteLine("Nearest whole number: " + nearestNumber);
                    Console.WriteLine("Always rounded up: " + roundedUp);
                    Console.WriteLine("Always rounded down: " + roundedDown);
                    break;

                case 10:
                    // word position finder (task 10)

                    Console.Write("Enter a full sentence: ");
                    string sentence = Console.ReadLine();

                    Console.Write("Enter a word to search for: ");
                    string word = Console.ReadLine();

                    if (sentence.Contains(word))
                    {
                        int firstPosition = sentence.IndexOf(word);
                        int lastPosition = sentence.LastIndexOf(word);

                        Console.WriteLine("First occurrence index: " + firstPosition);
                        Console.WriteLine("Last occurrence index: " + lastPosition);
                    }
                    else
                    {
                        Console.WriteLine("Word not found.");
                    }
                    break;

                case 11:
                    // one-time password OTP generator (task 11)

                    Random random = new Random();
                    int otp = random.Next(1000, 10000);

                    Console.WriteLine("Your OTP is: " + otp);

                    bool verified = false;
                    int attempts = 0;

                    while (attempts < 3 && verified == false)
                    {
                        try
                        {
                            Console.Write("Enter the OTP: ");
                            int userOtp = Convert.ToInt32(Console.ReadLine());

                            if (userOtp == otp)
                            {
                                Console.WriteLine("Verified");
                                verified = true;
                            }
                            else
                            {
                                attempts++;
                                Console.WriteLine("Incorrect OTP. Attempts left: " + (3 - attempts));
                            }
                        }
                        catch
                        {
                            attempts++;
                            Console.WriteLine("Invalid input. Please enter numbers only.");
                            Console.WriteLine("Attempts left: " + (3 - attempts));
                        }
                    }

                    if (verified == false)
                    {
                        Console.WriteLine("Verification Failed");
                    }
                    break;

                case 12:
                    // birthday insights (task 12)

                    try
                    {
                        Console.Write("Enter your date of birth (yyyy-MM-dd): ");
                        DateTime birthDate = DateTime.Parse(Console.ReadLine());

                        DateTime today = DateTime.Today;

                        int age = today.Year - birthDate.Year;

                        if (birthDate.Month > today.Month ||
                            birthDate.Month == today.Month && birthDate.Day > today.Day)
                        {
                            age--;
                        }

                        DayOfWeek birthWeekDay = birthDate.DayOfWeek;

                        Console.WriteLine("Age: " + age);
                        Console.WriteLine("You were born on: " + birthWeekDay);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid date. Please enter the date in yyyy-MM-dd format.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid task number.");
                    break;


            }


        }

    }
    
}
