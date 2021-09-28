using System;


namespace TicTocToe
{
    class TicTocToe
    {
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
