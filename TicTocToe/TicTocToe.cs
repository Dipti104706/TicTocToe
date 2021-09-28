using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    class TicTocToe
    {
        public char[] CreatingBoard()
        {
            char[] array = new char[10];
            for (int i = 1; i == array.Length; i++)
            {
                array[i] = ' ';
            }
            return array;
        }
    }
}
