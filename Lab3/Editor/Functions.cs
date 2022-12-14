using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab3.Editor
{
    static public class Functions
    {
        static public IEnumerable<Tuple<string, int>> MostCommonWords(string text)
        {
            var words = new Dictionary<string, int>();
            foreach (string word in text.Split((char[])null, StringSplitOptions.RemoveEmptyEntries))
            {
                if (words.ContainsKey(word.ToLower()))
                    words[word.ToLower()]++;
                else
                    words[word.ToLower()] = 1;
            }

            var top = words
                .Where(p => p.Key.All(c => 'a' <= c && c <= 'z'))
                .OrderBy(p => p.Value)
                .Take(5)
                .Select(p => new Tuple<string, int>( p.Key, p.Value));
            return top;
        }

        static public string RemoveWhitespaces(string text)
        {
            text = text.Replace("\t", "    ");
            text = Regex.Replace(text, " {2,}", " ");
            text = Regex.Replace(text, "[\n]{2,}", "\n");
            text = Regex.Replace(text, "[\r]{2,}", "\r");
            text = Regex.Replace(text, "(\r\n){2,}", "\r\n");
            text = Regex.Replace(text, "(\n\r){2,}", "\n\r");
            text = String.Join("\r\n", text.Split("\r\n").Select(w => w.Trim()));
            return text;
        }
    }
}
