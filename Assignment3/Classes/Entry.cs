using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Classes
{
    class Entry
    {
        public Entry (int user, int movie, int rating, int id)
        {
            this.User= user;
            int _movie = movie;
            int _rating = rating;
            int _id = id;
        }

        int user;
        int movie;
        int rating;
        int id;
      
        public int User { get => user; set => user = value; }
        public int Movie { get => movie; set => movie = value; }
        public int Rating { get => rating; set => rating = value; }
        public int Id { get => id; set => id = value; }
    }
}
