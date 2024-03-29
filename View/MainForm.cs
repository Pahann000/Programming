using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {
        Rectangle[] _rectangles = new Rectangle[5];
        Rectangle _currentRectangle;
        Movie[] _movies = new Movie[5];
        Movie _currentMovie;
        public MainForm()
        {
            InitializeComponent();
            object[] SeasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(SeasonValues);
            Random random = new Random();
            string[] movieTitles = new string[5] { "Green Mile", "Dune", "The Dark Knight", "Drive", "Terminator" };
            for (int i = 0; i < 5; i++)
            {
                Rectangle rectangle = new Rectangle(Math.Round((random.NextDouble() * 10), 2), Math.Round((random.NextDouble() * 10), 2), Colors.Red, 0, 0);
                _rectangles[i] = rectangle;
            }
            RectangleListBox.Items.AddRange(_rectangles);
            for (int i = 0; i < 5; i++)
            {
                Movie movie = new Movie(movieTitles[i], random.Next(60, 300), random.Next(1900, 2025), Genre.Horror, Math.Round((random.NextDouble()*10), 1));
                _movies[i] = movie;
            }
            MoviesListBox.Items.AddRange(_movies);
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
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double MaxWidth = rectangles[0].RectangleWidth;
            int MaxWidthIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].RectangleWidth > MaxWidth)
                {
                    MaxWidth = rectangles[i].RectangleWidth;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;

        }
        private void PopulateSecondListBox<T>()
        {
            Type enumType = typeof(T);
            foreach (var item in Enum.GetValues(enumType))
            {
                ValuesListBox.Items.Add(item);
            }
        }
        public void WeekdayParsing(object sender, EventArgs e)
        {
            Weekday weekday;
            var userDay = WeekdayTextBox.Text;
            int examination;
            bool isInt;
            if (!string.IsNullOrEmpty(userDay))
            {
                if (Enum.TryParse(userDay, out weekday))
                {
                    WeekdayLabel.Text = $"Этот день недели ({weekday} ={(int)weekday})";
                }
                else
                {
                    WeekdayLabel.Text = "Нет такого дня недели";
                }
                isInt = int.TryParse(userDay, out examination);
                if (isInt)
                {
                    WeekdayLabel.Text = "Введите название дня текстом.";
                }
            }
            else
            {
                MessageBox.Show("Введите день для проверки");
            }
        }
        public void SeasonMoves(object sender, EventArgs e)
        {
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Бррр, холодно");
                    break;
                case 1:
                    enumsPage.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case 2:
                    MessageBox.Show("Ура!Солнце!");
                    break;
                case 3:
                    enumsPage.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:
                    PopulateSecondListBox<Colors>();
                    break;
                case 1:
                    PopulateSecondListBox<EducationForm>();
                    break;
                case 2:
                    PopulateSecondListBox<Genre>();
                    break;
                case 3:
                    PopulateSecondListBox<Manufactures>();
                    break;
                case 4:
                    PopulateSecondListBox<Season>();
                    break;
                case 5:
                    PopulateSecondListBox<Weekday>();
                    break;
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexTextBox.Clear();
            IndexTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WidthTextBox.Clear();
            LengthTextBox.Clear();
            ColorTextBox.Clear();
            if (RectangleListBox.SelectedIndex == null) { return; }
            Rectangle rectangle = (Rectangle)RectangleListBox.SelectedItem;
            _currentRectangle = rectangle;
            WidthTextBox.Text = _currentRectangle.RectangleWidth.ToString();
            LengthTextBox.Text = _currentRectangle.RectangleLength.ToString();
            ColorTextBox.Text = _currentRectangle.RectangleColor.ToString();
            RectangleCenterXCoordinatesTextBox.Text = _currentRectangle.CenterOfRectangle.Y.ToString();
            RectangleCenterYCoordinatesTextBox.Text = _currentRectangle.CenterOfRectangle.X.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();   
        }
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LengthTextBox.BackColor = System.Drawing.Color.White;
                double RectangleLength = double.Parse(LengthTextBox.Text);
                _currentRectangle.RectangleLength = RectangleLength;
            }
            catch (Exception)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                double RectangleWidth = double.Parse(WidthTextBox.Text);
                _currentRectangle.RectangleWidth = RectangleWidth;
            }
            catch (Exception)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {

            if (_currentRectangle == null) return;
            if (TryGetEnumValue(ColorTextBox.Text, out Colors value))
            {
                _currentRectangle.RectangleColor = value;
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
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


        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int rectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = rectangleMaxWidthIndex;

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
            _currentMovie = (Movie)MoviesListBox.SelectedItem;
            MovieNameTextBox.Text = _currentMovie.Name.ToString();
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            ReleaseYearTextBox.Text = _currentMovie.YearOfRelease.ToString();
            MovieGenreTextBox.Text = _currentMovie.GenreOfMovie.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }
    }
}