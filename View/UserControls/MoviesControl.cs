using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.UserControls
{
    public partial class MoviesControl : UserControl
    {
        private static Movie[] _movies = null;
        private static Movie _currentMovie = null;
        public MoviesControl()
        {
            InitializeComponent();
            _movies = GetRandomMovies(5);
            InitListBoxMovies(5);
        }
        static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }

        private Movie[] GetRandomMovies(int size)
        {
            Movie[] myMovies = new Movie[size];
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                myMovies[i] = new Movie();
                myMovies[i].Rating = ran.NextDouble() + ran.Next(0, 9);
                myMovies[i].YearOfRelease = ran.Next(1900, DateTime.Now.Year);
                myMovies[i].Duration = ran.Next(100, 200);
                myMovies[i].Name = "<title>";
                myMovies[i].GenreOfMovie = Genre.Blokbuster;
            }
            return myMovies;
        }

        private void InitListBoxMovies(int count)
        {
            for (int i = 0; i < count; i++)
            {
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
        }

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MovieNameTextBox.BackColor = System.Drawing.Color.White;
                string Name = MovieNameTextBox.Text;
                _currentMovie.Name = Name;
            }
            catch (Exception)
            {
                MovieNameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = System.Drawing.Color.White;
                int Duration = int.Parse(DurationTextBox.Text);
                _currentMovie.Duration = Duration;
            }
            catch (Exception)
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.White;
                int Release = int.Parse(ReleaseYearTextBox.Text);
                _currentMovie.YearOfRelease = Release;
            }
            catch (Exception)
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            string genre = MovieGenreTextBox.Text;
            if (TryGetEnumValue(genre, out Genre value))
            {
                _currentMovie.GenreOfMovie = value;
                MovieGenreTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                MovieGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingTextBox.BackColor = System.Drawing.Color.White;
                double Rating = double.Parse(RatingTextBox.Text);
                _currentMovie.Rating = Rating;
            }
            catch (Exception)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindFilmWithMaxRating(Movie[] movies)
        {
            double maxRating = movies[0].Rating;
            int maxRatingIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void SearchMovieButton_Click(object sender, EventArgs e)
        {
            int movieMaxRatingIndex = FindFilmWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = movieMaxRatingIndex;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieNameTextBox.Clear();
            DurationTextBox.Clear();
            ReleaseYearTextBox.Clear();
            MovieGenreTextBox.Clear();
            RatingTextBox.Clear();
            if (MoviesListBox.SelectedItem == null) { return; }
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            MovieNameTextBox.Text = _currentMovie.Name.ToString();
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            ReleaseYearTextBox.Text = _currentMovie.YearOfRelease.ToString();
            MovieGenreTextBox.Text = _currentMovie.GenreOfMovie.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }
    }
}
