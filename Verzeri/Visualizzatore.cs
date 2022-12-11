using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verzeri
{
    public class Visualizzatore
    {
        private Verifica[] _elenco = new Verifica[100];
        private int contatore=0;
        
        public Verifica[] elenco
        {
            get { return _elenco; }
            set { _elenco = value; }
        }
        public void Aggiungi(Verifica verifica)
        {
            elenco[contatore] = verifica;
            contatore++;
        }
        public string Visualizza()
        {
            string visualizza = "";
            for (int i = 0; i < contatore; i++)
            {
                visualizza += elenco[i].ToString();
            }
            return visualizza;
            
        }
        public float Media(string materia)
        {
            float a = 0;
            float somma = 0;
            float media = 0;
            for(int i = 0; i < contatore; i++)
            {
                if (materia == elenco[i].Materia)
                {
                    somma += elenco[i].Valutazione;
                    a++;
                }
            }
            media = somma / a;
            return media;
        }
        public int ricercaid(Verifica verifica)
        {
            for (int i = 0; i < contatore-1; i++)
            {
                if (verifica.Id == elenco[i].Id)
                {
                    return contatore;
                }
            }
            return -1;
        }
        public void Elimina(Verifica verifica)
        {
            int pos = ricercaid(verifica);
            if (pos != -1)
            {
                for (int i = pos; i < contatore - 1; i++)
                {
                    
                    elenco[i] = elenco[i + 1];
                    elenco[i].ricompattaid();
                }
            }
            else
            {
                throw new Exception("prodotto non trovato");
            }
        }
        /*public void Modifica(int v)
        {
            
            if (v != -1)
            {
                 elenco[pos].Valutazione = v; 
            }
            else
            {
                throw new Exception("prodotto non trovato");
            }
        }*/
    }
}
