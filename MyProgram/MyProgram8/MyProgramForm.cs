namespace MyProgram8
{
    public partial class MyProgramForm : Form
    {
        public MyProgramForm()
        {
            InitializeComponent();
        }
        List<Note> notes = new List<Note>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateNotesListBox();
            categoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string text = noteTextBox.Text;
            Category category = (Category)Enum.Parse(typeof(Category), categoryComboBox.SelectedItem.ToString());

            Note newNote = new Note(title, text, category);
            notes.Insert(0, newNote); // Insert at the beginning of the list

            UpdateNotesListBox();
        }

        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notesListBox.SelectedIndex >= 0)
            {
                Note selectedNote = notes[notesListBox.SelectedIndex];
                titleTextBox.Text = selectedNote.Title;
                noteTextBox.Text = selectedNote.Text;
                categoryComboBox.SelectedItem = selectedNote.Category.ToString();
            }
        }

        private void UpdateNotesListBox()
        {
            notesListBox.Items.Clear();
            foreach (Note note in notes)
            {
                notesListBox.Items.Add(note.Title);
            }
        }
    }

    public enum Category
    {
        Home,
        Work,
        Sport,
        Finance
    }

    public class Note
    {
        public string Title { get; }
        public string Text { get; set; }
        public DateTime CreationTime { get; }
        public Category Category { get; }

        public Note(string title, string text, Category category)
        {
            Title = title;
            Text = text;
            CreationTime = DateTime.Now;
            Category = category;
        }
    }
}


