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
            
            //Assign filepath to variables
            string startingData = @"C:\Users\Dan\Documents\Visual Studio 2015\Projects\Splash_Project\Splash_Project\CSV\StartingData.csv";
            string jan = @"C:\Users\Dan\Documents\Visual Studio 2015\Projects\Splash_Project\Splash_Project\CSV\Jan.csv";
            string feb = @"C:\Users\Dan\Documents\Visual Studio 2015\Projects\Splash_Project\Splash_Project\CSV\Feb.csv";
            string mar = @"C:\Users\Dan\Documents\Visual Studio 2015\Projects\Splash_Project\Splash_Project\CSV\Mar.csv";

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

          
            //Importing January Data CSV
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

            int janIDCounter = 0;



            /*
            Information about program 1:
   -Can avoid paying a $8 penalty per month if one of the following criteria is met:
        -deposited at least 300 per month
        -has at least 5 transactions per month
       - has at least 1200 in their account by the end of the month
       */
        
            


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
