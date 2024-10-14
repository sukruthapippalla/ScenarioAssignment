using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que2
{
    public class Movie
    {
        public static string name;
        public int ticketId;
        public string seatNumber;
        public Movie ReturnMovieDetails(string name,int ticketId,string seatNumber)
        {
            Movie movie = new Movie();
            Movie.name = name;
            movie.ticketId = ticketId;
            movie.seatNumber = seatNumber;
            return movie;
        }
    }
}
