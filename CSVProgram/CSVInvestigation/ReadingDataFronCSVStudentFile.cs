using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVProgram.CSVInvestigation
{
    internal class ReadingDataFronCSVStudentFile
    {

        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Sai Jyothi\Desktop\CollegeData.Csv";
            try
            {
                using (StreamReader reader = new StreamReader(filepath)) ;
                {
                    string line;
                    while((line= ReadingDataFronCSVStudentFile.ReadLine())!=null)
                    {
                        Console.WriteLine(line);
                    }    
                }
            }
           catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static string? ReadLine()
        {
            throw new NotImplementedException();
        }
    }
}
