using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Model;

namespace TheMovies.Persistence
{
    public class ShowRepository
    {
        public ObservableCollection<Show> Shows { get; set; }

        public ShowRepository()
        {
            Shows = new ObservableCollection<Show>();
        }

        public void AddShow(Show show)
        {
            Shows.Add(show);
        }

        public void RemoveShow(int index)
        {
            Shows.Remove(Shows[index]);
        }

        public void UpdateShow(Show show)
        {

        }
    }
}