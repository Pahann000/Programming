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
            seasonHandlesControl1 = new View.UserControls.SeasonHandlesControl();
            WeekdayParsingControl = new View.UserControls.WeekdayParsingControl();
            EnumerationsControl = new View.UserControls.EnumerationsControl();
            SeasonGroupBox = new GroupBox();
            classesPage = new TabPage();
            MovieGroupBox = new GroupBox();
            rectanglesGroupBox = new GroupBox();
            rectanglesControl1 = new View.UserControls.RectanglesControl();
            RectangleTabPage = new TabPage();
            rectangleCollisionControl1 = new View.RectangleCollisionControl();
            SeasonLabel = new Label();
            SeasonComboBox = new ComboBox();
            SeasonButton = new Button();
            RectangleRectanglesLabel = new Label();
            RectangleHeightLabel = new Label();
            RectangleWidthLabel = new Label();
            RectangleIDLabel = new Label();
            RectangleYLabel = new Label();
            RectangleXLabel = new Label();
            RectangleCurrentLabel = new Label();
            RectangleDeleteButton = new Button();
            RectangleAddButton = new Button();
            RectangleHeightTextBox = new TextBox();
            RectangleWidthTextBox = new TextBox();
            RectanglesYTextBox = new TextBox();
            RectanglesXTextBox = new TextBox();
            RectanglesIDTextBox = new TextBox();
            ListBoxNewRectangle = new ListBox();
            RectangleRectanglesViewPanel = new Panel();
            moviesControl1 = new View.UserControls.MoviesControl();
            EnumsTabControl.SuspendLayout();
            enumsPage.SuspendLayout();
            classesPage.SuspendLayout();
            MovieGroupBox.SuspendLayout();
            rectanglesGroupBox.SuspendLayout();
            RectangleTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabControl
            // 
            EnumsTabControl.Controls.Add(enumsPage);
            EnumsTabControl.Controls.Add(classesPage);
            EnumsTabControl.Controls.Add(RectangleTabPage);
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
            enumsPage.Controls.Add(seasonHandlesControl1);
            enumsPage.Controls.Add(WeekdayParsingControl);
            enumsPage.Controls.Add(EnumerationsControl);
            enumsPage.Controls.Add(SeasonGroupBox);
            enumsPage.ImeMode = ImeMode.NoControl;
            enumsPage.Location = new Point(4, 29);
            enumsPage.Name = "enumsPage";
            enumsPage.Padding = new Padding(3);
            enumsPage.Size = new Size(828, 451);
            enumsPage.TabIndex = 0;
            enumsPage.Text = "Enums";
            enumsPage.UseVisualStyleBackColor = true;
            // 
            // seasonHandlesControl1
            // 
            seasonHandlesControl1.Location = new Point(419, 275);
            seasonHandlesControl1.Name = "seasonHandlesControl1";
            seasonHandlesControl1.Size = new Size(409, 177);
            seasonHandlesControl1.TabIndex = 20;
            // 
            // WeekdayParsingControl
            // 
            WeekdayParsingControl.Location = new Point(3, 275);
            WeekdayParsingControl.Name = "WeekdayParsingControl";
            WeekdayParsingControl.Size = new Size(410, 180);
            WeekdayParsingControl.TabIndex = 18;
            // 
            // EnumerationsControl
            // 
            EnumerationsControl.Location = new Point(3, 0);
            EnumerationsControl.Name = "EnumerationsControl";
            EnumerationsControl.Size = new Size(825, 269);
            EnumerationsControl.TabIndex = 17;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Location = new Point(0, 0);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(200, 100);
            SeasonGroupBox.TabIndex = 19;
            SeasonGroupBox.TabStop = false;
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
            MovieGroupBox.Controls.Add(moviesControl1);
            MovieGroupBox.Location = new Point(348, 3);
            MovieGroupBox.Name = "MovieGroupBox";
            MovieGroupBox.Size = new Size(413, 296);
            MovieGroupBox.TabIndex = 1;
            MovieGroupBox.TabStop = false;
            MovieGroupBox.Text = "Movies";
            // 
            // rectanglesGroupBox
            // 
            rectanglesGroupBox.Controls.Add(rectanglesControl1);
            rectanglesGroupBox.Location = new Point(3, 3);
            rectanglesGroupBox.Name = "rectanglesGroupBox";
            rectanglesGroupBox.Size = new Size(339, 296);
            rectanglesGroupBox.TabIndex = 0;
            rectanglesGroupBox.TabStop = false;
            rectanglesGroupBox.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(0, 21);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(333, 262);
            rectanglesControl1.TabIndex = 0;
            // 
            // RectangleTabPage
            // 
            RectangleTabPage.Controls.Add(rectangleCollisionControl1);
            RectangleTabPage.Location = new Point(4, 29);
            RectangleTabPage.Name = "RectangleTabPage";
            RectangleTabPage.Padding = new Padding(3);
            RectangleTabPage.Size = new Size(828, 451);
            RectangleTabPage.TabIndex = 2;
            RectangleTabPage.Text = "Rectangles";
            RectangleTabPage.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            rectangleCollisionControl1.Dock = DockStyle.Fill;
            rectangleCollisionControl1.Location = new Point(3, 3);
            rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            rectangleCollisionControl1.Size = new Size(822, 445);
            rectangleCollisionControl1.TabIndex = 0;
            // 
            // SeasonLabel
            // 
            SeasonLabel.Location = new Point(0, 0);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(100, 23);
            SeasonLabel.TabIndex = 0;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.Location = new Point(0, 0);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(121, 28);
            SeasonComboBox.TabIndex = 0;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(0, 0);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(75, 23);
            SeasonButton.TabIndex = 0;
            // 
            // RectangleRectanglesLabel
            // 
            RectangleRectanglesLabel.Location = new Point(0, 0);
            RectangleRectanglesLabel.Name = "RectangleRectanglesLabel";
            RectangleRectanglesLabel.Size = new Size(100, 23);
            RectangleRectanglesLabel.TabIndex = 0;
            // 
            // RectangleHeightLabel
            // 
            RectangleHeightLabel.Location = new Point(0, 0);
            RectangleHeightLabel.Name = "RectangleHeightLabel";
            RectangleHeightLabel.Size = new Size(100, 23);
            RectangleHeightLabel.TabIndex = 0;
            // 
            // RectangleWidthLabel
            // 
            RectangleWidthLabel.Location = new Point(0, 0);
            RectangleWidthLabel.Name = "RectangleWidthLabel";
            RectangleWidthLabel.Size = new Size(100, 23);
            RectangleWidthLabel.TabIndex = 0;
            // 
            // RectangleIDLabel
            // 
            RectangleIDLabel.Location = new Point(0, 0);
            RectangleIDLabel.Name = "RectangleIDLabel";
            RectangleIDLabel.Size = new Size(100, 23);
            RectangleIDLabel.TabIndex = 0;
            // 
            // RectangleYLabel
            // 
            RectangleYLabel.Location = new Point(0, 0);
            RectangleYLabel.Name = "RectangleYLabel";
            RectangleYLabel.Size = new Size(100, 23);
            RectangleYLabel.TabIndex = 0;
            // 
            // RectangleXLabel
            // 
            RectangleXLabel.Location = new Point(0, 0);
            RectangleXLabel.Name = "RectangleXLabel";
            RectangleXLabel.Size = new Size(100, 23);
            RectangleXLabel.TabIndex = 0;
            // 
            // RectangleCurrentLabel
            // 
            RectangleCurrentLabel.Location = new Point(0, 0);
            RectangleCurrentLabel.Name = "RectangleCurrentLabel";
            RectangleCurrentLabel.Size = new Size(100, 23);
            RectangleCurrentLabel.TabIndex = 0;
            // 
            // RectangleDeleteButton
            // 
            RectangleDeleteButton.Location = new Point(0, 0);
            RectangleDeleteButton.Name = "RectangleDeleteButton";
            RectangleDeleteButton.Size = new Size(75, 23);
            RectangleDeleteButton.TabIndex = 0;
            // 
            // RectangleAddButton
            // 
            RectangleAddButton.Location = new Point(0, 0);
            RectangleAddButton.Name = "RectangleAddButton";
            RectangleAddButton.Size = new Size(75, 23);
            RectangleAddButton.TabIndex = 0;
            // 
            // RectangleHeightTextBox
            // 
            RectangleHeightTextBox.Location = new Point(0, 0);
            RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            RectangleHeightTextBox.Size = new Size(100, 27);
            RectangleHeightTextBox.TabIndex = 0;
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(0, 0);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(100, 27);
            RectangleWidthTextBox.TabIndex = 0;
            // 
            // RectanglesYTextBox
            // 
            RectanglesYTextBox.Location = new Point(0, 0);
            RectanglesYTextBox.Name = "RectanglesYTextBox";
            RectanglesYTextBox.Size = new Size(100, 27);
            RectanglesYTextBox.TabIndex = 0;
            // 
            // RectanglesXTextBox
            // 
            RectanglesXTextBox.Location = new Point(0, 0);
            RectanglesXTextBox.Name = "RectanglesXTextBox";
            RectanglesXTextBox.Size = new Size(100, 27);
            RectanglesXTextBox.TabIndex = 0;
            // 
            // RectanglesIDTextBox
            // 
            RectanglesIDTextBox.Location = new Point(0, 0);
            RectanglesIDTextBox.Name = "RectanglesIDTextBox";
            RectanglesIDTextBox.Size = new Size(100, 27);
            RectanglesIDTextBox.TabIndex = 0;
            // 
            // ListBoxNewRectangle
            // 
            ListBoxNewRectangle.Location = new Point(0, 0);
            ListBoxNewRectangle.Name = "ListBoxNewRectangle";
            ListBoxNewRectangle.Size = new Size(120, 96);
            ListBoxNewRectangle.TabIndex = 0;
            // 
            // RectangleRectanglesViewPanel
            // 
            RectangleRectanglesViewPanel.Location = new Point(0, 0);
            RectangleRectanglesViewPanel.Name = "RectangleRectanglesViewPanel";
            RectangleRectanglesViewPanel.Size = new Size(200, 100);
            RectangleRectanglesViewPanel.TabIndex = 0;
            // 
            // moviesControl1
            // 
            moviesControl1.Location = new Point(0, 26);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(413, 270);
            moviesControl1.TabIndex = 0;
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
            classesPage.ResumeLayout(false);
            MovieGroupBox.ResumeLayout(false);
            rectanglesGroupBox.ResumeLayout(false);
            RectangleTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage enumsPage;
        private Label SeasonLabel;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
        public GroupBox SeasonGroupBox;
        private TabPage classesPage;
        private GroupBox rectanglesGroupBox;
        private GroupBox MovieGroupBox;
        private TabPage RectangleTabPage;
        private ListBox ListBoxNewRectangle;
        private Panel RectangleRectanglesViewPanel;
        private TextBox RectangleHeightTextBox;
        private TextBox RectangleWidthTextBox;
        private TextBox RectanglesYTextBox;
        private TextBox RectanglesXTextBox;
        private TextBox RectanglesIDTextBox;
        private Label RectangleRectanglesLabel;
        private Label RectangleHeightLabel;
        private Label RectangleWidthLabel;
        private Label RectangleIDLabel;
        private Label RectangleYLabel;
        private Label RectangleXLabel;
        private Label RectangleCurrentLabel;
        private Button RectangleDeleteButton;
        private Button RectangleAddButton;
        private View.RectangleCollisionControl rectangleCollisionControl1;
        private View.UserControls.EnumerationsControl EnumerationsControl;
        private View.UserControls.WeekdayParsingControl WeekdayParsingControl;
        private View.UserControls.SeasonHandlesControl seasonHandlesControl1;
        private View.UserControls.RectanglesControl rectanglesControl1;
        private View.UserControls.MoviesControl moviesControl1;
    }
}
