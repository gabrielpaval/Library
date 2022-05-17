using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Carte
    {
        private
        string nume;
        string autor;
        string editura;
        int anAparitie;
        int nrExemplare;
        int idCarte;
        static int ID;

        public string Nume { get; set; }
        public string Autor { get; set; }
        public int Editura { get; set; }
        public int AnAparitie { get; set; }
        public string NrExemplare { get; set; }
      
       
        //Constructor fara parametrii
        public Carte()
        {
            nume = string.Empty;
            autor = string.Empty;
            editura = string.Empty;
            anAparitie = 0;
            nrExemplare = 0;
            ID = ID + 1;
        }
        //Constructor cu parametrii
        public Carte(string _nume, string _autor, string _editura, int _AnAparitie, int _NrExemplare)
        {
            nume = _nume;
            autor = _autor;
            editura = _editura;
            anAparitie = _AnAparitie;
            nrExemplare = _NrExemplare;
            ID = ID + 1;
        }

        public Carte(string sirr)
        {
            string[] buff = sirr.Split(',');
            nume = buff[0];
            autor = buff[1];
            editura = buff[2];
            anAparitie = Convert.ToInt32(buff[3]);
            nrExemplare = Convert.ToInt32(buff[4]);
            idCarte = ID;
            ID += ID;
        }

        public string ComparaCarte(Carte c2)
        {
            if (this.nrExemplare > c2.nrExemplare)
                return string.Format("Cartea cu numele {0} si ID-ul {1} este in mai multe exemplare ({2})", this.nume, this.idCarte, this.nrExemplare);
            else
            {
                if (this.nrExemplare == c2.nrExemplare)
                { return string.Format("Cele 2 carti sunt in acelasi numar de exemplare ({0})", this.nrExemplare); }
                else
                { return string.Format("Cartea cu numele {0} si ID-ul {1} este in mai multe exemplare ({2})", c2.nume, c2.idCarte, c2.nrExemplare); }
            }
        }


        public string Info()
        {
           return string.Format("Cartea cu numele {0}, scrisa de {1}, publicata la editura {2}, a aparut in anul {3} si o avem disponibila in {4} exemplare ( are ID-ul : {5}).", nume, autor, editura, anAparitie, nrExemplare, ID);
        }


    }
}
