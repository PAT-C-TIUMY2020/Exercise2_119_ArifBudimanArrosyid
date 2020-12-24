using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceRest3b_20180140119
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TI_UMY : ITI_UMY
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //public Mahasiswa GetMahasiswaByNIM(string nim)
        //public Mahasiswa UpdateMahasiswa(string nim)
        //{
        //string msg = "GAGAL";
        //SqlConnection sqlcon = new SqlConnection("Data Source=ARIFBUDIMANAR;Initial Catalog=\"TI UMY\";Persist Security Info=True;User ID=sa;Password=Arrosyid");
        //string query = string.Format("Update Nama, NIM, Prodi, Angkatan from dbo.Mahasiswa where NIM = '{0}'", nim);
        //string query = string.Format("Select Nama, NIM, Prodi, Angkatan from dbo.Mahasiswa where NIM = '{0}'", nim);
        //return msg;
        //}
        public string UpdateMahasiswa(string nim, string nama, string prodi, string angkatan)
        {
            try
            {
                string constring = "Data Source=ARIFBUDIMANAR;Initial Catalog=\"TI UMY\";Persist Security Info=True;User ID=sa;Password=Arrosyid";
                SqlConnection connection;
                SqlCommand com;

                string sql2 = "update Mahasiswa SET Nama ='" + nama + "', Prodi ='" + prodi + "', Angkatan ='" + angkatan + "' where NIM = '" + nim + "'";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql2, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                return "sukses";
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }

        public string CreateMahasiswa(Mahasiswa mhs)
        {
            string msg = "GAGAL";
            SqlConnection sqlcon = new SqlConnection("Data Source=ARIFBUDIMANAR;Initial Catalog=\"TI UMY\";Persist Security Info=True;User ID=sa;Password=Arrosyid");
            string query = string.Format("Insert into dbo.Mahasiswa values ('{1}', '{0}', '{2}', '{3}') where NIM", mhs.nama, mhs.nim, mhs.prodi, mhs.angkatan);

            //NIM = '{0}'", nim)
            // string query = "Insert into dbo.Mahasiswa values ('"+mhs.nama+"', '"+mhs.nim+"', '"+mhs.prodi+"', '"+mhs.angkatan+"')";
            SqlCommand sqlcom = new SqlCommand(query, sqlcon); //yg dikirim ke sql

            try
            {
                sqlcon.Open(); //membuka connection sql
                Console.WriteLine(query);
                sqlcom.ExecuteNonQuery(); //mengeksekusi tuk memasukkan data
                sqlcon.Close();
                msg = "SUKSES";
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
                msg = "GAGAL";
            }

            return msg;
        }

        public List<Mahasiswa> GetAllMahasiswa()
        {
            List<Mahasiswa> mahas = new List<Mahasiswa>();

            SqlConnection con = new SqlConnection("Data Source=ARIFBUDIMANAR;Initial Catalog=\"TI UMY\";Persist Security Info=True;User ID=sa;Password=Arrosyid");
            string query = "Select Nama, NIM, Prodi, Angkatan from dbo.Mahasiswa";
            SqlCommand com = new SqlCommand(query, con); //yg dikirim ke sql

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader(); //mendapatkan data yg telah dieksekusi, dari select hasil query ditaruh di reader

                while (reader.Read())
                {
                    Mahasiswa mhs = new Mahasiswa();
                    mhs.nama = reader.GetString(0); //e itu array pertama // ini diambil dari iservice
                    mhs.nim = reader.GetString(1);
                    mhs.prodi = reader.GetString(2);
                    mhs.angkatan = reader.GetString(3);

                    mahas.Add(mhs);
                }

                con.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
            }

            return mahas; //output
        }

        public Mahasiswa GetMahasiswaByNIM(string nim)
        {
            Mahasiswa mhs = new Mahasiswa();
            SqlConnection con = new SqlConnection("Data Source=ARIFBUDIMANAR;Initial Catalog=\"TI UMY\";Persist Security Info=True;User ID=sa;Password=Arrosyid");
            string query = string.Format("Select Nama, NIM, Prodi, Angkatan from dbo.Mahasiswa where NIM = '{0}'", nim);
            SqlCommand com = new SqlCommand(query, con);

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    mhs.nama = reader.GetString(0); // 0 itu array pertama // ini di ambil dari iservice
                    mhs.nim = reader.GetString(1);
                    mhs.prodi = reader.GetString(2);
                    mhs.angkatan = reader.GetString(3);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
            }
            return mhs;
        }
        /*
        public Mahasiswa DeleteMahasiswaByNIM(string nim)
        {
            Mahasiswa mhs = new Mahasiswa();
            SqlConnection con = new SqlConnection("Data Source=ARIFBUDIMANAR;Initial Catalog=\"TI UMY\";Persist Security Info=True;User ID=sa;Password=Arrosyid");
            //string query = string.Format("Delete Nama, NIM, Prodi, Angkatan from dbo.Mahasiswa where NIM = '{0}'", nim);
            string query = string.Format("Delete from dbo.Mahasiswa where NIM = '{0}'", nim);
            SqlCommand com = new SqlCommand(query, con);

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();

                while (reader.())
                {
                    mhs.nama = reader.GetString(0); // 0 itu array pertama // ini di ambil dari iservice
                    mhs.nim = reader.GetString(1);
                    mhs.prodi = reader.GetString(2);
                    mhs.angkatan = reader.GetString(3);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
            }
            return mhs;
        }
        */
        public string DeleteByNIM(string nim)
        {
            string msg = "GAGAL";
            SqlConnection sqlcon = new SqlConnection("Data Source=ARIFBUDIMANAR;Initial Catalog=\"TI UMY\";Persist Security Info=True;User ID=sa;Password=Arrosyid");
            string query = "delete from dbo.Mahasiswa where NIM = '" + nim + "'";
            SqlCommand sqlcom = new SqlCommand(query, sqlcon);
            try
            {
                sqlcon.Open();
                Console.WriteLine(query);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
                msg = "Sukses";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
                msg = "GAGAL";
            }


            return msg;
        }

        public string CountMahasiswa()
        {
            string msg = "gagal";
            SqlConnection sqlcon = new SqlConnection("Data Source=ARIFBUDIMANAR;Initial Catalog=\"TI UMY\";Persist Security Info=True;User ID=sa;Password=Arrosyid");
            string query = String.Format("select Count(NIM) From Mahasiswa");
            string stm = "SELECT COUNT(Mahasiswa) From NIM";
            SqlCommand sqlcom = new SqlCommand(query, sqlcon);

            try
            {
                sqlcon.Open();
                Console.WriteLine(query);
                Int32 count = (Int32)sqlcom.ExecuteScalar();
                sqlcon.Close();
                msg = "Jumlah Data " + count;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
                msg = "GAGAL";
            }

            return msg;
        }
    }
}
