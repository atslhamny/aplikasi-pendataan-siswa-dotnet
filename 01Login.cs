using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _06_LSP_ATSILAH_19
{
   public partial class Login : Form
   {
      public MySqlCommand cmd;
      public MySqlDataReader dr;
      public String id;
      public Login()
      {
         InitializeComponent();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {

         Koneksi.conn.Open();
         String query = "SELECT * FROM `users` WHERE `email` = '" + txtEmail.Text + "' AND `password` = '" + txtPassword.Text + "'";
         cmd = new MySqlCommand(query, Koneksi.conn);
         dr = cmd.ExecuteReader();

         try
         {
            if (dr.Read())
            {
               new Dashboard().Show();
               this.Hide();
            }
            else
            {
               MessageBox.Show("Ups! Username atau Password anda Salah");
            }
         }
         catch (Exception)
         {

            MessageBox.Show("Ups! Gagal Login");
         }

         Koneksi.conn.Close();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }
   }
}
