using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //Import CSV data into Visual Studio
            List<string> startList = File.ReadAllLines(startingData).ToList();
            List<string> janList = File.ReadAllLines(jan).ToList();
            List<string> febList = File.ReadAllLines(feb).ToList();
            List<string> marList = File.ReadAllLines(mar).ToList();
        }
    }
}
