using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace EsGioco
{
    public class Personaggio : IEquatable<Personaggio>
    {
        private string _nome;
        private int _puntiVita;
        private string _percorsoImmagine;
        private List<Arma> _listaArmi;
        private List<Animazione> _listaAnimazioni;
        private int _puntiForzaBase;
        private bool _salta, _sinistra, _destra;
        private int _velocitaSalto, _gravita, _velocitaPersonaggio;

        public Personaggio(string nome, int puntiVita, string percorsoImmagine, List<Arma> listaArmi, List<Animazione> listaAnimazioni, int puntiForzaBase, bool schiva = false)
        {
            Nome = nome;
            PuntiVita = puntiVita;
            PercorsoImmagine = percorsoImmagine;
            ListaArmi = listaArmi;
            ListaAnimazioni = listaAnimazioni;
            PuntiForzaBase = puntiForzaBase;
            Salta = false;
            Sinistra = false;
            Destra = false;
        }

        public Personaggio()
        {
            VelocitaSalto = 8;
            Gravita = 10;
            VelocitaPersonaggio = 8;

            Salta = false;
            Sinistra = false;
            Destra = false;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                _nome = value;
            }
        }

        public string PercorsoImmagine
        {
            get
            {
                return _percorsoImmagine;
            }
            private set
            {
                _percorsoImmagine = value;
            }
        }

        public int PuntiVita
        {
            get
            {
                return _puntiVita;
            }
            set
            {
                _puntiVita = value;
            }
        }

        public List<Arma> ListaArmi
        {
            get
            {
                return _listaArmi;
            }
            private set
            {
                _listaArmi = value;
            }
        }

        public List<Animazione> ListaAnimazioni
        {
            get
            {
                return _listaAnimazioni;
            }
            private set
            {
                _listaAnimazioni = value;
            }
        }

        public int PuntiForzaBase
        {
            get
            {
                return _puntiForzaBase;
            }
            private set
            {
                _puntiForzaBase = value;
            }
        }

        public bool Salta
        {
            get
            {
                return _salta;
            }
            set
            {
                _salta = value;
            }
        }

        public bool Sinistra
        {
            get
            {
                return _sinistra;
            }
            set
            {
                _sinistra = value;
            }
        }

        public bool Destra
        {
            get
            {
                return _destra;
            }
            set
            {
                _destra = value;
            }
        }

        public int VelocitaSalto
        {
            get
            {
                return _velocitaSalto;
            }
            set
            {
                _velocitaSalto = value;
            }
        }

        public int Gravita
        {
            get
            {
                return _gravita;
            }
            set
            {
                _gravita = value;
            }
        }

        public int VelocitaPersonaggio
        {
            get
            {
                return _velocitaPersonaggio;
            }
            set
            {
                _velocitaPersonaggio = value;
            }
        }

        public bool Equals(Personaggio other)
        {
            return this.Nome.Equals(other.Nome);
        }
    }
}