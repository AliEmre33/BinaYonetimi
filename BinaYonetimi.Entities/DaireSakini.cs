using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class DaireSakini : IEntity
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int uyeID;
        public int UyeID
        {
            get { return uyeID; }
            set { uyeID = value; }
        }
        private string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        private string soyad;
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        private int yas;
        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }
    }
}
