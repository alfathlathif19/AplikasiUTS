using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class inputMoney : Money
    {
        const int HARGA_MINUMAN = 10;
        public int inisiasiUang{get; set;}

        public inputMoney()
        {
            inisiasiUang = 0;
        }

        public void totalUang(int money) 
        {
            switch (money)
            {
                case (10):
                    SetValue(GetValue() + 10);
                    break;
                case (20):
                    SetValue(GetValue() + 20);
                    break;
                case (50):
                    SetValue(GetValue() + 50);
                    break;
                case (100):
                    SetValue(GetValue() + 100);
                    break;
                default:
                    Console.WriteLine("Uang tidak bisa dimasukan, mohon ubah nominalnya");
                    break;
            };
        }
    }
}
