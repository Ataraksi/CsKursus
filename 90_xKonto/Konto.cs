using System;
using System.Collections.Generic;
using System.Text;

namespace _90_xKonto
{
    public class Konto
    {
        private List<Transaktion> transaktioner;

        public Konto()
        {
            transaktioner = new List<Transaktion>();
        }

        public void TilføjTransaktion(Transaktion t)
        {
            transaktioner.Add(t);
            //Log
            //Sikkerhed
            //Validering
        }

        public decimal Saldo()
        {
            decimal sum = 0;
            foreach (var item in transaktioner)
            {
                sum = sum + item.beløb;
            }
            return sum;
        }
    }
}
