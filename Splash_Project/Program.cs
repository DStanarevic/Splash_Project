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
            var janDates = new List<string>();
            var janTransactions = new List<string>();
            var janAmount = new List<string>();
            using (var rd = new StreamReader(jan))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(',');
                    janDates.Add(splits[0]);
                    janTransactions.Add(splits[1]);
                    janAmount.Add(splits[2]);
                }
            }

            //Importing February Data CSV
            var febDates = new List<string>();
            var febTransactions = new List<string>();
            var febAmount = new List<string>();
            using (var rd = new StreamReader(feb))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(',');
                    febDates.Add(splits[0]);
                    janTransactions.Add(splits[1]);
                    janAmount.Add(splits[2]);
                }
            }

            //Importing March Data CSV
            var marDates = new List<string>();
            var marTransactions = new List<string>();
            var marAmount = new List<string>();
            using (var rd = new StreamReader(mar))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(',');
                    febDates.Add(splits[0]);
                    janTransactions.Add(splits[1]);
                    janAmount.Add(splits[2]);
                }
            }
           


            /*
            Information about program 1:
   -Can avoid paying a $8 penalty per month if one of the following criteria is met:
        -deposited at least 300 per month
        -has at least 5 transactions per month
       - has at least 1200 in their account by the end of the month
       */
        
            


            // Print User Info
            Console.WriteLine("Column 1:");
            foreach (var element in janDates)
                Console.WriteLine(element);

            // Print Amount
            Console.WriteLine("Column 2:");
            foreach (var element in janTransactions)
                Console.WriteLine(element);

            // Print Program
            Console.WriteLine("Column 3:");
            foreach (var element in janAmount)
                Console.WriteLine(element);




            Console.ReadLine();
        }
    }
}
