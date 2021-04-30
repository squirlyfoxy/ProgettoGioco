using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace EsGioco
{
    [XmlRoot(ElementName = "Personaggio")]
    public class Personaggio : IEquatable<Personaggio>
    {
        private string _nome;
        private int _puntiVita;
        private string _percorsoImmagine;
        private List<Arma> _listaArmi;
        private List<Animazione> _listaAnimazioni;
        private int _puntiForzaBase;
        private bool _schiva;

        public Personaggio(string nome, int puntiVita, string percorsoImmagine, List<Arma> listaArmi, List<Animazione> listaAnimazioni, int puntiForzaBase, bool schiva = false)
        {
            Nome = nome;
            PuntiVita = puntiVita;
            PercorsoImmagine = percorsoImmagine;
            ListaArmi = listaArmi;
            ListaAnimazioni = listaAnimazioni;
            PuntiForzaBase = puntiForzaBase;
            Schiva = schiva;
        }

        public Personaggio()
        {

        }

        [XmlElement(ElementName = "Nome")]
        public string Nome
        {
            get
            {
                return _nome;
            }
             set
            {
                _nome = value;
            }
        }

        [XmlElement(ElementName = "PercorsoImmagine")]
        public string PercorsoImmagine
        {
            get
            {
                return _percorsoImmagine;
            }
             set
            {
                _percorsoImmagine = value;
            }
        }

        [XmlElement(ElementName = "PuntiVita")]
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

        [XmlElement(ElementName = "ListaArmi")]

        public List<Arma> ListaArmi
        {
            get
            {
                return _listaArmi;
            }
             set
            {
                _listaArmi = value;
            }
        }

        [XmlElement(ElementName = "ListaAnimazioni")]

        public List<Animazione> ListaAnimazioni
        {
            get
            {
                return _listaAnimazioni;
            }
             set
            {
                _listaAnimazioni = value;
            }
        }

        [XmlElement(ElementName = "PuntiForzaBase")]

        public int PuntiForzaBase
        {
            get
            {
                return _puntiForzaBase;
            }
             set
            {
                _puntiForzaBase = value;
            }
        }

        [XmlIgnore]
        public bool Schiva
        {
            get
            {
                return _schiva;
            }
            set
            {
                _schiva = value;
            }
        }

        public bool Equals(Personaggio other)
        {
            return this.Nome.Equals(other.Nome);
        }
    }
}