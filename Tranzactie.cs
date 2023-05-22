using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_TravelAgency
{

    [Serializable]
    public class Tranzactie: ICloneable, IComparable<Tranzactie>
    {
        private float pret;
        private float avans;
        private bool platitIntegral;

        #region Constructori
        public Tranzactie()
        {
            this.avans = 0;
            this.pret = 0;
            this.platitIntegral = false;
        }

        public Tranzactie (float pret)
        {
            this.pret = pret;
        }

        public Tranzactie(float pret, float avans, bool platitIntegral)
        {
            this.pret = pret;
            this.avans = avans;
            this.platitIntegral = platitIntegral;
        }
        #endregion

        #region equals
        public override bool Equals(object obj)
        {
            Tranzactie t = (Tranzactie)obj;
            if(t.platitIntegral == this.platitIntegral && t.avans == this.avans && t.pret == this.pret)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region toString
        public override string ToString()
        {
            String text = "";
            if(this.platitIntegral == true)
            {
                text += "Tranzactia s-a realizat in mod integral";
            }
            else
            {
                text += "In momentul de fata a fost achitat avansul in valoare de " + this.avans.ToString() + " dintr-un total de " + this.pret.ToString() + "\n";
            }
            return text;
        }
        #endregion

        #region clone
        public object Clone()
        {
            var clone = this.MemberwiseClone() as Tranzactie;
            clone.pret= this.pret;
            clone.avans= this.avans;
            return clone;
        }
        #endregion

        #region compareTo
        public int CompareTo(Tranzactie other)
        {
            if (other.avans > this.avans) return -1;
            else if (other.avans == this.avans) return 0;
            else return 1;
        }
        #endregion

        #region MetodeAccesore
        public float Pret { set { this.pret = value; } get { return this.pret; } }
        public float Avans { set { this.avans = value; } get { return this.avans; } }
        #endregion

        #region PlatitIntegralMethod
        public bool PlatitIntegral { set { this.platitIntegral = value; } get {
                return this.platitIntegral;
            } 
        }
        #endregion

    }
}
