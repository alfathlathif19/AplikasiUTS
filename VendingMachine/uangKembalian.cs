using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class uangKembalian
    {
        public int inisiasiUang { get; set; }

        public void kembalian()
        {
            if (inisiasiUang > 10)
            {
                Console.WriteLine("Kembalian anda \n{0}", inisiasiUang - 10);
            }
        }
    }
}
