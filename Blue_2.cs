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
        public Blue_2(string delet, string input) : base(input)
        {
            _delet = delet;
            _output = input;
        }
        public string Output => _output;
        public override void Review()
        {
            if (string.IsNullOrEmpty(_delet) || string.IsNullOrEmpty(_output)) return;
            string[] words = _output.Split(' ');
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
                else if (word.Length > 0 && char.IsPunctuation(word[word.Length - 1]))
                {
                    result.Append(word[word.Length - 1]);
                }
            }

            _output = result.ToString();
        }
        public override string ToString()
        {
            if (Input == null || Input == "") return null;
            return _output;
        }
    }
}
