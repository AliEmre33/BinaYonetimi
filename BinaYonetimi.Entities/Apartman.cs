using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.Entities
{
    public class Apartman : IEntity
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string apartmanAdı;
        public string ApartmanAdı
        {
            get { return apartmanAdı; }
            set { apartmanAdı = value; }
        }

        private string apartmanBlok;
        public string ApartmanBlok
        {
            get { return apartmanBlok; }
            set { apartmanBlok = value; }
        }

        private int katSayisi;
        public int KatSayisi
        {
            get { return katSayisi; }
            set { katSayisi = value; }
        }

        private string apartmanYonetici;
        public string ApartmanYonetici
        {
            get { return apartmanYonetici; }
            set { apartmanYonetici = value; }
        }

        private int daireSayisi;
        public int DaireSayisi
        {
            get { return daireSayisi; }
            set { daireSayisi = value; }
        }

        private double aidat;
        public double Aidat
        {
            get { return aidat; }
            set { aidat = value; }
        }
    }
}
