using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FixedThreadPool
{
    class myThread
    {
        Thread thread;

        public myThread(string name, int num) //Конструктор получает имя функции и номер до кторого ведется счет
        {
            thread = new Thread(this.func);
            thread.Name = name;
            thread.Start(num);//передача параметра в поток
        }

        void func(object num)//Функция потока, передаем параметр
        {
            for (int i = 1; i <= (int)num; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + ": " + i);
                Thread.Sleep(0);
            }
        }

    }
}
