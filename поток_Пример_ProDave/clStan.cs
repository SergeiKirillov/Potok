using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace поток_Пример_ProDave
{
    class clStan
    {
        public void StartStan()
        {
            //Начало

            Thread st100 = new Thread(stPLC);
            st100.Start();

            Thread st101 = new Thread(stSQL101);
            st101.Start();

            Thread st1c = new Thread(stSQL1s);
            st1c.Start();

            Thread stMes = new Thread(stMessage200);
            stMes.Start();

            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Start Stan........");
            }
        }

        private void stPLC()
        {
            while (true)
            {
                Thread.Sleep(100);
                Console.Write("-s100-");
            }

        }

        private void stSQL101()
        {
            while (true)
            {
                Thread.Sleep(101);
                Console.Write("-s101-");
            }

        }

        private void stSQL1s()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.Write("-s1C-");
            }

        }

        private void stMessage200()
        {
            while (true)
            {
                Thread.Sleep(200);
                Console.Write("-s200-");
            }

        }
    }
}
