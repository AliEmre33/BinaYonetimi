using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Arac : IEntity
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int daireSakiniID;
        public int DaireSakiniID
        {
            get { return daireSakiniID; }
            set { daireSakiniID = value; }
        }

        private string aracTipi;
        public string AracTipi
        {
            get { return aracTipi; }
            set { aracTipi = value; }
        }
        private string aracSahibi;
        public string AracSahibi
        {
            get { return aracSahibi; }
            set { aracSahibi = value; }
        }
        private string plaka;
        public string Plaka
        {
            get { return plaka; }
            set { plaka = value; }
        }
    }
}
