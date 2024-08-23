using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Model
{
    public class ProgramList
    {
        public ObservableCollection<Show> Shows { get; set; }

    }
}