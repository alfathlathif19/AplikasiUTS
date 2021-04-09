using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Money
    {
        //public int value { get; set; }
        private int _value = 0;

        public int GetValue()
        {
            return _value;
        }

        internal void SetValue(int value)
        {
            _value = value;
        }
    }
}
