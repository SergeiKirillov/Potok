using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace поток_Пример_ProDave
{
    class Program
    {
        static void Main(string[] args)
        {
            clDS ds = new clDS();
            Thread thds = new Thread(ds.StartDS);
            thds.Start();

            clStan st = new clStan();
            Thread thst = new Thread(st.StartStan);
            thst.Start();

            while (true)
            {
                Thread.Sleep(5000);
                Console.WriteLine("Main .....");
            }

        }
    }
}
