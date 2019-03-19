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
            //Console.WriteLine("Enter a number greater than zero");
            //string inputStr = Console.ReadLine();
            //int inputVal;
            //inputVal = Convert.ToInt32(inputStr);

            //int[] intArr = new int[inputVal];

            //int[] population = Populate(intArr);
            //int sum = GetSum(population);
        }

        static int[] Populate(int[] intArr)
        {

            //for (int i = 0 ; i < intArr.Length ; i ++){
            //    Console.Write("Please enter number {0} of {1}:", i + 1, intArr.Length);
            //    string inputStr = Console.ReadLine();
            //    int inputVal;
            //    inputVal = Convert.ToInt32(inputStr);
            //    intArr[i] = inputVal;

            //    return intArr;
            //}

        }
        static void GetSum(int[] intArr)
        {
            //int sum = 0;
            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    sum += intArr[i];
            //}
            //GetProduct(intArr, sum);

        static void GetProduct(int[] intArr, int sum)
        {
            //Console.WriteLine("Please select a random number between 1 and {0}", intArr.Length);
            //string inputStr = Console.ReadLine();
            //int inputVal;
            //inputVal = Convert.ToInt32(inputStr);
            //int product = intArr[inputVal] * sum;

            //GetQuotient(product);
        }

        static void GetQuotient(int product)
        {
            //Console.WriteLine("Please enter a number to divide your product {0} by", product);
            //string inputStr = Console.ReadLine();
            //int inputVal;
            //inputVal = Convert.ToInt32(inputStr);

            

        }
}
