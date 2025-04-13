using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_4 : Blue
    {
        private int _output;
        public int Output => _output;
        public Blue_4(string input) : base(input)
        {
            _output = 0;
        }
        public override void Review()
        {
            string numbers = "";
            foreach (char simvol in Input)
            {
                if (char.IsDigit(simvol))
                {
                    numbers += simvol;
                }
                else
                {
                     if (numbers.Length > 0)
                    {
                        int count = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            count = count * 10 + (numbers[i] - '0');
                        }
                        _output += count;
                        numbers = "";
                    }
                }
            }
            if (numbers.Length > 0)
            {
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    count = count * 10 + (numbers[i] - '0');
                }
                _output += count;
            }
        }

        public string ToString()
        {
            return "" + _output;
        }
    }
}
