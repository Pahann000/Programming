namespace Programming.View.UserControls
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            SearchMovieButton = new Button();
            MovieNameLabel = new Label();
            DurationLabel = new Label();
            YearOfReleaseLabel = new Label();
            GenreLabel = new Label();
            RatingLabel = new Label();
            RatingTextBox = new TextBox();
            MovieGenreTextBox = new TextBox();
            ReleaseYearTextBox = new TextBox();
            DurationTextBox = new TextBox();
            MovieNameTextBox = new TextBox();
            MoviesListBox = new ListBox();
            SuspendLayout();
            // 
            // SearchMovieButton
            // 
            SearchMovieButton.Location = new Point(36, 212);
            SearchMovieButton.Name = "SearchMovieButton";
            SearchMovieButton.Size = new Size(94, 29);
            SearchMovieButton.TabIndex = 23;
            SearchMovieButton.Text = "Search";
            SearchMovieButton.UseVisualStyleBackColor = true;
            SearchMovieButton.Click += SearchMovieButton_Click;
            // 
            // MovieNameLabel
            // 
            MovieNameLabel.AutoSize = true;
            MovieNameLabel.Location = new Point(230, 3);
            MovieNameLabel.Name = "MovieNameLabel";
            MovieNameLabel.Size = new Size(52, 20);
            MovieNameLabel.TabIndex = 22;
            MovieNameLabel.Text = "Name:";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(227, 57);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(70, 20);
            DurationLabel.TabIndex = 21;
            DurationLabel.Text = "Duration:";
            // 
            // YearOfReleaseLabel
            // 
            YearOfReleaseLabel.AutoSize = true;
            YearOfReleaseLabel.Location = new Point(229, 108);
            YearOfReleaseLabel.Name = "YearOfReleaseLabel";
            YearOfReleaseLabel.Size = new Size(40, 20);
            YearOfReleaseLabel.TabIndex = 20;
            YearOfReleaseLabel.Text = "Year:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(228, 162);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 19;
            GenreLabel.Text = "Genre:";
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(230, 216);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(55, 20);
            RatingLabel.TabIndex = 18;
            RatingLabel.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(227, 238);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 17;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // MovieGenreTextBox
            // 
            MovieGenreTextBox.Location = new Point(227, 185);
            MovieGenreTextBox.Name = "MovieGenreTextBox";
            MovieGenreTextBox.Size = new Size(125, 27);
            MovieGenreTextBox.TabIndex = 16;
            MovieGenreTextBox.TextChanged += MovieGenreTextBox_TextChanged;
            // 
            // ReleaseYearTextBox
            // 
            ReleaseYearTextBox.Location = new Point(227, 133);
            ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            ReleaseYearTextBox.Size = new Size(125, 27);
            ReleaseYearTextBox.TabIndex = 15;
            ReleaseYearTextBox.TextChanged += ReleaseYearTextBox_TextChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(227, 80);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 14;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // MovieNameTextBox
            // 
            MovieNameTextBox.Location = new Point(227, 26);
            MovieNameTextBox.Name = "MovieNameTextBox";
            MovieNameTextBox.Size = new Size(125, 27);
            MovieNameTextBox.TabIndex = 13;
            MovieNameTextBox.Click += MoviesListBox_SelectedIndexChanged;
            MovieNameTextBox.TextChanged += MovieNameTextBox_TextChanged;
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.Location = new Point(3, 3);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(165, 164);
            MoviesListBox.TabIndex = 12;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchMovieButton);
            Controls.Add(MovieNameLabel);
            Controls.Add(DurationLabel);
            Controls.Add(YearOfReleaseLabel);
            Controls.Add(GenreLabel);
            Controls.Add(RatingLabel);
            Controls.Add(RatingTextBox);
            Controls.Add(MovieGenreTextBox);
            Controls.Add(ReleaseYearTextBox);
            Controls.Add(DurationTextBox);
            Controls.Add(MovieNameTextBox);
            Controls.Add(MoviesListBox);
            Name = "MoviesControl";
            Size = new Size(365, 275);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchMovieButton;
        private Label MovieNameLabel;
        private Label DurationLabel;
        private Label YearOfReleaseLabel;
        private Label GenreLabel;
        private Label RatingLabel;
        private TextBox RatingTextBox;
        private TextBox MovieGenreTextBox;
        private TextBox ReleaseYearTextBox;
        private TextBox DurationTextBox;
        private TextBox MovieNameTextBox;
        private ListBox MoviesListBox;
    }
}
