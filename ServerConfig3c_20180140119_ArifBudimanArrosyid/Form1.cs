using ServiceRest3b_20180140119;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfig3c_20180140119_ArifBudimanArrosyid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
			ServiceHost hostObjek = null;

			try
			{
				hostObjek = new ServiceHost(typeof(TI_UMY));
				hostObjek.Open();
				labelKeterangan.Text = "ON";
				
				buttonON.Enabled = false;
				buttonOFF.Enabled = true;
			}
			catch (Exception ex)
			{
				hostObjek = null;
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			buttonON.Enabled = true;
			buttonOFF.Enabled = false;
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
			ServiceHost hostObjek;

			try
			{
				hostObjek = new ServiceHost(typeof(TI_UMY));
				hostObjek.Close();
				labelKeterangan.Text = "OFF";
				
				buttonON.Enabled = true;
				buttonOFF.Enabled = false;
			}
			catch (Exception ex)
			{
				hostObjek = null;
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}
    }
}
