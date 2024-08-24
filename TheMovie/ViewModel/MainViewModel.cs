﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using TheMovies.Commands;
using TheMovies.Model;
using TheMovies.Persistence;

namespace TheMovies.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private string _tbTitleText;
        private string _tbDurationText;
        private string _tbGenreText;
        private int _lsSelectedIndex;

        public string SelectedCinema { get; set; }
        public string SelectedMovie { get; set; }
        public string SelectedRoom { get; set; }

        public string tbTitleText
        {
            get => _tbTitleText;
            set
            {
                _tbTitleText = value;
                OnPropertyChanged(nameof(tbTitleText));
            }
        }

        public string tbDurationText
        {
            get => _tbDurationText;
            set
            {
                _tbDurationText = value;
                OnPropertyChanged(nameof(tbDurationText));
            }
        }

        public string tbGenreText
        {
            get => _tbGenreText;
            set
            {
                _tbGenreText = value;
                OnPropertyChanged(nameof(tbGenreText));
            }
        }

        public int lsSelectedIndex
        {
            get => _lsSelectedIndex;
            set
            {
                _lsSelectedIndex = value;
                OnPropertyChanged(nameof(lsSelectedIndex));
            }
        }

        public ObservableCollection<Movie> Movies { get; set; }

        public ObservableCollection<Cinema> Cinemas { get; set; }

        public ObservableCollection<Show> Shows { get; set; }

        public ObservableCollection<Room> Rooms { get; set; }

        public ICommand AddCmd { get; set; }
        public ICommand RemoveCmd { get; set; }
        public ICommand AddShowCmd { get; set; }
        public ICommand RemoveShowCmd { get; set; }

        public MainViewModel()
        {
            MovieRepo = new MovieRepository();
            CinemaRepo = new CinemaRepository();
            ProList = new ProgramList();
            ShowRepo = new ShowRepository();
            RoomRepo = new RoomRepository();
            MovieRepo.AddMoviesFromList("Uge33-TheMovies.csv");
            ShowRepo.AddShowsFromList("Uge33-TheMovies.csv");
            Movies = MovieRepo.Movies;
            Cinemas = CinemaRepo.Cinemas;
            //Shows = ProList.Shows;
            Shows = ShowRepo.Shows;
            Rooms = RoomRepo.Rooms;


            AddCmd = new AddCommand();
            RemoveCmd = new RemoveCommand();

            AddShowCmd = new AddShowCommand();
            RemoveShowCmd = new RemoveShowCommand();
        }

        public MovieRepository MovieRepo;
        public ProgramList ProList;
        public ShowRepository ShowRepo;
        public CinemaRepository CinemaRepo;
        public RoomRepository RoomRepo;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
