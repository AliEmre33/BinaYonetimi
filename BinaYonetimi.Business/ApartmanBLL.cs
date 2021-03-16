using BinaYonetimi.DAL;
using BinaYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Business
{
   public static class ApartmanBLL
    {
        static ApartmanDAL apartmanDAL = new ApartmanDAL();


        public static Apartman Select(int ID)
        {
            Apartman apartman = apartmanDAL.Select(ID);
            return apartman;
            
        }


    }
}
