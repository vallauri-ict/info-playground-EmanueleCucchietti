using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataOra;

namespace DataOra
{
    public class DataOra : Data
    {
        private int Ore { get; set; }
        private int Minuti { get; set; }
        private int Secondi { get; set; }
        public DataOra()
        {
            this.Giorno = 1;
            this.Mese = 1;
            this.Anno = 1900;
        }
        public DataOra(int giorno, int mese, int anno)
        {
            this.Giorno = giorno;
            this.Mese = mese;
            this.Anno = anno;
        }
        public DataOra(int giorno, int mese, int anno, int ore, int minuti, int secondi)
        {
            this.Giorno = giorno;
            this.Mese = mese;
            this.Anno = anno;
            this.Ore = ore;
            this.Minuti = minuti;
            this.Secondi = secondi;
        }
        public override string ToString()
        {
            return (Giorno + "/" + Mese + "/" + Anno + ":" + Ore + "." + Minuti + "." + Secondi).ToString();
        }
        public virtual void leggi()
        {
            throw new NotImplementedException();
        }
        public virtual void scrivi(int giorno, int mese, int anno, int ore, int minuti, int secondi)
        {
            this.Giorno = giorno;
            this.Mese = mese;
            this.Anno = anno;
            this.Ore = ore;
            this.Minuti = minuti;
            this.Secondi = secondi;
        }
    }
}
