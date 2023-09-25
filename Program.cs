using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product hardDisk = new Product(50);
            hardDisk.ProductName = "Hard Disk";

            Product GSM = new Product(50);
            GSM.ProductName = "Telefon";
            GSM.StockControlEvent += GSM_StockControlEvent;//Event'e abone edip oluşturduğumuz event'i kullanabiliyoruz.

            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                GSM.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void GSM_StockControlEvent()
        {
            Console.WriteLine("GSM about to finnish!");
        }
    }
}
