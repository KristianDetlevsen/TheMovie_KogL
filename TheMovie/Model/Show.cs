using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TheMovies.Model
{
    public class Show
    {
        public int RoomNumber { get; set; }
        public DateTime TimeOfSHow { get; set; }
        public int ShowLength { get; set; }

        public Show(int roomNumber, DateTime time, int showLength)
        {
            RoomNumber = roomNumber;
            TimeOfSHow = time;
            ShowLength = showLength;
        }
    }    
}