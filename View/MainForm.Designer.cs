namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnumsTabControl = new TabControl();
            enumsPage = new TabPage();
            SeasonGroupBox = new GroupBox();
            SeasonLabel = new Label();
            SeasonComboBox = new ComboBox();
            SeasonButton = new Button();
            ParsingGroupBox = new GroupBox();
            WeekdayLabel = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            ParsingLabel = new Label();
            EnumerationsGroupBox = new GroupBox();
            ValueListBoxLabel = new Label();
            EnumsListBoxLabel = new Label();
            TextBoxLabel = new Label();
            IndexTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            classesPage = new TabPage();
            MovieGroupBox = new GroupBox();
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
            rectanglesGroupBox = new GroupBox();
            FindRectangleButton = new Button();
            colorLabel = new Label();
            widthLabel = new Label();
            lengthLabel = new Label();
            ColorTextBox = new TextBox();
            WidthTextBox = new TextBox();
            LengthTextBox = new TextBox();
            RectangleListBox = new ListBox();
            EnumsTabControl.SuspendLayout();
            enumsPage.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            ParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            classesPage.SuspendLayout();
            MovieGroupBox.SuspendLayout();
            rectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabControl
            // 
            EnumsTabControl.Controls.Add(enumsPage);
            EnumsTabControl.Controls.Add(classesPage);
            EnumsTabControl.Dock = DockStyle.Fill;
            EnumsTabControl.Location = new Point(0, 0);
            EnumsTabControl.Name = "EnumsTabControl";
            EnumsTabControl.SelectedIndex = 0;
            EnumsTabControl.Size = new Size(836, 484);
            EnumsTabControl.TabIndex = 0;
            EnumsTabControl.Tag = "";
            // 
            // enumsPage
            // 
            enumsPage.AccessibleName = "";
            enumsPage.Controls.Add(SeasonGroupBox);
            enumsPage.Controls.Add(ParsingGroupBox);
            enumsPage.Controls.Add(EnumerationsGroupBox);
            enumsPage.ImeMode = ImeMode.NoControl;
            enumsPage.Location = new Point(4, 29);
            enumsPage.Name = "enumsPage";
            enumsPage.Padding = new Padding(3);
            enumsPage.Size = new Size(828, 451);
            enumsPage.TabIndex = 0;
            enumsPage.Text = "Enums";
            enumsPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Controls.Add(SeasonButton);
            SeasonGroupBox.Location = new Point(419, 275);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(401, 173);
            SeasonGroupBox.TabIndex = 16;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(69, 41);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(110, 20);
            SeasonLabel.TabIndex = 15;
            SeasonLabel.Text = "Choose season:";
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(69, 64);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(151, 28);
            SeasonComboBox.TabIndex = 14;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(250, 64);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(94, 29);
            SeasonButton.TabIndex = 13;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonMoves;
            // 
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(WeekdayLabel);
            ParsingGroupBox.Controls.Add(ParseButton);
            ParsingGroupBox.Controls.Add(WeekdayTextBox);
            ParsingGroupBox.Controls.Add(ParsingLabel);
            ParsingGroupBox.Location = new Point(3, 275);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(410, 173);
            ParsingGroupBox.TabIndex = 15;
            ParsingGroupBox.TabStop = false;
            ParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayLabel
            // 
            WeekdayLabel.AutoSize = true;
            WeekdayLabel.Location = new Point(16, 112);
            WeekdayLabel.Name = "WeekdayLabel";
            WeekdayLabel.Size = new Size(0, 20);
            WeekdayLabel.TabIndex = 13;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(200, 64);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 12;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += WeekdayParsing;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(16, 66);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(125, 27);
            WeekdayTextBox.TabIndex = 11;
            // 
            // ParsingLabel
            // 
            ParsingLabel.AutoSize = true;
            ParsingLabel.Location = new Point(7, 41);
            ParsingLabel.Name = "ParsingLabel";
            ParsingLabel.Size = new Size(158, 20);
            ParsingLabel.TabIndex = 10;
            ParsingLabel.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(ValueListBoxLabel);
            EnumerationsGroupBox.Controls.Add(EnumsListBoxLabel);
            EnumerationsGroupBox.Controls.Add(TextBoxLabel);
            EnumerationsGroupBox.Controls.Add(IndexTextBox);
            EnumerationsGroupBox.Controls.Add(ValuesListBox);
            EnumerationsGroupBox.Controls.Add(EnumsListBox);
            EnumerationsGroupBox.Location = new Point(3, 6);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Size = new Size(817, 263);
            EnumerationsGroupBox.TabIndex = 14;
            EnumerationsGroupBox.TabStop = false;
            EnumerationsGroupBox.Text = "Enumerations";
            // 
            // ValueListBoxLabel
            // 
            ValueListBoxLabel.AutoSize = true;
            ValueListBoxLabel.Location = new Point(334, 38);
            ValueListBoxLabel.Name = "ValueListBoxLabel";
            ValueListBoxLabel.Size = new Size(100, 20);
            ValueListBoxLabel.TabIndex = 11;
            ValueListBoxLabel.Text = "Choose value:";
            // 
            // EnumsListBoxLabel
            // 
            EnumsListBoxLabel.AutoSize = true;
            EnumsListBoxLabel.Location = new Point(64, 38);
            EnumsListBoxLabel.Name = "EnumsListBoxLabel";
            EnumsListBoxLabel.Size = new Size(149, 20);
            EnumsListBoxLabel.TabIndex = 10;
            EnumsListBoxLabel.Text = "Choose enumeration:";
            // 
            // TextBoxLabel
            // 
            TextBoxLabel.AutoSize = true;
            TextBoxLabel.Location = new Point(628, 38);
            TextBoxLabel.Name = "TextBoxLabel";
            TextBoxLabel.Size = new Size(68, 20);
            TextBoxLabel.TabIndex = 9;
            TextBoxLabel.Text = "Int value:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(628, 61);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(125, 27);
            IndexTextBox.TabIndex = 8;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(334, 61);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(178, 164);
            ValuesListBox.TabIndex = 7;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color ", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(64, 61);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(178, 164);
            EnumsListBox.TabIndex = 6;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // classesPage
            // 
            classesPage.Controls.Add(MovieGroupBox);
            classesPage.Controls.Add(rectanglesGroupBox);
            classesPage.Location = new Point(4, 29);
            classesPage.Name = "classesPage";
            classesPage.Size = new Size(828, 451);
            classesPage.TabIndex = 1;
            classesPage.Text = "Classes";
            classesPage.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            MovieGroupBox.Controls.Add(SearchMovieButton);
            MovieGroupBox.Controls.Add(MovieNameLabel);
            MovieGroupBox.Controls.Add(DurationLabel);
            MovieGroupBox.Controls.Add(YearOfReleaseLabel);
            MovieGroupBox.Controls.Add(GenreLabel);
            MovieGroupBox.Controls.Add(RatingLabel);
            MovieGroupBox.Controls.Add(RatingTextBox);
            MovieGroupBox.Controls.Add(MovieGenreTextBox);
            MovieGroupBox.Controls.Add(ReleaseYearTextBox);
            MovieGroupBox.Controls.Add(DurationTextBox);
            MovieGroupBox.Controls.Add(MovieNameTextBox);
            MovieGroupBox.Controls.Add(MoviesListBox);
            MovieGroupBox.Location = new Point(348, 3);
            MovieGroupBox.Name = "MovieGroupBox";
            MovieGroupBox.Size = new Size(413, 296);
            MovieGroupBox.TabIndex = 1;
            MovieGroupBox.TabStop = false;
            MovieGroupBox.Text = "Movies";
            // 
            // SearchMovieButton
            // 
            SearchMovieButton.Location = new Point(39, 230);
            SearchMovieButton.Name = "SearchMovieButton";
            SearchMovieButton.Size = new Size(94, 29);
            SearchMovieButton.TabIndex = 11;
            SearchMovieButton.Text = "Search";
            SearchMovieButton.UseVisualStyleBackColor = true;
            SearchMovieButton.Click += SearchMovieButton_Click;
            // 
            // MovieNameLabel
            // 
            MovieNameLabel.AutoSize = true;
            MovieNameLabel.Location = new Point(233, 21);
            MovieNameLabel.Name = "MovieNameLabel";
            MovieNameLabel.Size = new Size(52, 20);
            MovieNameLabel.TabIndex = 10;
            MovieNameLabel.Text = "Name:";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(230, 75);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(70, 20);
            DurationLabel.TabIndex = 9;
            DurationLabel.Text = "Duration:";
            // 
            // YearOfReleaseLabel
            // 
            YearOfReleaseLabel.AutoSize = true;
            YearOfReleaseLabel.Location = new Point(232, 126);
            YearOfReleaseLabel.Name = "YearOfReleaseLabel";
            YearOfReleaseLabel.Size = new Size(40, 20);
            YearOfReleaseLabel.TabIndex = 8;
            YearOfReleaseLabel.Text = "Year:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(231, 180);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 7;
            GenreLabel.Text = "Genre:";
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(233, 234);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(55, 20);
            RatingLabel.TabIndex = 6;
            RatingLabel.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(230, 256);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 5;
            // 
            // MovieGenreTextBox
            // 
            MovieGenreTextBox.Location = new Point(230, 203);
            MovieGenreTextBox.Name = "MovieGenreTextBox";
            MovieGenreTextBox.Size = new Size(125, 27);
            MovieGenreTextBox.TabIndex = 4;
            // 
            // ReleaseYearTextBox
            // 
            ReleaseYearTextBox.Location = new Point(230, 151);
            ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            ReleaseYearTextBox.Size = new Size(125, 27);
            ReleaseYearTextBox.TabIndex = 3;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(230, 98);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 2;
            // 
            // MovieNameTextBox
            // 
            MovieNameTextBox.Location = new Point(230, 44);
            MovieNameTextBox.Name = "MovieNameTextBox";
            MovieNameTextBox.Size = new Size(125, 27);
            MovieNameTextBox.TabIndex = 1;
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.Location = new Point(6, 21);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(165, 164);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // rectanglesGroupBox
            // 
            rectanglesGroupBox.Controls.Add(FindRectangleButton);
            rectanglesGroupBox.Controls.Add(colorLabel);
            rectanglesGroupBox.Controls.Add(widthLabel);
            rectanglesGroupBox.Controls.Add(lengthLabel);
            rectanglesGroupBox.Controls.Add(ColorTextBox);
            rectanglesGroupBox.Controls.Add(WidthTextBox);
            rectanglesGroupBox.Controls.Add(LengthTextBox);
            rectanglesGroupBox.Controls.Add(RectangleListBox);
            rectanglesGroupBox.Location = new Point(3, 3);
            rectanglesGroupBox.Name = "rectanglesGroupBox";
            rectanglesGroupBox.Size = new Size(339, 281);
            rectanglesGroupBox.TabIndex = 0;
            rectanglesGroupBox.TabStop = false;
            rectanglesGroupBox.Text = "Rectangles";
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.Location = new Point(186, 226);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(94, 29);
            FindRectangleButton.TabIndex = 7;
            FindRectangleButton.Text = "Find";
            FindRectangleButton.UseVisualStyleBackColor = true;
            FindRectangleButton.Click += FindRectangleButton_Click;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(186, 140);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(48, 20);
            colorLabel.TabIndex = 6;
            colorLabel.Text = "Color:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(186, 80);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(52, 20);
            widthLabel.TabIndex = 5;
            widthLabel.Text = "Width:";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(186, 19);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(57, 20);
            lengthLabel.TabIndex = 4;
            lengthLabel.Text = "Length:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(186, 163);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 3;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(186, 103);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 2;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(186, 42);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 1;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // RectangleListBox
            // 
            RectangleListBox.FormattingEnabled = true;
            RectangleListBox.Location = new Point(0, 26);
            RectangleListBox.Name = "RectangleListBox";
            RectangleListBox.Size = new Size(150, 164);
            RectangleListBox.TabIndex = 0;
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 484);
            Controls.Add(EnumsTabControl);
            Name = "MainForm";
            Text = "Programming Demo";
            EnumsTabControl.ResumeLayout(false);
            enumsPage.ResumeLayout(false);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            ParsingGroupBox.ResumeLayout(false);
            ParsingGroupBox.PerformLayout();
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            classesPage.ResumeLayout(false);
            MovieGroupBox.ResumeLayout(false);
            MovieGroupBox.PerformLayout();
            rectanglesGroupBox.ResumeLayout(false);
            rectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage enumsPage;
        private Label SeasonLabel;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
        private GroupBox ParsingGroupBox;
        private Label WeekdayLabel;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label ParsingLabel;
        private Label ValueListBoxLabel;
        private Label EnumsListBoxLabel;
        private Label TextBoxLabel;
        private TextBox IndexTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        public GroupBox SeasonGroupBox;
        public GroupBox EnumerationsGroupBox;
        private TabPage classesPage;
        private GroupBox rectanglesGroupBox;
        private Label colorLabel;
        private Label widthLabel;
        private Label lengthLabel;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private Button FindRectangleButton;
        private GroupBox MovieGroupBox;
        private ListBox MoviesListBox;
        private TextBox MovieGenreTextBox;
        private TextBox ReleaseYearTextBox;
        private TextBox DurationTextBox;
        private TextBox MovieNameTextBox;
        private TextBox RatingTextBox;
        private Label MovieNameLabel;
        private Label DurationLabel;
        private Label YearOfReleaseLabel;
        private Label GenreLabel;
        private Label RatingLabel;
        private Button SearchMovieButton;
        private ListBox RectangleListBox;
    }
}
