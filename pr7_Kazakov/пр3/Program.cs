using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр3
{
    static class Program
    {
       
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ima());
            

        }
    }
    public static class Transfer //Создаем класс с названием Transfer
        {
            public delegate void callbackEvent(string[] name, string[] price); //Какие данные он примет.
            public static callbackEvent callbackEventHandler;           //Событие для вызова делегата
        }
}
