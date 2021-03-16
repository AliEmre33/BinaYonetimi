using BinaYonetimi.DAL;
using BinaYonetimi.Entities;
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


        public static Kullanici kullaniciLogin(string kullaniciAdi, string sifre)
        {
            Kullanici kullanici = null;
            
            if (kullaniciAdi!="" && sifre!="")
            {
                 kullanici = kullaniciDAL.kullaniciLogin(kullaniciAdi, sifre);
            }
            return kullanici;
        }

    }
}
