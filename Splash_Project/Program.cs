using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Splash_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables to hold filepath to CSV
            string startingData;
            string jan;
            string feb;
            string mar;

            //Assign filepath to variables
            startingData = @"C:\Users\Dan\Documents\Visual Studio 2015\Projects\Splash_Project\Splash_Project\CSV\StartingData.csv";
            jan = @"C:\Users\Dan\Documents\Visual Studio 2015\Projects\Splash_Project\Splash_Project\CSV\Jan.csv";
            feb = @"C:\Users\Dan\Documents\Visual Studio 2015\Projects\Splash_Project\Splash_Project\CSV\Feb.csv";
            mar = @"C:\Users\Dan\Documents\Visual Studio 2015\Projects\Splash_Project\Splash_Project\CSV\Mar.csv";

            //Importing StartingData CSV and separating into separate lists
            var userID = new List<string>();
            var amount = new List<string>();
            var program = new List<string>();
            using (var rd = new StreamReader(startingData))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(',');
                    userID.Add(splits[0]);
                    amount.Add(splits[1]);
                    program.Add(splits[2]);
                }
            }

            /*
            // Print User Info
            Console.WriteLine("Column 1:");
            foreach (var element in userID)
                Console.WriteLine(element);

            // Print Amount
            Console.WriteLine("Column 2:");
            foreach (var element in amount)
                Console.WriteLine(element);

            // Print Program
            Console.WriteLine("Column 3:");
            foreach (var element in program)
                Console.WriteLine(element);
            */

            //January Data Set
            var date = new List<string>();
            var janID = new List<string>();
            var janAmount = new List<string>();
            using (var rd = new StreamReader(jan))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(',');
                    date.Add(splits[0]);
                    janID.Add(splits[1]);
                    janAmount.Add(splits[2]);
                }
            }
            // Print User Info
            Console.WriteLine("Column 1:");
            foreach (var element in date)
                Console.WriteLine(element);

            // Print Amount
            Console.WriteLine("Column 2:");
            foreach (var element in janID)
                Console.WriteLine(element);

            // Print Program
            Console.WriteLine("Column 3:");
            foreach (var element in janAmount)
                Console.WriteLine(element);




            Console.ReadLine();
        }
    }
}
