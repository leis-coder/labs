﻿using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book b1 = new Book();
            //b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2018);
            //b1.Print();
            //Console.WriteLine("\n Итоговая стоимость аренды: {0} p.", b1.PriceBook(3));

            //Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            //b3.Print();

            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));

            Book b2 = new Book("Толстой Л.Н.", "Война и мир",
                publ, 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Print();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.TakeItem();
            mag1.Print();

            Console.WriteLine("\n Тестирование полиморфизма");
            b2.ReturnSrok();
            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Print();

            it = mag1; 
            it.TakeItem();
            it.Return();
            it.Print();
        }
    }
}
