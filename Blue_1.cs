using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_1 : Blue
    {
        private string[] _output;
        public string[] Output => _output;
        public Blue_1(string input) : base(input) 
        {
            _output = null;
        }
        public override void Review()
        {
            if (String.IsNullOrEmpty(Input)) return;
            string[] resalt = new string[500];
            var words = Input.Split(' ');
            int coint = 0;
            var currentLine = new StringBuilder();

            foreach (var word in words)
            {
                if (currentLine.Length + word.Length + 1 <= 50) 
                {
                    if (currentLine.Length > 0)
                    {
                        currentLine.Append(' '); 
                    }
                    currentLine.Append(word);
                }
                else
                {
                    resalt[coint] = currentLine.ToString(); 
                    coint++;
                    currentLine.Clear();
                    currentLine.Append(word); 
                }
            }
            if (currentLine.Length > 0)
            {
                resalt[coint] = currentLine.ToString();
                coint++;
            }
            Array.Resize(ref resalt, coint);
            _output = resalt;
                
        }
        public override string ToString()
        {
            if (_output == null || _output.Length == 0) return null;
            return string.Join(Environment.NewLine, _output);
        }
    }
}
