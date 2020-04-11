using System;

namespace OddOrEven
{
    class Program
    {
        static public bool Check(int a)
        {
            return (a % 2) == 0;
        }

        static public bool Verify(bool a, bool b)
        {
            return a == b;
        }

        static public bool ITB(int a)
        {
            if (a == 1)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int points = 100;
            bool guess;
            int bet;
            Random rnd = new Random();
            int a = 1;
            int temp;

            Console.WriteLine(" Вы запустили программу Чет-Нечет");

            try
            {
                do
                {
                    Console.Write(" Ваш баланс:  {0}\n На что вы делаете ставку? \n\t0 - Число нечетное \n\t1 - Число четное \n Ваше предположение (Введите одно значение 0 или 1): ", points);
                    temp = int.Parse(Console.ReadLine());
                    if ((temp == 0) | (temp == 1))
                        guess = ITB(temp);
                    else throw new Exception("\n\t\tНекорректный ввод!");
                    Console.Write(" Ваша ставка: ");
                    bet = int.Parse(Console.ReadLine());
                    int num = rnd.Next(1000);

                    switch (Verify(Check(num), guess))
                    {
                        case true:
                            points += bet;
                            Console.WriteLine(" Вы угадали! Исходное число: {0} \n\tВаш баланс: {1}", num, points);
                            break;
                        case false:
                            points -= bet;
                            Console.WriteLine(" Вы не угадали! Исходное число: {0} \n\tВаш баланс: {1}", num, points);
                            break;
                    }

                    if (points > 0)
                    {
                        Console.Write("Хотите продолжить играть? \n\t0 - Нет \n\t1 - Да \n Ваш ответ (Введите одно значение 0 или 1): ");
                        a = int.Parse(Console.ReadLine());
                        if ((temp != 0) | (temp != 1))
                            throw new Exception("\n\t\tНекорректный ввод!");
                    }

                    Console.Clear();
                } while ((a == 1) && (points > 0));

                Console.WriteLine("\n\tИгра окончена! Ваш счет {0}", points);
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }

        }
    }
}
