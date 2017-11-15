using Assignment3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string u1 = @"ml-100k/u1.base";
            string u1test = @"ml-100k/u1.test";

            List<Entry> u1List = Reader.FileReader(u1);
            List<Entry> u1testList = Reader.FileReader(u1test);

            foreach (Entry item in u1List)
            {
                foreach (Entry item2 in u1testList)
                {
                    if (item.User == item2.User && item.Movie == item2.Movie)
                    {
                        item2.Rating = item.Rating;
                        u1List.Remove(item);
                    }
                }
            }
        }
    }
}
