namespace _06_LSP_ATSILAH_19
{
   partial class Dashboard
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.btnSiswa = new System.Windows.Forms.Button();
         this.btnGuru = new System.Windows.Forms.Button();
         this.btnMapel = new System.Windows.Forms.Button();
         this.btnNilai = new System.Windows.Forms.Button();
         this.btnLogout = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.LightCyan;
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(879, 140);
         this.panel1.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.LightCyan;
         this.panel2.Controls.Add(this.btnLogout);
         this.panel2.Controls.Add(this.btnNilai);
         this.panel2.Controls.Add(this.btnMapel);
         this.panel2.Controls.Add(this.btnGuru);
         this.panel2.Controls.Add(this.btnSiswa);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel2.Location = new System.Drawing.Point(0, 140);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(217, 370);
         this.panel2.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(879, 510);
         this.label1.TabIndex = 2;
         this.label1.Text = "label1";
         // 
         // label2
         // 
         this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
         this.label2.Location = new System.Drawing.Point(25, 21);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(178, 97);
         this.label2.TabIndex = 0;
         // 
         // label3
         // 
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(340, 53);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(458, 38);
         this.label3.TabIndex = 1;
         this.label3.Text = "APLIKASI PENDATAAN SISWA";
         // 
         // btnSiswa
         // 
         this.btnSiswa.BackColor = System.Drawing.Color.DarkCyan;
         this.btnSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSiswa.ForeColor = System.Drawing.Color.White;
         this.btnSiswa.Location = new System.Drawing.Point(12, 23);
         this.btnSiswa.Name = "btnSiswa";
         this.btnSiswa.Size = new System.Drawing.Size(191, 37);
         this.btnSiswa.TabIndex = 0;
         this.btnSiswa.Text = "SISWA";
         this.btnSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnSiswa.UseVisualStyleBackColor = false;
         this.btnSiswa.Click += new System.EventHandler(this.btnSiswa_Click);
         // 
         // btnGuru
         // 
         this.btnGuru.BackColor = System.Drawing.Color.DarkCyan;
         this.btnGuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnGuru.ForeColor = System.Drawing.Color.White;
         this.btnGuru.Location = new System.Drawing.Point(12, 78);
         this.btnGuru.Name = "btnGuru";
         this.btnGuru.Size = new System.Drawing.Size(191, 37);
         this.btnGuru.TabIndex = 1;
         this.btnGuru.Text = "GURU";
         this.btnGuru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnGuru.UseVisualStyleBackColor = false;
         this.btnGuru.Click += new System.EventHandler(this.btnGuru_Click);
         // 
         // btnMapel
         // 
         this.btnMapel.BackColor = System.Drawing.Color.DarkCyan;
         this.btnMapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnMapel.ForeColor = System.Drawing.Color.White;
         this.btnMapel.Location = new System.Drawing.Point(12, 134);
         this.btnMapel.Name = "btnMapel";
         this.btnMapel.Size = new System.Drawing.Size(191, 37);
         this.btnMapel.TabIndex = 2;
         this.btnMapel.Text = "MATA PELAJARAN";
         this.btnMapel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnMapel.UseVisualStyleBackColor = false;
         this.btnMapel.Click += new System.EventHandler(this.btnMapel_Click);
         // 
         // btnNilai
         // 
         this.btnNilai.BackColor = System.Drawing.Color.DarkCyan;
         this.btnNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnNilai.ForeColor = System.Drawing.Color.White;
         this.btnNilai.Location = new System.Drawing.Point(12, 194);
         this.btnNilai.Name = "btnNilai";
         this.btnNilai.Size = new System.Drawing.Size(191, 37);
         this.btnNilai.TabIndex = 3;
         this.btnNilai.Text = "NILAI";
         this.btnNilai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnNilai.UseVisualStyleBackColor = false;
         this.btnNilai.Click += new System.EventHandler(this.btnNilai_Click);
         // 
         // btnLogout
         // 
         this.btnLogout.BackColor = System.Drawing.Color.Red;
         this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLogout.ForeColor = System.Drawing.Color.White;
         this.btnLogout.Location = new System.Drawing.Point(12, 277);
         this.btnLogout.Name = "btnLogout";
         this.btnLogout.Size = new System.Drawing.Size(191, 37);
         this.btnLogout.TabIndex = 4;
         this.btnLogout.Text = "LOGOUT";
         this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnLogout.UseVisualStyleBackColor = false;
         this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
         // 
         // Dashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(879, 510);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.IsMdiContainer = true;
         this.Name = "Dashboard";
         this.Text = "Dashboard";
         this.Load += new System.EventHandler(this.Dashboard_Load);
         this.panel1.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNilai;
        private System.Windows.Forms.Button btnMapel;
        private System.Windows.Forms.Button btnGuru;
        private System.Windows.Forms.Button btnSiswa;
        private System.Windows.Forms.Label label1;
    }
}