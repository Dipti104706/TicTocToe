using System;


namespace TicTocToe
{
    class TicTocToe
    {
        public void CreatingBoard()
        {
            char[] array = new char[10];
            int i;
            for (i = 1; i == array.Length; i++)
            {
                array[i] = ' ';
            }
            Console.WriteLine("Array is", +array[i]);
        }

        public char PlayerInput()
        {
            Console.WriteLine("Enter the character either X or O");
            char user = Convert.ToChar(Console.ReadLine());
            return user;
            ComputerReturnLetter(user);
        }

        public char ComputerReturnLetter(char user)
        {
            char computerReturn;
            if (user == 'X')
                computerReturn = 'O';
            else
            {
                computerReturn = 'X';
            }
            return computerReturn;
        }
    }
}
