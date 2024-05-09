using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {

        private static Rectangle[] _rectangles = null;
        private static Rectangle _currentRectangle = null;
        private static Movie[] _movies = null;
        private static Movie _currentMovie = null;
        private static List<Rectangle> _newRectangle = new List<Rectangle>();
        private static Rectangle _currentNewRectangle = null;
        private static List<Panel> _rectanglePanels = new List<Panel>();
        public MainForm()
        {
            InitializeComponent();
            object[] SeasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(SeasonValues);
            Random random = new Random();
            _movies = GetRandomMovies(5);
            InitListBoxMovies(5);
            _rectangles = GetRandomRectangles(5);
            InitListBoxRectangles(5);
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
        private Rectangle[] GetRandomRectangles(int size)
        {
            Rectangle[] myRectangles = new Rectangle[size];
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                myRectangles[i] = new Rectangle();
                myRectangles[i].RectangleWidth = ran.Next(10, 200);
                myRectangles[i].RectangleHeight = ran.Next(10, 200);
                myRectangles[i].CenterOfRectangle = new Point2D(ran.Next(0, RectangleRectanglesViewPanel.Width), ran.Next(0, RectangleRectanglesViewPanel.Height));
            }

            return myRectangles;
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
        private void InitListBoxRectangles(int count)
        {
            for (int i = 0; i < count; i++)
            {
                RectangleListBox.Items.Add($"Rectangle {i + 1}");
            }
        }
        private void InitListBoxMovies(int count)
        {
            for (int i = 0; i < count; i++)
            {
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
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
            LengthTextBox.Text = _currentRectangle.RectangleHeight.ToString();
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
                _currentRectangle.RectangleHeight = RectangleLength;
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

        private void RectangleAddButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(1, RectangleRectanglesViewPanel.Width, RectangleRectanglesViewPanel.Height)[0];
            _newRectangle.Add(newRectangle);

            ListBoxNewRectangle.Items.Add($"{newRectangle.Id}. ({newRectangle.CenterOfRectangle} W = {newRectangle.RectangleWidth}; H = {newRectangle.RectangleHeight})");

            Panel newPanel = new Panel();
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.Location = new Point((int)(newRectangle.CenterOfRectangle.X - newRectangle.RectangleWidth / 2), (int)(newRectangle.CenterOfRectangle.Y - newRectangle.RectangleHeight / 2));
            newPanel.Width = (int)newRectangle.RectangleWidth;
            newPanel.Height = (int)newRectangle.RectangleHeight;

            _rectanglePanels.Add(newPanel);
            RectangleRectanglesViewPanel.Controls.Add(newPanel);
            CheckCollision();
        }
        private void CheckCollision()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_newRectangle[i], _newRectangle[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
        private void RectangleDeleteButton_Click(object sender, EventArgs e)
        {
            if (ListBoxNewRectangle.SelectedIndex < 0) return;
            _newRectangle.RemoveAt(ListBoxNewRectangle.SelectedIndex);
            _rectanglePanels.RemoveAt(ListBoxNewRectangle.SelectedIndex);
            RectangleRectanglesViewPanel.Controls.RemoveAt(ListBoxNewRectangle.SelectedIndex);
            ListBoxNewRectangle.Items.RemoveAt(ListBoxNewRectangle.SelectedIndex);
            CheckCollision();
        }
        private void ChangeTextElemListBoxRectangle()
        {
            ListBoxNewRectangle.Items[ListBoxNewRectangle.SelectedIndex] = $"{_newRectangle[ListBoxNewRectangle.SelectedIndex].Id}. (" +
                $"{_newRectangle[ListBoxNewRectangle.SelectedIndex].CenterOfRectangle} W = {_newRectangle[ListBoxNewRectangle.SelectedIndex].RectangleWidth}; " +
                $"H = {_newRectangle[ListBoxNewRectangle.SelectedIndex].RectangleHeight})";
        }

        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectanglesXTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectanglesXTextBox.Text);
                _currentNewRectangle.CenterOfRectangle = new Point2D(text, _currentNewRectangle.CenterOfRectangle.Y);
                RectanglesXTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Location = new Point(
                    text - _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Width / 2,
                    _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Location.Y);

                CheckCollision();
            }
            catch (Exception)
            {
                RectanglesXTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(RectanglesYTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectanglesYTextBox.Text);
                _currentNewRectangle.CenterOfRectangle = new Point2D(_currentNewRectangle.CenterOfRectangle.X, int.Parse(RectanglesYTextBox.Text));
                RectanglesYTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Location = new Point(
                    _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Location.X,
                    text - _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Height / 2);

                CheckCollision();
            }
            catch (Exception)
            {
                RectanglesYTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleWidthTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectangleWidthTextBox.Text);
                _currentNewRectangle.RectangleWidth = text;
                RectangleWidthTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Width = text;

                CheckCollision();
            }
            catch (Exception)
            {
                RectangleWidthTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleHeightTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectangleHeightTextBox.Text);
                _currentNewRectangle.RectangleHeight = text;
                RectangleHeightTextBox.BackColor = Color.FromKnownColor(KnownColor.Window);
                ChangeTextElemListBoxRectangle();

                _rectanglePanels[ListBoxNewRectangle.SelectedIndex].Height = text;

                CheckCollision();
            }
            catch (Exception)
            {
                RectangleHeightTextBox.BackColor = Color.LightPink;
            }
        }

        private void ListBoxNewRectangle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxNewRectangle.SelectedIndex < 0)
            {
                RectangleWidthTextBox.Text = string.Empty;
                RectangleHeightTextBox.Text = string.Empty;
                RectanglesXTextBox.Text = string.Empty;
                RectanglesYTextBox.Text = string.Empty;
                RectanglesIDTextBox.Text = string.Empty;
            }

            else
            {
                _currentNewRectangle = _newRectangle[ListBoxNewRectangle.SelectedIndex];

                RectangleWidthTextBox.Text = _currentNewRectangle.RectangleWidth.ToString();
                RectangleHeightTextBox.Text = _currentNewRectangle.RectangleHeight.ToString();
                RectanglesXTextBox.Text = _currentNewRectangle.CenterOfRectangle.X.ToString();
                RectanglesYTextBox.Text = _currentNewRectangle.CenterOfRectangle.Y.ToString();
                RectanglesIDTextBox.Text = _currentNewRectangle.Id.ToString();
            }
        }
    }
}