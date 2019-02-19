using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null) throw new ArgumentNullException();
            var values = text.Split(new[] {'.', ',', '!', '?', '-', ':', ';', ' '},
                StringSplitOptions.RemoveEmptyEntries);
            var marks = text.Split(values, StringSplitOptions.None);
            for (var i = 0; i <= values.Length - 2; i++)
            for (var j = i + 1; j < values.Length; j++)
                if (values[i] == values[j])
                    values[j] = "";
            var str = "";
            for (var i = 0; i < values.Length; i++) str += marks[i] + values[i];
            str += marks[marks.Length - 1];
            text = str;
        }
    }
}