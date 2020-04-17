using System;
using System.Collections.Generic;
using System.Text;

namespace OddOrEven
{
    class Game
    {
        Person Gamer;

        public Game(Person a)
        {
            Gamer = a;
        }
        public bool Verify(int a)
        {
            return ((a % 2) == 0)== Gamer.GetGuess();
        }
        public void Win()
        {
            Gamer.ChangePoitns(Gamer.GetBet());
            Console.WriteLine(" Вы угадали!\n\tВаш баланс: {0}", Gamer.GetPoints() );
        }
        public void Loose()
        {
            Gamer.ChangePoitns(-1*Gamer.GetBet());
            Console.WriteLine(" Вы не угадали!\n\tВаш баланс: {0}", Gamer.GetPoints());
        }
        public int Continue(int a)
        {
            if ((a != 0) & (a != 1))
                throw new Exception("\n\t\tНекорректный ввод!");
            return a;
        }
    }
}
