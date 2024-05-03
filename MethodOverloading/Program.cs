namespace MethodOverloading
{
    public class Program
    {
        //method #1
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        // method #2
        public static decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        // method #3
        public static string Add(int number1, int number2, bool dollar)
        {
            var sum = number1 + number2;

            if (dollar == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (dollar == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (dollar == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            // method #1
            Console.WriteLine("This method will add two integerse. Please enter the first nunmber below:");
            var userInput1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number below:");
            var userInput2 = int.Parse(Console.ReadLine()); 

            var userSum1 = Add(userInput1, userInput2);
            Console.WriteLine($"{userInput1} + {userInput2} = {userSum1}");

            // method #2
            Console.WriteLine("This method will add two decimals. Please enter the first number below:");
            var userInput3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter a second number below:");
            var userInput4 = Convert.ToDecimal(Console.ReadLine());

            var userSum2 = Add(userInput3, userInput4);
            Console.WriteLine($"{userInput3} + {userInput4} = {userSum2}");

            // method #3
            Console.WriteLine("This method will add two dollar amounts ONLY if you answer a question correctly at the end of this survey. Please enter the first number below:");
            var userInput5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            var userInput6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please answer the following question.\nDo you like the new Fallout tv show that recently came out? (Yes/No)");
            var userSum3 = Add(userInput5, userInput6);
            var yesOrNo = (Console.ReadLine());
            if (yesOrNo.ToLower() == "yes")
            {
                
                bool yesOrNoBool = true;
                Console.WriteLine($"Great! I enjoyed the show too! Here is the sum of those dollar amounts you input earlier:\n" + Add(userInput5,userInput6,yesOrNoBool));
            }
            else if (yesOrNo.ToLower() == "no")
            {
                bool yesOrNoBool = false;
                Console.WriteLine("Sorry you didn't like the show. Unforunately, now I won't add those integers for you.");
            }
            else
            {
                Console.WriteLine($"I'm sorry, '{yesOrNo}' is not a valid answer.");
            }
        }
    }
}
