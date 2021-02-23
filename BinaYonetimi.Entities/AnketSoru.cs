using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class AnketSoru : IEntity
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
        private string soru;
        public string Soru
        {
            get { return soru; }
            set { soru = value; }
        }
    }
}
