using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Guvenlik : IEntity
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int apartmanID;
        public int ApartmanID
        {
            get { return apartmanID; }
            set { apartmanID = value; }
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
        private int telNo;
        public int TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }
    }
}
