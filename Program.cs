using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace EC_Review_Sofa_Option
{
    internal class Program
    {
        static string[] colors;
        static int[] softness;
        static int[] priceRanges;

        static void Main(string[] args)
        {
            int size = 20;
            GenerateSofaDatabase(size);
            DisplaySofaDatabase();

            //Console.WriteLine("Enter a color");
            //string userColor = Console.ReadLine();

            //Console.WriteLine("Max Softness");
            //int userSoft = int.Parse(Console.ReadLine());

            //Console.WriteLine("Max Price");
            //int max = int.Parse(Console.ReadLine());

       


            Console.WriteLine("Sofas that fit your criteria");

            for (int i = 0; i < size; i++)
            {
                string color = colors[i].ToLower();
                int soft = softness[i];
                int price = priceRanges[i];

                if ((color == "red" || color == "blue") && // Red OR Blue
                (soft >= 1 && soft <= 5) && // Between 1 AND 5
                (price >= 500 && price <= 1000))
                {
                    Console.WriteLine($"{i} - {color} - {soft} - {price}");
                }// Between 500 AND 1000
            }


            // What is the question being asked

            //Console.WriteLine("What color sofa would you like? red/blue: ");
            //string usercolor = Console.ReadLine();
            //int[] softness = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] priceranges = { 500, 600, 650, 700, 750, 800, 850, 900, 950, 1000 };

            //for (int i = 0; i < priceranges.Length; i++)
            //{
            //    if (softness[i] >= 1 && softness[i] <= 5)
            //    {
            //        string color = usercolor;
            //        int pricerange = priceranges[i];
            //        int softness2 = softness[i];
            //        string formattedString = $"Color:{color} - Softness:{softness2} - ${pricerange}";
            //        Console.WriteLine(formattedString);
            //    }
            //}

            //Lets say I want a
            //sofa that is either red or blue in color,
            //has a softness rating of medium to soft
            //( if 10 was hard 5 medium and 1 the softess ), and the
            //price can be between 500 to 1000 dollars... 

            // color red or blue
            // softness between 5 and 1 | medium to soft
            // price 500 to 1000

            // If the sofa color is Between red or blue
            // color <--- 
            // if color == "red" 
            // color == "blue"

            // Benel
            // if(color == "red")
            // else if (color == "blue")
            // else don't buy

            // if( color == "red" || color == "blue")

            // ----------------------
            // softness between 1 and 5 | medium to soft
            // softness >= 1 

            // > greater than 
            // number != 5 
            // -3 -2 -1 0 1 2 3 4 5 6 7 8 9 . . .
            // < less than
            // >= greater than or equal
            // <= less than or equal
            // == equals
            // != does not equal

            // -3 -2 -1 0 1 2 3 4 5 6 7 8
            // softness >= 1 && softness <= 5
            // is there something like python: x = range(1,6)


            // AND the softness is between 1 to 5
            // AND the price is between 500 to 1000
            // price >= 500 && price <= 1000
            // I will buy is

            // C#
            // if ()

            // if( (color == "red" || color == "blue") && // Red OR Blue
            // (softness >= 1 && softness <= 5) && // Between 1 AND 5
            // (price >= 500 && price <= 1000) ) // Between 500 AND 1000

        } // Main


        // -------------------------------------

        // Generate Sofa Database code

        #region


        
        public static void DisplaySofaDatabase()
        {

            Console.WriteLine($"__|\tColor\tSoftness\tPrice");

            for (int i = 0; i < colors.Length; i++)
            {
                string number = i.ToString();
                string color = colors[i];
                string soft = softness[i].ToString();
                string price = priceRanges[i].ToString("c");
                string formatted = $"{number} :\t {color}\t {soft}\t {price}";

                Console.WriteLine($"{formatted}");
            }


        } // DisplaySofaDatabase()

        public static void GenerateSofaDatabase(int size)
        {
            string[] colorSelection = { "Red", "Green", "Blue", "Yellow", "Orange", "Purple", "Pink" };

            colors = new string[size];
            softness = new int[size];
            priceRanges = new int[size];

            Random rand = new Random();

            // rand.Next() - 0 and int.Max
            // rand.Next(10) - 0 and 9
            // rand.Next(-5, 30) - -5 to 29

            // rand.Next(5); 0 1 2 3 4
            for (int i = 0; i < colors.Length; i++)
            {
                int chosenColor = rand.Next(colorSelection.Length);
                // 
                colors[i] = colorSelection[chosenColor];
                softness[i] = rand.Next(1, 11);
                priceRanges[i] = rand.Next(100, 1501);
            }
        } // GenerateSofaDatabase

        #endregion
    } // class

} // namespace