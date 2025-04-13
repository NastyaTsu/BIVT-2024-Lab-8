using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_3 : Blue
    {
        private (char, double)[] _output;
        public (char, double)[] Output => _output;
        public Blue_3(string input) : base(input)
        {
            _output = new (char, double)[0];
        }
        private int kol_words(string input)
        {
            string[] words = input.Split(' ');
            return words.Length;
        }
        private (char, double)[] sort((char, double)[] input)
        {
            if (input == null) return input;
            (char, double)[] result = input.OrderByDescending(t => t.Item2).ThenBy(t => t.Item1).ToArray();
            return result;
        }
        public override void Review()
        {
            if (String.IsNullOrEmpty(Input)) return;
            int kolvo = 0;
            string[] words = Input.Split(' ', '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/');
            if (words.Length == 0) return;
            (char, double)[] result = new (char, double)[words.Length];
            int ind = 0;
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    char bukva = char.ToLower(word[0]);
                    bool found = false;
                    for (int i = 0; i < ind; i++)
                    {
                        if (char.IsLetter(result[i].Item1))
                        {
                            if (result[i].Item1 == bukva)
                            {
                                result[i] = (bukva, result[i].Item2 + 1);
                                found = true;
                                kolvo++;
                                break;
                                
                            }
                        }
                    }
                    if (!found && char.IsLetter(bukva))
                    {
                        result[ind] = (bukva, 1);
                        ind++;
                        kolvo++;
                    }
                }
            }
            _output = new (char, double)[ind];

            for (int i = 0; i < ind; i++)
            {
                _output[i] = (result[i].Item1, (double)result[i].Item2 / kolvo * 100);
            }

            _output = sort(_output);
        }

        public override string ToString()
        {
            if (_output == null) return null;
            var sb = new StringBuilder();
            foreach (var pair in _output)
            {
                sb.AppendLine($"{pair.Item1} - {pair.Item2:F4}");
            }
            return sb.ToString().Trim();
        }
    }
}
