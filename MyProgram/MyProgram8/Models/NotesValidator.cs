using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram8.Models
{
    internal class NotesValidator
    {
        public static string LengthValidator(int minLength, int maxLength, string value)
        {
            if (value.Length> minLength && value.Length< maxLength) { return value; }
            else { throw new ArgumentException(nameof(value)); } 
        } 
    }
}
