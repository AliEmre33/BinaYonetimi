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

        public int kullaniciLogin(string kullaniciAdi, string sifre)
        {

            int durum = 0;

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
                        kullanici.KullaniciAdi = reader["kullanici_adi"].ToString();
                    }
                }
                reader.Close();
                Helper.ConnectionOpenClose();

                if (kullanici !=null)
                {
                    durum = 1;
                }

                else
                {
                    durum = 0;
                }
            }
            catch (Exception)
            {

                durum = 0;
                
            }
            return durum;


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
