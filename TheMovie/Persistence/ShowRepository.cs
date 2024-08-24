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
            //Needs implementation
        }
        public void AddShowsFromList(string filename)
        {          
            StreamReader sr = new StreamReader(filename);
            
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] words = line.Split(';');
                AddShow(new Show(words[0], "1", words[3], words[2], words[5]));

                line = sr.ReadLine();
            }

            sr.Close();
        }
    }
}