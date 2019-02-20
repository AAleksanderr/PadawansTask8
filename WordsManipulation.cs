using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null) throw new ArgumentNullException();
            if (text == "") throw new ArgumentException();

            //Create array words
            var values = text.Split(new[] {'.', ',', '!', '?', '-', ':', ';', ' '},
                StringSplitOptions.RemoveEmptyEntries);

            //Create array strings between words
            var marks = new string[values.Length + 1];
            var pos = 0;
            for (var i = 0; i < values.Length; i++)
            {
                var pos2 = text.IndexOf(values[i], pos, StringComparison.Ordinal);
                marks[i] = text.Substring(pos, pos2 - pos);
                pos = pos2 + values[i].Length;
            }

            marks[values.Length] = text.Substring(pos, text.Length - pos);

            //Delete duplicate
            for (var i = 0; i <= values.Length - 2; i++)
            for (var j = i + 1; j < values.Length; j++)
                if (values[i] == values[j])
                    values[j] = "";

            //Collect a new line
            text = "";
            for (var i = 0; i < values.Length; i++) text += marks[i] + values[i];
            text += marks[marks.Length - 1];
        }
    }
}