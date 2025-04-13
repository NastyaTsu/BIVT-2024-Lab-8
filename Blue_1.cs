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
            _output = new string[300];
        }
        public override void Review()
        {
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
                    _output[coint] = currentLine.ToString(); 
                    coint++;
                    currentLine.Clear();
                    currentLine.Append(word); 
                }
            }
            if (currentLine.Length > 0)
            {
                _output[coint] = currentLine.ToString();
                coint++;
            }
            Array.Resize(ref _output, coint);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, _output);
        }
    }
}
