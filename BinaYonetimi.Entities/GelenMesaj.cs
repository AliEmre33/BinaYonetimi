using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class GelenMesaj : IEntity
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int gelenID;
        public int GelenID
        {
            get { return gelenID; }
            set { gelenID = value; }
        }
        private int gidenID;
        public int GidenID
        {
            get { return gidenID; }
            set { gidenID = value; }
        }
        private string mesaj;
        public string Mesaj
        {
            get { return mesaj; }
            set { mesaj = value; }
        }
    }
}
