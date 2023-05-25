using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSVProgram.CSVInvestigation
{
    public class Datum
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<string> Jobs { get; set; }
    }

    public class Root
    {
        public List<Datum> Data { get; set; }
        public List<Skill> Skills { get; set; }
    }

    public class Skill
    {
        public string Web { get; set; }
        public string Mobile { get; set; }
    }

    public class ReadingDataFromjsonfile
    {
        static void Main(string[] args)
        {
            string link = @"C:\Users\Sai Jyothi\Desktop\Data.json";
            WebRequest request =  WebRequest.Create(link);
            WebResponse response=request.GetResponse();

            using(Stream datastream= response.GetResponseStream())
            {
                StreamReader reader=new StreamReader(datastream);

                string responseFromServer=reader.ReadToEnd();

                Root root=JsonConvert.DeserializeObject<Root>(responseFromServer);

                foreach(Datum d in root.Data)
                    {
                    Console.WriteLine(d.Name+" "+d.Surname+",Age:"+d.Age+",he work as:");
                    
                    for(int i=0;i<d.Jobs.Count;i++)
                    {
                        Console.WriteLine(d.Jobs[i]);
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
