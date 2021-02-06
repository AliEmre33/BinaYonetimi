﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Kullanici : IEntity
    {
        public enum KullaniciTip { Yonetici, BinaSakini }
        public enum Cinsiyet { Erkek, Kadın }
        public enum MedeniDurum { Evli, Bekar }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public KullaniciTip kullaniciTip { get; set; }

        private int yas;
        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        private DateTime dogumTarihi;
        public DateTime MyProperty
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

        public Cinsiyet _Cinsiyet{ get; set; }
        public MedeniDurum _MedeniDurum{ get; set; }

        private string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        private string sifre;
        public string Sifre
        {
            get { return  sifre; }
            set { string sifre = value; }
        }
    }
}