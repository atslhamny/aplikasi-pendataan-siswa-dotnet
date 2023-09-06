using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _06_LSP_ATSILAH_19
{
   public partial class Dashboard : Form
   {
      public MySqlCommand cmd;
      public MySqlDataReader dr;
      public String id;
      public Dashboard()
      {
         InitializeComponent();
      }

        private void btnSiswa_Click(object sender, EventArgs e)
        {
         if (ActiveMdiChild != null)
            ActiveMdiChild.Close();

         label1.Visible = false;
         Siswa FormAktif = new Siswa();

         FormAktif.MdiParent = this;
         FormAktif.Show();
         label3.Text = "Input Data Siswa";
      }

      private void btnGuru_Click(object sender, EventArgs e)
      {
         if (ActiveMdiChild != null)
            ActiveMdiChild.Close();

         label1.Visible = false;
         Guru FormAktif = new Guru();

         FormAktif.MdiParent = this;
         FormAktif.Show();
         label3.Text = "Input Data Guru";
      }

      private void btnMapel_Click(object sender, EventArgs e)
      {
         if (ActiveMdiChild != null)
            ActiveMdiChild.Close();

         label1.Visible = false;
         Mapel FormAktif = new Mapel();

         FormAktif.MdiParent = this;
         FormAktif.Show();
         label3.Text = "Input Data Mata Pelajran";
      }

      private void btnNilai_Click(object sender, EventArgs e)
      {
         if (ActiveMdiChild != null)
            ActiveMdiChild.Close();

         label1.Visible = false;
         Nilai FormAktif = new Nilai();

         FormAktif.MdiParent = this;
         FormAktif.Show();
         label3.Text = "Input Data Nilai Siswa";
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         new Login().Show();
         this.Hide();
      }

      private void Dashboard_Load(object sender, EventArgs e)
      {
         WindowState = FormWindowState.Maximized;
      }
   }
}
