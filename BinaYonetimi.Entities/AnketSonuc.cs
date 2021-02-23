using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class AnketSonuc : IEntity
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int anketID;
        public int AnketID
        {
            get { return anketID; }
            set { anketID = value; }
        }
        private int yoneticiID;
        public int YoneticiID
        {
            get { return yoneticiID; }
            set { yoneticiID = value; }
        }
        private string sonuc;
        public string Sonuc
        {
            get { return sonuc; }
            set { sonuc = value; }
        }
    }
}
