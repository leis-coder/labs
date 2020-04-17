﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    public abstract class Item : IComparable
    {
        int IComparable.CompareTo(object obj) 
        {
            Item it = (Item)obj; 
            if (this.invNumber == it.invNumber) 
                return 0; 
            else if (this.invNumber > it.invNumber) 
                return 1; 
            else return -1;
        }
        // инвентарный номер — целое число 
        protected long invNumber;
        // хранит состояние объекта - взят ли на руки 
        protected bool taken;

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber; 
            this.taken = taken; 
        }

        public Item() 
        {
            this.taken = true; 
        }

        // истина, если этот предмет имеется в библиотеке  
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }

        // инвентарный номер
        public long GetInvNumber()
        {
            return invNumber;
        }
        // операция "вернуть"
        public abstract void Return();
        public virtual void Print()
        {
            Console.WriteLine("\nСостояние единицы хранения:\n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
        }
        // операция "взять"
        private void Take()
        {
            taken = false;
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }
    }
}
