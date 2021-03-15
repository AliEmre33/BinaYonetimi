using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
   public class Arac :IEntity
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        private string aractipi;

        public string AracTipi
        {
            get { return aractipi; }
            set { aractipi = value; }
        }

        private string plaka;

        public string Plaka
        {
            get { return plaka; }
            set { plaka = value; }
        }

        private int daireSakiniID;

        public int DaireSakiniID
        {
            get { return daireSakiniID; }
            set { daireSakiniID = value; }
        }



    }
}
