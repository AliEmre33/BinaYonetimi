﻿using BinaYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.DAL
{
    public interface IKullaniciDAL : IRepository<Kullanici>
    {
        Kullanici kullaniciLogin(string kullaniciAdi, string sifre);


    }
}
