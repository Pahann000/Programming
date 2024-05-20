internal class NotesValidator
{
    public static string LengthValidator(int minLength, int maxLength, string value)
    {
        if (value.Length > minLength && value.Length < maxLength) { return value; }
        else { throw new ArgumentException(nameof(value)); }
    }
}
