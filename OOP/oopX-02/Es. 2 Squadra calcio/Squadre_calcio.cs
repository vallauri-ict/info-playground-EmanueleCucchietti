using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es._2_Squadra_calcio
{
    class Squadre_calcio
    {

        public string nome;
        public string citta;
        public int giocate;
        public int vinte;
        public int pareggiate;

        private int miaProperty;
        private int miaPropertyRO;
        public readonly int solalettura;//può essere modificato solo nella dichiarazione e nel costruttore

        public int MiaProperty
        {
            get
            {
                return miaProperty;
            }
            set
            {
                miaProperty = value;
            }
        }
        public int MiaPropertyRo
        {
            get
            {
                return miaPropertyRO;
            }
        }
        public Squadre_calcio(string nome, string citta, int giocate, int vinte, int pareggiate)
        {
            solalettura = 5;
            this.nome = nome;
            this.citta = citta;
            this.giocate = giocate;
            this.vinte = vinte;
            this.pareggiate = pareggiate;
            MiaProperty = 0;
        }

        public Squadre_calcio()
        {

        }
    }
}
