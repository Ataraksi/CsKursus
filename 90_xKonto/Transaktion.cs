using System;
using System.Collections.Generic;
using System.Text;

namespace _90_xKonto
{
    public class Transaktion
    {
        //Felter
        public DateTime dato;
        public string tekst;
        public decimal beløb;

        public Transaktion(DateTime dato, string tekst, decimal beløb)
        {
            //Validering
            this.dato = dato;
            this.tekst = tekst;
            this.beløb = beløb;
        }
    }
}
