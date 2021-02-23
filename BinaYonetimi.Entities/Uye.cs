using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Uye : IEntity
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
        private int kat;
        public int Kat
        {
            get { return kat; }
            set { kat = value; }
        }
        private int daireNo;
        public int DaireNo
        {
            get { return daireNo; }
            set { daireNo = value; }
        }
        private int aracSayisi;
        public int AracSayisi
        {
            get { return aracSayisi; }
            set { aracSayisi = value; }
        }
    }
}
