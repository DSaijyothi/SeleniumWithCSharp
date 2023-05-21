using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.ReadingData
{
    internal class ReadingDataFromCSV
    {
        static void Main(string[] args)
        {
            String filePath= @"\C:\\Users\\Sai Jyothi\\Downloads\\Country.csv\";
            try
            {
                using StreamReader reader = new StreamReader(filePath);
                string line;
                while((line= reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();  
        }
    }
}
