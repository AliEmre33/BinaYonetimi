using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimi.Entities;

namespace BinaYonetimi.DAL
{
    public class ApartmanDAL : IApartmanDAL
    {
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public void Insert(Apartman Entity)
        {
            throw new NotImplementedException();
        }

        public Apartman Select(int ID)
        {

            Apartman apartman = null;

            try
            {

                Helper.Connection();

                SqlCommand command = new SqlCommand("ApartmanBilgiGetir", Helper.connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID", ID);

                if (command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    Helper.ConnectionOpenClose();
                }


                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        apartman = new Apartman()
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            ApartmanAdı = reader["ApartmanAdi"].ToString(),
                            ApartmanBlok = reader["ApartmanBlok"].ToString(),
                            KatSayisi = Convert.ToInt32(reader["KatSayisi"]),
                            ApartmanYonetici = reader["ApartmanYoneticisi"].ToString(),
                            DaireSayisi = Convert.ToInt32(reader["DaireSayisi"])
                        };
                    }
                }
                reader.Close();
                Helper.ConnectionOpenClose();

            }
            catch (Exception)
            {

                apartman = null;
            }

            return apartman;
        }

        public List<Apartman> SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Update(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
