using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_8
{
    public class Blue_2 : Blue
    {
        private string _delet;
        private string _output;
        public string Delet => _delet;
        public string Output => _output;
        public Blue_2(string input, string delet) : base(input)
        {
            _delet = delet;
            _output = null;
        }
        public override void Review()
        {
            if (string.IsNullOrEmpty(Input) || string.IsNullOrEmpty(_delet))
            {
                _output = string.Empty;
                return;
            }
            string[] words = Input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var result = new StringBuilder();
            foreach (string word in words)
            {
                if (!word.ToLower().Contains(_delet.ToLower()))
                {
                    if (result.Length > 0)
                    {
                        result.Append(" ");
                    }
                    result.Append(word);
                }
                else if (word.ToLower().Contains(_delet.ToLower()))
                {
                    if (word.Length > 0 && char.IsPunctuation(word[0]))
                    {
                        if (result.Length > 0)
                        {
                            result.Append(" ");
                        }
                        result.Append(word[0]);
                    }
                    if (word.Length > 0 && char.IsPunctuation(word[word.Length - 2]))
                    {
                        result.Append(word[word.Length - 2]);
                    }
                    if (word.Length > 0 && char.IsPunctuation(word[word.Length - 1]))
                    {
                        result.Append(word[word.Length - 1]);
                    }
                }
            }


            _output = result.ToString().Trim();
        }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(_output))
                return string.Empty;

            return _output;
        }
    }
}
