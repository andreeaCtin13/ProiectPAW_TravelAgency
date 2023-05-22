using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_TravelAgency
{
    [Serializable]

    public class Cazare:ICloneable, IComparable
    {
        private String denumire;
        private List<Serviciu> serviciiOferite=null;
        private Tranzactie plata=null;

        #region Constructori
        public Cazare() {
            this.denumire = "nelistat";
            this.plata = null;
            this.serviciiOferite = null;
        }
        public Cazare(string denumire, List<Serviciu> serviciiOferite, Tranzactie plata)
        {
            this.denumire = denumire;
            if (serviciiOferite != null)
            {
                this.serviciiOferite = new List<Serviciu>();
                for (int i = 0; i < serviciiOferite.Count; i++)
                {
                    Serviciu s = (Serviciu)serviciiOferite[i].Clone();
                    this.serviciiOferite.Add(s);
                }
            }
            if (this.plata != null)
            {
                this.plata = plata;
            }
        }

            public Cazare(string denumire)
        {
            this.denumire = denumire;
        }
        #endregion

        #region MetodeAccesor
        public String Denumire { get { return denumire; } set { this.denumire = value; } }
        public List<Serviciu> ServiciiOferite { get { return serviciiOferite; } set {
                serviciiOferite = new List<Serviciu>(value.Count);
                for (int i = 0; i <value.Count;i++) {
                    Serviciu s = (Serviciu)value[i].Clone();
                    serviciiOferite.Add(s);
                }
            }
        }
        public Tranzactie Plata { get { return plata; } set
            {
                plata = value;
            } 
        }
        #endregion

        #region Clone
        public object Clone()
        {
            var clone = this.MemberwiseClone() as Cazare;
            if (this.plata != null)
            {
                clone.plata = (Tranzactie)this.plata.Clone();
            }
            else
            {
                this.plata = null;
            }
            clone.denumire = this.denumire;
            if(this.serviciiOferite!= null)
            {
                clone.serviciiOferite = new List<Serviciu>();
                for(int i=0;i<this.serviciiOferite.Count;i++)
                {
                    Serviciu s = (Serviciu)this.serviciiOferite[i].Clone();
                    clone.serviciiOferite.Add(s);
                }
            }
            else
            {
                clone.serviciiOferite = null;
            }
            return clone;
        }
        #endregion

        #region compareTo
        public int CompareTo(object obj) 
        {
            Cazare cazare = obj as Cazare;
            if(this.serviciiOferite!=null&&cazare.serviciiOferite!=null)
            {
                if (this.serviciiOferite.Count > cazare.serviciiOferite.Count)
                {
                    return 1;
                }
                else if(this.serviciiOferite.Count == cazare.serviciiOferite.Count)
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
                if(this.serviciiOferite == null&& cazare.serviciiOferite == null)
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

        #region equals
        public override bool Equals(object obj)
        {
            bool result;
            if(obj is Cazare)
            {
                Cazare aux = (Cazare)obj;
                if(aux.plata == this.plata && aux.denumire == this.denumire && aux.serviciiOferite.Count == this.serviciiOferite.Count)
                {

                    for(int i = 0;i<this.serviciiOferite.Count;i++)
                    {
                        if (this.serviciiOferite[i] == aux.serviciiOferite[i])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        #endregion

        #region toString
        public override string ToString()
        {
            String text = "";
            text += "Denumirea cazarii este " + this.denumire + ", iar mai jos sunt afisate serviciile incluse la cazare: \n";
            if(this.serviciiOferite!=null&&this.serviciiOferite.Count>0)
            {
                for(int i=0;i< this.serviciiOferite.Count; i++)
                {
                    text += this.serviciiOferite[i].ToString() + "\n";
                }
            }
            else
            {
                text += " Nu exista servicii incluse\n";
            }
            if (plata != null)
            {
                text += "\nStadiul platii: " + plata.ToString();
            }
            else
            {
                text += "\nNu exista detalii despre stadiul platii.";
            }
            return text;
        }
        #endregion


    }
}