using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace поток_Пример_ProDave
{
    class clDS
    {
        public void StartDS()
        {
            Thread ds70 = new Thread(dsPLC);
            ds70.Start();

            Thread ds80 = new Thread(dsSQL80);
            ds80.Start();

            Thread ds1c = new Thread(dsSQL1s);
            ds1c.Start();

            Thread dsMes = new Thread(dsMessage200);
            dsMes.Start();

            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Start DS........");
            }
        }

        private void dsPLC()
        {
            while (true)
            {
                Thread.Sleep(70);
                Console.Write("70");
            }
            
        }

        private void dsSQL80()
        {
            while (true)
            {
                Thread.Sleep(80);
                Console.Write("80");
            }

        }

        private void dsSQL1s()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.Write("1C");
            }

        }

        private void dsMessage200()
        {
            while (true)
            {
                Thread.Sleep(200);
                Console.Write("200");
            }

        }
    }
}
