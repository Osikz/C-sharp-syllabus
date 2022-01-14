using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class Methods
    {
        public static int LineCounter(List<string> textList)
        {
            return textList.Count;
        }

        public static int WordCounter(List<string> textList)
        {
            var words = 0;
            foreach (var line in textList)
            {
                var word = line.Replace("'", " ").Split(' ');
                words += word.Length;
            }

            return words;
        }

        public static int LetterCounter(List<string> textList)
        {
            var chars = 0;
            foreach (var line in textList)
            {
                var trim = line.Replace(" ", "");
                var charArray = trim.ToCharArray();
                chars += charArray.Length;
            }

            return chars;
        }
    }
}
