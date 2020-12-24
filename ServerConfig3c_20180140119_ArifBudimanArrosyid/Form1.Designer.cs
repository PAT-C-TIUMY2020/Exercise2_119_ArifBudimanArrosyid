namespace ServerConfig3c_20180140119_ArifBudimanArrosyid
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
            this.labelKeterangan = new System.Windows.Forms.Label();
            this.buttonON = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKeterangan
            // 
            this.labelKeterangan.AutoSize = true;
            this.labelKeterangan.Location = new System.Drawing.Point(226, 83);
            this.labelKeterangan.Name = "labelKeterangan";
            this.labelKeterangan.Size = new System.Drawing.Size(62, 13);
            this.labelKeterangan.TabIndex = 0;
            this.labelKeterangan.Text = "Keterangan";
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(114, 129);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(75, 23);
            this.buttonON.TabIndex = 4;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(229, 129);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(75, 23);
            this.buttonOFF.TabIndex = 5;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonON);
            this.Controls.Add(this.labelKeterangan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeterangan;
        private System.Windows.Forms.Button buttonON;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Label label1;
    }
}

