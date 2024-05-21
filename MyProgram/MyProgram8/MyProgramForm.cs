using System.Text.Json;

namespace MyProgram8
{
    public partial class MyProgramForm : Form
    {
        public MyProgramForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(NotesCategory)));
            _notes.Sort((x, y) => y.SavingTime.CompareTo(x.SavingTime));
        }
        /// <summary>
        /// Хранит данные о заметках.
        /// </summary>
        private static List<MyNotes> _notes = new List<MyNotes>();

        /// <summary>
        /// Хранит данные о текущей заметке.
        /// </summary>
        private static MyNotes _currentNote = null;
       
        private void AddNotesButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string text = NoteTextBox.Text;
            NotesCategory category = (NotesCategory)Enum.Parse(typeof(NotesCategory), CategoryComboBox.SelectedItem.ToString());
            DateTime dateTime = DateTime.Now;
            MyNotes newNote = new MyNotes(title, text, dateTime, category);
            _notes.Insert(0, newNote);
            _notes = Write(_notes);
        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex < 0)
            {

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
        /// Вывод названий заметок в listbox.
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
        /// Сохраняет данные.
        /// </summary>
        public void SaveData()
        {
            string path = Environment.CurrentDirectory + @"\data.txt";
            string data = JsonSerializer.Serialize(_notes);

            File.WriteAllText(path, data);
        }

        /// <summary>
        /// Загружает данные.
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
        /// Запись заметок в правильном порядке.
        /// </summary>
        /// <param name="list">Список заметок.</param>
        /// <returns></returns>
        private List<MyNotes> Write(List<MyNotes> list)
        {
            _notes.Sort((x, y) => y.SavingTime.CompareTo(x.SavingTime));
            NotesListBox.Items.Clear();
            foreach (MyNotes note in _notes)
            {
                NotesListBox.Items.Add(note.NoteTitle);
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


