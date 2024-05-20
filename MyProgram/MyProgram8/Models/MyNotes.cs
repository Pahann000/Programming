using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram8.Models
{
    /// <summary>
    /// 
    /// </summary>
    internal class MyNotes
    {
        /// <summary>
        /// 
        /// </summary>
        private string _noteTitle;

        /// <summary>
        /// 
        /// </summary>
        private string _noteText;

        /// <summary>
        /// 
        /// </summary>
        private DateTime _savingTime;

        /// <summary>
        /// 
        /// </summary>
        private string _noteCategory;

        /// <summary>
        /// 
        /// </summary>
        public string NoteTitle
        {
            get { return _noteTitle; }
            set { NotesValidator.LengthValidator(0, 100, value); _noteTitle = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NoteText
        {
            get { return _noteText; }   
            set { _noteText = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime SavingTime { get; }


        /// <summary>
        /// 
        /// </summary>
        public string NoteCategory
        {
            get { return NoteCategory; }
            set { NoteCategory = value; }
        }
        public MyNotes()
        {
            
        }



    }
}
