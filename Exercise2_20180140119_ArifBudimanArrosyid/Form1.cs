﻿using Newtonsoft.Json;
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

namespace Exercise2_20180140119_ArifBudimanArrosyid
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
			var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

			dataGridView1.DataSource = data;

		}

		public void SearchData()
		{
			var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
			string nim = textBoxSearch.Text;
			if (nim == null || nim == "")
			{
				dataGridView1.DataSource = data;
			}
			else
			{
				var item = data.Where(x => x.nim == textBoxSearch.Text).ToList();

				dataGridView1.DataSource = item;
			}
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

		string baseurl = "http://localhost:1907/";
		private void buttonInsert_Click(object sender, EventArgs e)
		{
			Mahasiswa mhs = new Mahasiswa();
			mhs.nama = textBoxNama.Text;
			mhs.nim = textBoxNIM.Text;
			mhs.prodi = textBoxProdi.Text;
			mhs.angkatan = textBoxAngkatan.Text;

			var data = JsonConvert.SerializeObject(mhs);
			var postdata = new WebClient();
			postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
			string response = postdata.UploadString(baseurl + "Mahasiswa", data);
			Console.WriteLine(response);
			TampilData();
		}

		private void buttonSearch_Click_1(object sender, EventArgs e)
		{
			SearchData();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			textBoxNIM.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
			textBoxProdi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
			textBoxAngkatan.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxProdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNIM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAngkatan_Click(object sender, EventArgs e)
        {

        }

        private void labelProdi_Click(object sender, EventArgs e)
        {

        }

        private void labelNIM_Click(object sender, EventArgs e)
        {

        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAngkatan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
			TampilData();
		}
    }
}
