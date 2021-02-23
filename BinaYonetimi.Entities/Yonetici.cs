using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Yonetici : IEntity
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        private string sifre;
        public string MyProperty
        {
            get { return sifre; }
            set { sifre = value; }
        }
    }
}
