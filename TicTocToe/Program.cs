﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTocToe");
            TicTocToe ticToc = new TicTocToe();
            ticToc.PlayerInput();
            Console.ReadLine();
        }
    }
}
