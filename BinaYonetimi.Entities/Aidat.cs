using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Aidat : IEntity
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int uyeID;
        public int UyeID
        {
            get { return uyeID; }
            set { uyeID = value; }
        }
        private int aidatNo;
        public int AidatNo
        {
            get { return aidatNo; }
            set { aidatNo = value; }
        }
        private DateTime ay;
        public DateTime Ay
        {
            get { return ay; }
            set { ay = value; }
        }
        private bool odemeDurumu;
        public bool OdemeDurumu
        {
            get { return odemeDurumu; }
            set { odemeDurumu = value; }
        }
    }
}
