using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_TravelAgency
{
    [Serializable]
    public class Serviciu:IComparable, ICloneable
    {
        private String denumire;
        private float pret;

        #region Constructori
        public Serviciu() { 
            this.pret = 0;
            this.denumire = "serviciu";
        }
      

        public Serviciu(string denumire, float pret)
        {
            this.denumire = denumire;
            this.pret = pret;
        }
        #endregion

        #region Getteri_si_Setteri
        public String Denumire { set { denumire = value; } get { return denumire; } }
        public float Pret { get { return this.pret; }  set { this.pret = value; } }
        #endregion

        #region clone
        public object Clone()
        {
            var clone = this.MemberwiseClone() as Serviciu;
            clone.denumire = this.denumire;
            clone.pret = this.pret;
            return clone;
        }
        #endregion

        #region compareTo
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        #endregion

        public override String ToString()
        {
            String text = "Serviciul se numeste " + this.denumire + " si costa " + this.pret;
            return text;
        }
    }
}
