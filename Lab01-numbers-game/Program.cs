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

        }

        static void Populate(int[] intArr)
        {



        }
        static void GetSum()
        {

        }

        static void GetProduct()
        {

        }

        static void GetQuotient()
        {

        }
    }
}
