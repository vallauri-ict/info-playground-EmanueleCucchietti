using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataOra;

namespace DataOra
{
    public class Data
    {
        string[] days = new string[] { "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato", "Domenica" };
        protected int Giorno { get; set; }
        protected int Mese { get; set; }
        protected int Anno { get; set; }
        public Data()
        {
            this.Giorno = 1;
            this.Mese = 1;
            this.Anno = 1900;
        }
        public Data(int giorno, int mese, int anno)
        {
            this.Giorno = giorno;
            this.Mese = mese;
            this.Anno = anno;
        }
        public override string ToString()
        {
            return (Giorno + "/" + Mese + "/" + Anno).ToString();
        }
        public virtual bool Bisestile()
        {
            return this.Anno/4==0 ? true : false;
        }
        public virtual void leggi()
        {
            throw new NotImplementedException();
        }
        public virtual void scrivi(int giorno, int mese, int anno)
        {
            this.Giorno=giorno;
            this.Mese = mese;
            this.Anno=anno;
        }
        public virtual void Domani()
        {
            DateTime date = new DateTime(Anno, Mese, Giorno);
            date.AddDays(1);
            Anno = date.Year;
            Mese = date.Month;
            Giorno = date.Day;
        }
        public virtual void Ieri()
        {
            DateTime date = new DateTime(Anno, Mese, Giorno);
            date.AddDays(-1);
            Anno = date.Year;
            Mese = date.Month;
            Giorno = date.Day;
        }
        public virtual string Oggi()
        {
            DateTime date = new DateTime(Anno, Mese, Giorno);
            return days[(int)date.DayOfWeek];
        }
    }
}
