using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Business.Entities
{
    class Kullanici
    {
        public int kullaniciID { get; set; }
        public enum KullaniciTip { Yonetici,BinaSakini }
        public KullaniciTip kullaniciTip { get; set; }
        public int kullaniciYas { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int telefon { get; set; }
        public enum cinsiyet { erkek, kadın }
        public cinsiyet k_cinsiyet { get; set; }

        public enum medeniDurum { evli,bekar }
        public medeniDurum k_medeniDurum { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string tipAdı { get; set; }

        //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa



    }
}
