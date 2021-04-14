using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsGioco
{
    public class CombattimentoClasse
    {
        public Personaggio P1
        {
            get => default;
            set
            {
            }
        }

        public Personaggio P2
        {
            get => default;
            set
            {
            }
        }

        public Arma ArmaP1
        {
            get => default;
            set
            {
            }
        }

        public Arma ArmaP2
        {
            get => default;
            set
            {
            }
        }

        public Personaggio Vincitore
        {
            get => default;
            set
            {
            }
        }

        public Personaggio Perdente
        {
            get => default;
            set
            {
            }
        }

        public void AttaccoP1()
        {
            throw new System.NotImplementedException();
        }

        public void AttaccoP2()
        {
            throw new System.NotImplementedException();
        }

        public void SchivaP1()
        {
            throw new System.NotImplementedException();
        }

        public void SchivaP2()
        {
            throw new System.NotImplementedException();
        }

        public void TogliVita(ref Personaggio p, int q)
        {
            if (p.PuntiVita - q <= 0)
            {
                throw new Exceprions.PersonaggioSenzaVitaException(p, q);
            }

            p.PuntiVita -= q;
        }
    }
}