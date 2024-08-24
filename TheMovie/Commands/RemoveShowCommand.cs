using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMovies.ViewModel;

namespace TheMovies.Commands
{
    internal class RemoveShowCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            //For testing purposes only
            if (parameter is MainViewModel mvm)
            {
                if (mvm.lsSelectedIndex >= 0)
                {
                    mvm.MovieRepo.RemoveMovie(mvm.lsSelectedIndex);
                }
            }
        }
    }
}
