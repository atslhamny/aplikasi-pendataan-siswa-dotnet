namespace _06_LSP_ATSILAH_19
{
   partial class Guru
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
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnInsert = new System.Windows.Forms.Button();
         this.txtCari = new System.Windows.Forms.TextBox();
         this.txtNamaGuru = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.dgGuru = new System.Windows.Forms.DataGridView();
         this.txtNIP = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dgGuru)).BeginInit();
         this.SuspendLayout();
         // 
         // btnCancel
         // 
         this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
         this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancel.Location = new System.Drawing.Point(350, 420);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(104, 36);
         this.btnCancel.TabIndex = 49;
         this.btnCancel.Text = "CANCEL";
         this.btnCancel.UseVisualStyleBackColor = false;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
         this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDelete.Location = new System.Drawing.Point(240, 420);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(104, 36);
         this.btnDelete.TabIndex = 48;
         this.btnDelete.Text = "DELETE";
         this.btnDelete.UseVisualStyleBackColor = false;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnUpdate
         // 
         this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
         this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnUpdate.Location = new System.Drawing.Point(130, 420);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(104, 36);
         this.btnUpdate.TabIndex = 47;
         this.btnUpdate.Text = "UPDATE";
         this.btnUpdate.UseVisualStyleBackColor = false;
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // btnInsert
         // 
         this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
         this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnInsert.Location = new System.Drawing.Point(20, 420);
         this.btnInsert.Name = "btnInsert";
         this.btnInsert.Size = new System.Drawing.Size(104, 36);
         this.btnInsert.TabIndex = 46;
         this.btnInsert.Text = "INSERT";
         this.btnInsert.UseVisualStyleBackColor = false;
         this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
         // 
         // txtCari
         // 
         this.txtCari.Location = new System.Drawing.Point(669, 23);
         this.txtCari.Multiline = true;
         this.txtCari.Name = "txtCari";
         this.txtCari.Size = new System.Drawing.Size(166, 32);
         this.txtCari.TabIndex = 45;
         this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
         // 
         // txtNamaGuru
         // 
         this.txtNamaGuru.Location = new System.Drawing.Point(187, 324);
         this.txtNamaGuru.Multiline = true;
         this.txtNamaGuru.Name = "txtNamaGuru";
         this.txtNamaGuru.Size = new System.Drawing.Size(184, 33);
         this.txtNamaGuru.TabIndex = 40;
         // 
         // label9
         // 
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.Location = new System.Drawing.Point(146, 370);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(35, 30);
         this.label9.TabIndex = 35;
         this.label9.Text = ":";
         // 
         // label10
         // 
         this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label10.Location = new System.Drawing.Point(146, 327);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(35, 30);
         this.label10.TabIndex = 34;
         this.label10.Text = ":";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(611, 23);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(52, 20);
         this.label7.TabIndex = 33;
         this.label7.Text = "CARI";
         // 
         // label2
         // 
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(16, 373);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(150, 29);
         this.label2.TabIndex = 28;
         this.label2.Text = "NIP";
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(16, 330);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(150, 39);
         this.label1.TabIndex = 27;
         this.label1.Text = "NAMA GURU";
         // 
         // dgGuru
         // 
         this.dgGuru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgGuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgGuru.Location = new System.Drawing.Point(19, 63);
         this.dgGuru.Name = "dgGuru";
         this.dgGuru.RowHeadersVisible = false;
         this.dgGuru.Size = new System.Drawing.Size(816, 245);
         this.dgGuru.TabIndex = 26;
         this.dgGuru.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGuru_CellContentClick);
         // 
         // txtNIP
         // 
         this.txtNIP.Location = new System.Drawing.Point(187, 369);
         this.txtNIP.Multiline = true;
         this.txtNIP.Name = "txtNIP";
         this.txtNIP.Size = new System.Drawing.Size(184, 33);
         this.txtNIP.TabIndex = 50;
         // 
         // Guru
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(859, 515);
         this.Controls.Add(this.txtNIP);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.btnInsert);
         this.Controls.Add(this.txtCari);
         this.Controls.Add(this.txtNamaGuru);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dgGuru);
         this.Name = "Guru";
         this.Text = "Guru";
         this.Load += new System.EventHandler(this.Guru_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgGuru)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnInsert;
      private System.Windows.Forms.TextBox txtCari;
      private System.Windows.Forms.TextBox txtNamaGuru;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DataGridView dgGuru;
      private System.Windows.Forms.TextBox txtNIP;
   }
}