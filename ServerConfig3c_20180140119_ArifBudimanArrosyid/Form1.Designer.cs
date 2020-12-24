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
            this.labelON = new System.Windows.Forms.Label();
            this.labelONInfo = new System.Windows.Forms.Label();
            this.labelOFF = new System.Windows.Forms.Label();
            this.labelOFFInfo = new System.Windows.Forms.Label();
            this.buttonON = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelON
            // 
            this.labelON.AutoSize = true;
            this.labelON.Location = new System.Drawing.Point(90, 58);
            this.labelON.Name = "labelON";
            this.labelON.Size = new System.Drawing.Size(23, 13);
            this.labelON.TabIndex = 0;
            this.labelON.Text = "ON";
            // 
            // labelONInfo
            // 
            this.labelONInfo.AutoSize = true;
            this.labelONInfo.Location = new System.Drawing.Point(90, 87);
            this.labelONInfo.Name = "labelONInfo";
            this.labelONInfo.Size = new System.Drawing.Size(149, 13);
            this.labelONInfo.TabIndex = 1;
            this.labelONInfo.Text = "Klik ON untuk  menghidupkan";
            // 
            // labelOFF
            // 
            this.labelOFF.AutoSize = true;
            this.labelOFF.Location = new System.Drawing.Point(360, 58);
            this.labelOFF.Name = "labelOFF";
            this.labelOFF.Size = new System.Drawing.Size(27, 13);
            this.labelOFF.TabIndex = 2;
            this.labelOFF.Text = "OFF";
            // 
            // labelOFFInfo
            // 
            this.labelOFFInfo.AutoSize = true;
            this.labelOFFInfo.Location = new System.Drawing.Point(360, 87);
            this.labelOFFInfo.Name = "labelOFFInfo";
            this.labelOFFInfo.Size = new System.Drawing.Size(131, 13);
            this.labelOFFInfo.TabIndex = 3;
            this.labelOFFInfo.Text = "Klik OFF untuk mematikan";
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(93, 129);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(75, 23);
            this.buttonON.TabIndex = 4;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(363, 129);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(75, 23);
            this.buttonOFF.TabIndex = 5;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 227);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonON);
            this.Controls.Add(this.labelOFFInfo);
            this.Controls.Add(this.labelOFF);
            this.Controls.Add(this.labelONInfo);
            this.Controls.Add(this.labelON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelON;
        private System.Windows.Forms.Label labelONInfo;
        private System.Windows.Forms.Label labelOFF;
        private System.Windows.Forms.Label labelOFFInfo;
        private System.Windows.Forms.Button buttonON;
        private System.Windows.Forms.Button buttonOFF;
    }
}

