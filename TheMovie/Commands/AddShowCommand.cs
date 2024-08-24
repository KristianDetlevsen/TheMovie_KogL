using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMovies.Model;
using TheMovies.ViewModel;

namespace TheMovies.Commands
{
    internal class AddShowCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {         
            if (parameter is MainViewModel mvm)
            {
                string movieTitle = mvm.SelectedMovie.Split(',')[0];
                mvm.ShowRepo.AddShow(new Show(mvm.SelectedCinema, mvm.SelectedRoom, movieTitle, "24/08/24 21:00:00", "2 timer"));
            }
        }
    }
}
