using System;

namespace Lab01_numbers_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Numbers Game";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Burns";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            try
            {
                StartSequence();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                Console.Write("Program complete.");
            }

        }

        static void StartSequence()
        {
            //get a number
            Console.WriteLine("Enter a number greater than zero");
            string inputStr = Console.ReadLine();
            int inputVal;
            inputVal = Convert.ToInt32(inputStr);

            //int arr instance
            int[] intArr = new int[inputVal];
            //populate
            intArr = Populate(intArr);

            int sum = 0;
            sum = GetSum(intArr);

            int product = 0;
            product = GetProduct(intArr, sum);

            decimal quotient = 0;
            quotient = GetQuotient(product);

            Console.WriteLine($"your array size is {intArr.Length}");

            Console.Write("The numbers of your array are ");
            foreach (var item in intArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"The sum of the array is {sum}");

            Console.WriteLine($"{sum} * {product / sum} = {product}");
            Console.WriteLine($"{product} / {product/quotient} = {quotient}");

        }

        static int[] Populate(int[] intArr)
        {

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write("Please enter number {0} of {1}:", i + 1, intArr.Length);
                string inputStr = Console.ReadLine();
                int inputVal;
                inputVal = Convert.ToInt32(inputStr);
                intArr[i] = inputVal;

            }

            return intArr;

        }
        static int GetSum(int[] intArr)
        {
            int sum = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                sum += intArr[i];
            }

            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");
            }
            return sum;
        }

        static int GetProduct(int[] intArr, int sum)
        {
            Console.WriteLine("Please select a random number between 1 and {0}", intArr.Length);

            string inputStr = Console.ReadLine();
            int inputVal;
            inputVal = (Convert.ToInt32(inputStr)-1);

            int product = intArr[inputVal] * sum;

            return product;
        }

        static decimal GetQuotient(int product)
        {

            Console.WriteLine("Please enter a number to divide your product {0} by", product);

            decimal decProduct = Convert.ToDecimal(product);

            string inputStr = Console.ReadLine();
            decimal inputVal;
            inputVal = Convert.ToInt32(inputStr);
            decimal quotient = 0;

            try
            {
                quotient = decimal.Divide(decProduct, inputVal);
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
            }
  
            return quotient;

        }
    }
}
