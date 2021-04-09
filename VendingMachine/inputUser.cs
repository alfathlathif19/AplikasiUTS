using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class inputUser : uangKembalian
    {
        public void menu()
        {
            Console.WriteLine("Semua minuman memiliki harga 10 ribu rupiah");
            Console.WriteLine("------------------");
            Console.WriteLine("-- 1. Fanta     --");
            Console.WriteLine("-- 2. Sprite    --");
            Console.WriteLine("-- 3. Teh Pucuk --");
            Console.WriteLine("------------------");
            Console.WriteLine("Masukan pilihan minuman anda sesuai dengan kode nomor yang tertera : ");
            pilihanUser(Convert.ToChar(Console.ReadLine()));
        }

        private void pilihanUser(char pilihanMinuman)
        {
            bool _pilihanMinuman = false;
            while (!_pilihanMinuman)
            {
                switch (pilihanMinuman)
                {
                    case '1':
                        kembalian();
                        _pilihanMinuman = true;
                        break;
                    case '2':
                        kembalian();
                        _pilihanMinuman = true;
                        break;
                    case '3':
                        kembalian();
                        _pilihanMinuman = true;
                        break;
                    default:
                        Console.WriteLine("Kode minuman yang dimasukan salah, perhatikan kode minuman yang tertera");
                        pilihanUser(Convert.ToChar(Console.ReadLine()));
                        _pilihanMinuman = false;
                        break;
                }
            }
        }
    }
}
