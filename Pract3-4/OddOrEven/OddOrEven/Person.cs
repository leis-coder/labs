using System;
using System.Collections.Generic;
using System.Text;

namespace OddOrEven
{
    class Person
    {
        private int Points;
        private int Bet;
        private bool Guess;
        public Person()
        {
            Points = 100;
            Guess = true;
            Bet = 0;
        }
        public void SetPoints(int a)
        {
            Points = a;
        }
        public int GetPoints()
        {
            return Points;
        }
        public void ChangePoitns(int a)
        {
            Points += a;
        }
        static public bool ITB(int a)
        {
            if (a == 1)
                return true;
            else
                return false;
        }
        public void SetGuess(int temp)
        {
            if ((temp == 0) | (temp == 1))
                Guess = ITB(temp);
            else throw new Exception("\n\t\tНекорректный ввод!");
        }
        public bool GetGuess()
        {
            return Guess;
        }
        public void SetBet(int a)
        {
            Bet = a;
        }
        public int GetBet()
        {
            return Bet;
        }
    }
}
