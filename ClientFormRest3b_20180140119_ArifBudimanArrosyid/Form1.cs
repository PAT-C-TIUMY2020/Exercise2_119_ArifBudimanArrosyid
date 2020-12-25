using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFormRest3b_20180140119_ArifBudimanArrosyid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TampilData();

        }
        public void TampilData()
        {
            var json = new WebClient().DownloadString("http://localhost:1909/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            dataGridView1.DataSource = data;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBoxNIM.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            textBoxProdi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            textBoxAngkatan.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }

        private void buttonJumlah_Click(object sender, EventArgs e)
        {
            var json = new WebClient().DownloadString("http://localhost:1909/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            int length = data.Count();
            labelJumlah.Text = Convert.ToString(length);
        }
        public class Mahasiswa
        {
            private string _nama, _nim, _prodi, _angkatan;
            public string nama
            {
                get { return _nama; }
                set { _nama = value; }
            }

            public string nim
            {
                get { return _nim; }
                set { _nim = value; }
            }

            public string prodi
            {
                get { return _prodi; }
                set { _prodi = value; }
            }

            public string angkatan
            {
                get { return _angkatan; }
                set { _angkatan = value; }
            }
        }


        //Lanjut disini
        string baseurl = "http://localhost:1909/";
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ClassData classData = new ClassData();
                    classData.deleteMahasiswa(textBoxDelete.Text);
                    dataGridView1.DataSource = classData.getAllData();
                    MessageBox.Show("Data successfuly deleted");
                }
                catch (Exception ex)
                {
                    labelKeterangan.Text = "Server Error";
                }
            }
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxNIM.Text != "" &&
               textBoxNama.Text != "" &&
               textBoxProdi.Text != "" &&
               textBoxAngkatan.Text != "")
            {
                if (textBoxNIM.Text.Length <= 12 &&
                textBoxAngkatan.Text.Length <= 4 &&
                textBoxProdi.Text.Length <= 30 &&
                textBoxNama.Text.Length <= 20)
                {
                    try
                    {
                        Mahasiswa mhs = new Mahasiswa();
                        mhs.nim = textBoxNIM.Text;
                        mhs.nama = textBoxNama.Text;
                        mhs.prodi = textBoxProdi.Text;
                        mhs.angkatan = textBoxAngkatan.Text;

                        ClassData classData = new ClassData();
                        classData.updateDatabase(mhs);
                        MessageBox.Show("Data successfuly updated");

                        dataGridView1.DataSource = classData.getAllData();
                    }
                    catch
                    {
                        labelKeterangan.Text = "Server Error";
                    }
                }
                else
                {
                    MessageBox.Show("Please check your data");
                }
            }
            else
            {
                MessageBox.Show("Please check your data");
            }
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            TampilData();
        }
    }
}
