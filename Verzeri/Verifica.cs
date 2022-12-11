using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verzeri
{
    public class Verifica
    {
        private int _id;
        private string _materia;
        private float _valutazione;
        private string _data;
        public Verifica(int id, string materia, float valutazione, string data)
        {
            _id = id;
            _materia = materia;
            _valutazione = valutazione;
            _data = data;
        } 
        public int Id 
        { 
            get { return _id; } 
            private set { _id = value; }
        }
        public string Materia
        {
            get { return _materia; }
            private set { _materia = value; }
        }
        public float Valutazione
        {
            get { return _valutazione; }
            private set
            {
                _valutazione = value;
            }
        }
        public string Data
        {
            get { return _data; }
            private set
            {
                _data = value;
            }
        }
        
        
        public void modifica( int nuovavalutazione)
        {
            
                if (nuovavalutazione>0 && nuovavalutazione<=10)
                {
                    Valutazione = nuovavalutazione;
                }
            
            
        }
        public void ricompattaid()
        {
            Id = Id + 1;
        }
        public override string ToString()
        {
            return Id + ";" + Materia + ";" + Valutazione + ";" + Data + "\n";
        }
    }
}
