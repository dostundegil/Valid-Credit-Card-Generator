using System;
using System.Collections.Generic;
using System.Text;

namespace Kredi_Kartı
{
    abstract class krediKartı
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int Point { get; set; }
        public abstract string CardNumber { get; set; }
        public abstract string Name_surname { get; set; }
        public abstract int cvv { get; set; }
        public abstract string date { get; set; }

        public abstract int harca(int a, ref int puan);
        public abstract int borc_ode(int a);
    }
}
