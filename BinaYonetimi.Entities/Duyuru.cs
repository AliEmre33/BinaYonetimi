using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Duyuru : IEntity
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int yoneticiID;
        public int YoneticiID
        {
            get { return yoneticiID; }
            set { yoneticiID = value; }
        }

        private string duyuruAciklama;
        public string DuyuruAciklama
        {
            get { return duyuruAciklama; }
            set { duyuruAciklama = value; }
        }

        private DateTime duyuruTarih;
        public DateTime DuyuruTarih
        {
            get { return duyuruTarih; }
            set { duyuruTarih = value; }
        }

    }
}
