using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment3.Classes
{
    class Reader
    {
        public static List<Entry> FileReader(string path)
        {
            
            List<Entry> entryList = new List<Entry>();
            
            using (StreamReader r = new StreamReader(path))
            {
                while (!r.EndOfStream)
                {
                    string[] line = Console.ReadLine().Split('\t');
                    entryList.Add(new Entry(Convert.ToInt32(line[0]), Convert.ToInt32(line[1]), Convert.ToInt32(line[2]), Convert.ToInt32(line[3])));
                }
            }
            return entryList;
}
        

    }
}
