using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = 0;
            Person Gamer = new Person();
            Game ThisGame = new Game(Gamer);

            Console.WriteLine(" Вы запустили программу Чет-Нечет");

            try
            {
                do
                {
                    Console.Write(" Ваш баланс:  {0}\n На что вы делаете ставку? \n\t0 - Число нечетное \n\t1 - Число четное \n Ваше предположение (Введите одно значение 0 или 1): ", Gamer.GetPoints());
                    Gamer.SetGuess(int.Parse(Console.ReadLine()));

                    Console.Write(" Ваша ставка: ");
                    Gamer.SetBet(int.Parse(Console.ReadLine()));
                    int num = rnd.Next(1000);

                    switch (ThisGame.Verify(num))
                    {
                        case true:
                            ThisGame.Win();
                            break;
                        case false:
                            ThisGame.Loose();
                            break;
                    }
                    Console.WriteLine(" Загаданное число: {0}", num);

                    if (Gamer.GetPoints() > 0)
                    {
                        Console.Write("Хотите продолжить играть? \n\t0 - Нет \n\t1 - Да \n Ваш ответ (Введите одно значение 0 или 1): ");
                        a = ThisGame.Continue(int.Parse(Console.ReadLine()));
                    }
                    Console.Clear();

                } while ((a == 1));

                Console.WriteLine("\n\tИгра окончена! Ваш счет {0}", Gamer.GetPoints());
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }

        }
    }
}
