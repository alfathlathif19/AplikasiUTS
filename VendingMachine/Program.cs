using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int uangPembelian;
            inputMoney _inputMoney = new inputMoney();
            Money money = new Money();
            while (money.GetValue() == 0)
            {
                Console.WriteLine("Masukan uang anda dengan nominal 10, 20, 50, atau 100");
                uangPembelian = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(money.GetValue());
                _inputMoney.totalUang(money.uangPembelian);
            }

            Console.WriteLine(money.GetValue());

            inputUser pembeli = new inputUser();
            pembeli.menu();
        }
    }
}
