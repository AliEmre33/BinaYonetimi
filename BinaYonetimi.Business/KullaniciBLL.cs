using BinaYonetimi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Business
{
   public static class KullaniciBLL
    {
       static KullaniciDAL kullaniciDAL = new KullaniciDAL();


        public static int kullaniciLogin(string kullaniciAdi, string sifre)
        {
            int durum = 0;
            if (kullaniciAdi!="" && sifre!="")
            {
                durum = kullaniciDAL.kullaniciLogin(kullaniciAdi, sifre);
            }
            return durum;
        }

    }
}
