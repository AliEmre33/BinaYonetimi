using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Anket : IEntity
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

        private string anketKonusu;
        public string AnketKonusu
        {
            get { return anketKonusu; }
            set { anketKonusu = value; }
        }


    }
}
