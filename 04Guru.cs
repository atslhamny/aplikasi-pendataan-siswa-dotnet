using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace _06_LSP_ATSILAH_19
{
   public partial class Guru : Form
   {
      public MySqlCommand cmd;
      public MySqlDataReader dr;
      public String id;
      public Guru()
      {
         InitializeComponent();
      }
      private void Tampil()
      {
         try
         {
            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `dbdekstop`.`guru`", Koneksi.conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgGuru.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
         }
         catch (Exception)
         {

            MessageBox.Show("Duh!!, Ada Error Nih di Tampil");
         }
      }
      private void Clear()
      {
         txtNamaGuru.Text = "";
         txtNIP.Text = "";
        
         btnInsert.Enabled = true;
         btnUpdate.Enabled = false;
         btnDelete.Enabled = false;
         btnCancel.Enabled = false;
      }
      private void btnInsert_Click(object sender, EventArgs e)
      { 
         try
         {
            Koneksi.conn.Open();
            String Queri = "INSERT INTO guru (`nama_guru`, `nip`) " +
            "VALUES ('" + txtNamaGuru.Text + "', '" + txtNIP.Text + "')";
            cmd = new MySqlCommand(Queri, Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Simpan Data Guru");
            Koneksi.conn.Close();

            Tampil();
            Clear();
         }
         catch (Exception)
         {

            MessageBox.Show("Tambah Data Gagal");
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Koneksi.conn.Open();
            String Queri = "UPDATE guru SET `nama_guru`='" + txtNamaGuru.Text + "', `nip`='" + txtNIP.Text + "' WHERE  `id`='" + id + "'";
            cmd = new MySqlCommand(Queri, Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Update Data Guru");
            Koneksi.conn.Close();

            Tampil();
            Clear();
         }
         catch (Exception)
         {

            MessageBox.Show("Update Gagal");
         }
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            Koneksi.conn.Open();

            cmd = new MySqlCommand("DELETE FROM guru WHERE  `id`= '" + id + "'", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Hapus Data Guru");
            Koneksi.conn.Close();

            Tampil();
            Clear();
         }
         catch (Exception)
         {

            MessageBox.Show("Hapus Data Gagal");
         }
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         Clear();
      }

      private void dgGuru_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         btnDelete.Enabled = true;
         btnUpdate.Enabled = true;
         btnCancel.Enabled = true;
         btnInsert.Enabled = false;

         int baris = dgGuru.CurrentCell.RowIndex;
         id = dgGuru.Rows[baris].Cells[0].Value.ToString();
         txtNamaGuru.Text = dgGuru.Rows[baris].Cells[1].Value.ToString();
         txtNIP.Text = dgGuru.Rows[baris].Cells[2].Value.ToString();
         
      }

      private void Guru_Load(object sender, EventArgs e)
      {
         Tampil();
         btnDelete.Enabled = false;
         btnUpdate.Enabled = false;
         btnCancel.Enabled = false;

         WindowState = FormWindowState.Maximized;
      }

      private void txtCari_TextChanged(object sender, EventArgs e)
      {
         try
         {

            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `guru` where nama_guru LIKE '%" + txtCari.Text + "%'", Koneksi.conn);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dgGuru.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
         }
         catch (Exception)
         {

            MessageBox.Show("Duh!!, Ada Error Nih di Pencarian");
         }
      }
   }
}
