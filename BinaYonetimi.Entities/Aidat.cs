using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
   public class Aidat:IEntity
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string ay;

        public string Ay
        {
            get { return ay; }
            set { ay = value; }
        }

        private int aidatNo;

        public int AidatNo
        {
            get { return aidatNo; }
            set { aidatNo = value; }
        }

        private int uyeID;

        public int UyeID
        {
            get { return uyeID; }
            set { uyeID = value; }
        }
        private bool odemeDurum;

        public bool OdemeDurum
        {
            get { return odemeDurum; }
            set { odemeDurum = value; }
        }


        private int apartmanID;

        public int ApartmanID
        {
            get { return apartmanID; }
            set { apartmanID = value; }
        }

    }
}
