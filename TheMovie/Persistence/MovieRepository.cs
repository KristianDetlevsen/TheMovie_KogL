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
    public class MovieRepository
    {
        public ObservableCollection<Movie> Movies { get; set; }

        public MovieRepository()
        {
            Movies = new ObservableCollection<Movie>();
            
            //Added movies for testing purposes

            Movies.Add(new Movie("Gladiator", "2 timer", "Eventyr"));
            Movies.Add(new Movie("Ringenes Herre", "4 timer", "Fantasy"));
            Movies.Add(new Movie("Inceptioin", "2 timer", "Sci-fi"));
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void RemoveMovie(int index)
        {
            Movies.Remove(Movies[index]);
        }

        public void UpdateMovie(Movie movie)
        {
            //implementation
        }

        public void AddMoviesFromList(string filename)
        {
            //Commented out for testing purposes

            //StreamReader sr = new StreamReader(filename);
            //string line = sr.ReadLine();
            //while (line != null)
            //{
            //    int pack = 0;
            //    string[] words = line.Split(';');
            //    AddMovie(new Movie(words[3], words[5], words[4]));

            //    line = sr.ReadLine();
            //}
            //sr.Close();
        }
    }
}
