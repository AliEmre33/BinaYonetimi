using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimi.Entities;

namespace BinaYonetimi.DAL
{
    public class KullaniciDAL : IKullaniciDAL
    {
        //açıklama ekledim
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public void Insert(Kullanici Entity)
        {
            throw new NotImplementedException();
        }

        public Kullanici kullaniciLogin(string kullaniciAdi, string sifre)
        {

            

            Kullanici kullanici = null;

            try
            {
                Helper.Connection();

                SqlCommand sqlCommand = new SqlCommand("KullaniciLogin",Helper.connection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@KULLANICIADI",kullaniciAdi);
                sqlCommand.Parameters.AddWithValue("@SIFRE", sifre);
                if (sqlCommand.Connection.State==System.Data.ConnectionState.Closed)
                {
                    Helper.ConnectionOpenClose();
                }



                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        kullanici = new Kullanici();

                        kullanici.ID = Convert.ToInt32(reader["kullaniciID"]);
                        kullanici.Yas = Convert.ToInt32(reader["yas"]);
                        kullanici.AD = reader["isim"].ToString();
                        kullanici.Soyad = reader["soyisim"].ToString();
                        
                        kullanici.KullaniciAdi = reader["kullanici_adi"].ToString();
                        kullanici.Sifre = reader["sifre"].ToString();
                        kullanici.MedeniDurum = Convert.ToBoolean(reader["medenidurum"]);
                        kullanici.DogumTarihi = Convert.ToDateTime(reader["dogumTarihi"]);

                        kullanici.Cinsiyet = Convert.ToBoolean(reader["cinsiyet"]);
                        kullanici.MailAdresi = reader["mailAdresi"].ToString();
                        kullanici.Telefon = Convert.ToInt32(reader["telefon"]);
                        kullanici.ApartmanID = Convert.ToInt32(reader["ApartmanID"]);
                        kullanici.KullaniciTip = Convert.ToBoolean(reader["tipadi"]);


                    }
                }
                reader.Close();
                Helper.ConnectionOpenClose();

              
            }
            catch (Exception)
            {
                kullanici = null;
               
                
            }
            return kullanici;


        }

        public Kullanici Select(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Update(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
