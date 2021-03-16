using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Kullanici : IEntity
    {
        private bool kullaniciTip;

        public bool KullaniciTip

        {
            get { return kullaniciTip; }
            set { kullaniciTip = value; }
        }

        private bool cinsiyet;

        public bool Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        private bool medeniDurum;

        public bool MedeniDurum
        {
            get { return medeniDurum; }
            set { medeniDurum = value; }
        }





        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    

        private int yas;
        public int Yas
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
        public string AD
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
            set {  sifre = value; }
        }

        private int apartmanID;

        public int ApartmanID
        {
            get { return apartmanID; }
            set { apartmanID = value; }
        }


        private string mailAdresi;

        public string MailAdresi
        {
            get { return mailAdresi; }
            set { mailAdresi = value; }
        }



    }
}
