namespace Exercise2_20180140119_ArifBudimanArrosyid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNIM = new System.Windows.Forms.Label();
            this.labelProdi = new System.Windows.Forms.Label();
            this.labelAngkatan = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxAngkatan = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSync = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(89, 93);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama";
            this.labelNama.Click += new System.EventHandler(this.labelNama_Click);
            // 
            // labelNIM
            // 
            this.labelNIM.AutoSize = true;
            this.labelNIM.Location = new System.Drawing.Point(89, 127);
            this.labelNIM.Name = "labelNIM";
            this.labelNIM.Size = new System.Drawing.Size(27, 13);
            this.labelNIM.TabIndex = 1;
            this.labelNIM.Text = "NIM";
            this.labelNIM.Click += new System.EventHandler(this.labelNIM_Click);
            // 
            // labelProdi
            // 
            this.labelProdi.AutoSize = true;
            this.labelProdi.Location = new System.Drawing.Point(92, 164);
            this.labelProdi.Name = "labelProdi";
            this.labelProdi.Size = new System.Drawing.Size(31, 13);
            this.labelProdi.TabIndex = 2;
            this.labelProdi.Text = "Prodi";
            this.labelProdi.Click += new System.EventHandler(this.labelProdi_Click);
            // 
            // labelAngkatan
            // 
            this.labelAngkatan.AutoSize = true;
            this.labelAngkatan.Location = new System.Drawing.Point(89, 202);
            this.labelAngkatan.Name = "labelAngkatan";
            this.labelAngkatan.Size = new System.Drawing.Size(53, 13);
            this.labelAngkatan.TabIndex = 3;
            this.labelAngkatan.Text = "Angkatan";
            this.labelAngkatan.Click += new System.EventHandler(this.labelAngkatan_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(210, 86);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(164, 20);
            this.textBoxNama.TabIndex = 4;
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(210, 120);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(164, 20);
            this.textBoxNIM.TabIndex = 5;
            this.textBoxNIM.TextChanged += new System.EventHandler(this.textBoxNIM_TextChanged);
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.Location = new System.Drawing.Point(210, 157);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(164, 20);
            this.textBoxProdi.TabIndex = 6;
            this.textBoxProdi.TextChanged += new System.EventHandler(this.textBoxProdi_TextChanged);
            // 
            // textBoxAngkatan
            // 
            this.textBoxAngkatan.Location = new System.Drawing.Point(210, 195);
            this.textBoxAngkatan.Name = "textBoxAngkatan";
            this.textBoxAngkatan.Size = new System.Drawing.Size(164, 20);
            this.textBoxAngkatan.TabIndex = 7;
            this.textBoxAngkatan.TextChanged += new System.EventHandler(this.textBoxAngkatan_TextChanged);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(444, 83);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(164, 23);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 191);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(157, 269);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(164, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search by NIM";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(345, 269);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(197, 20);
            this.textBoxSearch.TabIndex = 14;
            this.textBoxSearch.Text = "Masukan NIM";
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(444, 141);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(164, 23);
            this.buttonSync.TabIndex = 15;
            this.buttonSync.Text = "Sync Data";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 642);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxAngkatan);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelAngkatan);
            this.Controls.Add(this.labelProdi);
            this.Controls.Add(this.labelNIM);
            this.Controls.Add(this.labelNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNIM;
        private System.Windows.Forms.Label labelProdi;
        private System.Windows.Forms.Label labelAngkatan;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxAngkatan;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSync;
    }
}

