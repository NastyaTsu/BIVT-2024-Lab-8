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
            _output = null;
        }
        public string Output => _output;
        public override void Review()
        {
            string[] words = Input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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

            _output = result.ToString().Trim();
        }
        public override string ToString()
        {
            return _output;
        }
    }
}
