using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyduAlicisi.Model;

namespace UyduAlicisi.Data
{
    class Uydular : ICrud<Uydu>
    {
        SqlConnection Conn;
        public Uydular(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public Uydu Bul(int id)
        {
            Conn.Open();
            Uydu uydu = new Uydu();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Uydular WHERE UyduID = @ID", Conn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            uydu.UyduID = -1;
            if (dr.HasRows)
            {
                uydu.UyduID = Convert.ToInt32(dr[0]);
                uydu.UyduAdi = dr.GetString(1);
                uydu.Konum = dr.GetString(2);
                uydu.Derece = Convert.ToDecimal(dr[3]);
            }
            Conn.Close();
            return uydu;
        }
        public void Ekle(Uydu model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Uydular VALUES (@ad, @konum, @derece)", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ad", model.UyduAdi);
            cmd.Parameters.AddWithValue("@konum", model.Konum);
            cmd.Parameters.AddWithValue("@derece", model.Derece);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public void Guncelle(Uydu model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Uydular SET UyduAdi = @ad, Konum = @konum, Derece = @derece WHERE UyduID = @ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", model.UyduID);
            cmd.Parameters.AddWithValue("@ad", model.UyduAdi);
            cmd.Parameters.AddWithValue("@konum", model.Konum);
            cmd.Parameters.AddWithValue("@derece", model.Derece);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public List<Uydu> Liste()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Uydular", Conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Uydu> uydular = new List<Uydu>();
            while (dr.Read())
            {
                Uydu uydu = new Uydu();
                uydu.UyduID = Convert.ToInt32(dr[0]);
                uydu.UyduAdi = dr.GetString(1);
                uydu.Konum = dr.GetString(2);
                uydu.Derece = Convert.ToDecimal(dr[3]);
                uydular.Add(uydu);
            }
            Conn.Close();
            return uydular;
        }
        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Uydular WHERE UyduID = @ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
