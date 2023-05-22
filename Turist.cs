using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_TravelAgency
{
    [Serializable]
    public class Turist : ICloneable, IComparable
    {
        String userName;
        String parola;
        List<Cazare> vacante = null;

        #region Constructori
        public Turist()
        {
            this.userName = "anonim@gmail.com";
            this.parola = "neparolat";
        }

        public Turist(string userName, string parola)
        {
            this.userName = userName;
            this.parola = parola;
        }

        public Turist(String userName, String parola, List<Cazare> rezervari)
        {
            this.userName = userName;
            this.parola = parola;
            if(rezervari != null )
            {
                this.vacante = new List<Cazare>(rezervari.Count);
                for (int i = 0; i < rezervari.Count; i++)
                {
                    Cazare c = (Cazare)rezervari[i].Clone();
                    this.vacante.Add(c);
                }
            }
        }
        #endregion

        #region Setteri_si_Getteri

        public String UserName
        {
            get { return userName; }
            set
            {
                this.userName = value;
            }
        }

        public String Parola
        {
            get { return parola; }
            set { this.parola = value; }
        }

        public List<Cazare> Vacante
        {
            get
            {
                List<Cazare> copie = new List<Cazare>(this.vacante.Count);
                for (int i = 0; i < this.vacante.Count; i++)
                {
                    Cazare c = (Cazare)this.vacante[i].Clone();
                    copie.Add(c);
                }
                return copie;
            }
            set
            {
                if (value != null)
                {
                    this.vacante = new List<Cazare>(value.Count);
                    for (int i = 0; i < value.Count; i++)
                    {
                        Cazare c = (Cazare)value[i].Clone();
                        this.vacante.Add(c);
                    }
                }
            }
        }



        #endregion

        #region CloneMethod
        public object Clone()
        {
            Turist t = this.MemberwiseClone() as Turist;
            t.userName= userName;
            t.parola= parola;
            if(this.vacante!= null)
            {
                t.vacante = new List<Cazare>(this.vacante.Count);
                for (int i = 0; i < this.vacante.Count; i++)
                {
                    Cazare c = (Cazare)this.vacante[i].Clone();
                    t.vacante.Add(c);
                }
            }
            else
            {
                t.vacante = null;
            }

            return t;
        }


        #endregion

        #region toCompareMethod
        public int CompareTo(object obj)
        {
            Turist t= obj as Turist;
            if (this.vacante != null && t.vacante != null)
            {
                if (this.vacante.Count > t.vacante.Count)
                {
                    return 1;
                }
                else if (this.vacante.Count == t.vacante.Count)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (this.vacante == null && t.vacante == null)
                {
                    return 0;
                }
                else
                {
                    throw new Exception("Compari cu un null");
                }
            }
        }

        #endregion

        #region toString

        public override string ToString()
        {
            String text = "Turistul se numeste " + this.userName + " si are parola " + this.parola;
            return text;
        }

        #endregion

        #region methodAddCazare

        public void addCazare(Cazare c)
        {
            this.vacante.Add(c);
        }

        #endregion

    }

}
