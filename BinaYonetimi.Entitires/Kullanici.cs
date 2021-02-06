using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Kullanici : IEntity
    {
        private enum KullaniciTip { Yonetici , BinaSakini }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        //Kullanici Tip Eklenecek

        private int  yas;
        public int  Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        private DateTime dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set { dogumTarihi = value; }
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

        private int telefon;
        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        //Cinsiyet Yazılacak

        //Medeni Durum Yazılacak

        private string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        private string sifre;
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
    }
}
