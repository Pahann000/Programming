using System.Text.Json;

namespace MyProgram8
{
    public partial class MyProgramForm : Form
    {
        public MyProgramForm()
        {
            InitializeComponent();
            UpdateNotesListBox();
            CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(NotesCategory)));
        }
        /// <summary>
        /// 
        /// </summary>
        private static List<MyNotes> _notes = new List<MyNotes>();

        /// <summary>
        /// 
        /// </summary>
        private static MyNotes _currentNote = null;

        /// <summary>
        /// 
        /// </summary>
        private void UpdateNotesListBox()
        {
            NotesListBox.Items.Clear();
            foreach (MyNotes note in _notes)
            {
                NotesListBox.Items.Add(note.NoteTitle);
            }
        }

        private void AddNotesButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string text = NoteTextBox.Text;
            NotesCategory category = (NotesCategory)Enum.Parse(typeof(NotesCategory), CategoryComboBox.SelectedItem.ToString());
            DateTime dateTime = DateTime.Now;
            MyNotes newNote = new MyNotes(title, text, dateTime, category);
            _notes.Insert(0, newNote);
            UpdateNotesListBox();
        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex < 0)
            {
                TitleTextBox.Enabled = false;
                NoteTextBox.Enabled = false;
                CategoryComboBox.Enabled = false;

                TitleTextBox.Clear();
                NoteTextBox.Clear();
                CategoryComboBox.SelectedIndex = -1;
                SavingTimeTextBox.Clear();
            }
            else
            {
                TitleTextBox.Enabled = true;
                NoteTextBox.Enabled = true;
                CategoryComboBox.Enabled = true;

                _currentNote = _notes[NotesListBox.SelectedIndex];

                TitleTextBox.Text = _currentNote.NoteTitle;
                NoteTextBox.Text = _currentNote.NoteText;
                CategoryComboBox.Text = _currentNote.NoteCategory.ToString();
                SavingTimeTextBox.Text = _currentNote.SavingTime.ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void ChangeTextElemListBoxInstitution()
        {
            NotesListBox.Items[NotesListBox.SelectedIndex] = _notes[NotesListBox.SelectedIndex].NoteTitle;
        }
        private void ChangeNotesButton_Click(object sender, EventArgs e)
        {

            _currentNote.NoteTitle = TitleTextBox.Text;
            _currentNote.NoteText = NoteTextBox.Text;
            CategoryComboBox.SelectedItem = _currentNote.NoteCategory.ToString();
            _currentNote.SavingTime = DateTime.Now;
            ChangeTextElemListBoxInstitution();
            NotesListBox.Sorted = true;

            _notes = Write(_notes);
        }

        private void DeleteNotesButton_Click(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex < 0) return;
            _notes.RemoveAt(NotesListBox.SelectedIndex);
            NotesListBox.Items.RemoveAt(NotesListBox.SelectedIndex);

            _notes = Write(_notes);
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleTextBox.Text) || TitleTextBox.Text.Count() > 100)
            {
                ChangeNotesButton.Enabled = false;
                return;
            }
            ChangeNotesButton.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void SaveData()
        {
            string path = Environment.CurrentDirectory + @"\data.txt";
            string data = JsonSerializer.Serialize(_notes);

            File.WriteAllText(path, data);
        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadData()
        {
            string path = Environment.CurrentDirectory + @"\data.txt";

            if (!File.Exists(path)) return;

            string data = File.ReadAllText(path);

            _notes = JsonSerializer.Deserialize<List<MyNotes>>(data);

            _notes = Write(_notes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private List<MyNotes> Write(List<MyNotes> list)
        {
            NotesListBox.Items.Clear();
            list = list.OrderBy(s => s.NoteTitle).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                NotesListBox.Items.Add($"{list[i].NoteTitle}");
            }
            return list;
        }

        private void MyProgramForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MyProgramForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }


    }
}


