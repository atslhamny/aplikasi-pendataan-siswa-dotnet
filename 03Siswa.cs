using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace _06_LSP_ATSILAH_19
{
   public partial class Siswa : Form
   {
      public MySqlCommand cmd;
      public MySqlDataReader dr;
      public String id;
      public Siswa()
      {
         InitializeComponent();
      }

      private void Tampil()
      {
         try
         {
            Koneksi.conn.Open();        
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `dbdekstop`.`siswa`", Koneksi.conn);
            DataSet ds = new DataSet();           
            da.Fill(ds);
            dgSiswa.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
         }
         catch (Exception)
         {

            MessageBox.Show("Duh!!, Ada Error Nih di Tampil");
         }
      }
      private void Clear()
      {
         txtNama.Text = "";
         txtAlamat.Text = "";
         txtCari.Text = "";
         cbJenkel.Text = "";
         txtHp.Text = "";
         txtJurusan.Text = "";
         txtEmail.Text = "";

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
            String Queri = "INSERT INTO siswa (`nama`, `jenkel`, `alamat`, `nohp`, `jurusan`, `email`) " +
            "VALUES ('" + txtNama.Text + "', '" + cbJenkel.Text + "', '" + txtAlamat.Text + "', '" + txtHp.Text + "', '" + txtJurusan.Text + "', '" + txtEmail.Text + "')";
            cmd = new MySqlCommand(Queri, Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Simpan Data Siswa");
            Koneksi.conn.Close();

            Tampil(); 
            Clear();
         }
         catch (Exception)
         {

            MessageBox.Show("Tambah Data Gagal");
         }
      }

      private void Siswa_Load(object sender, EventArgs e)
      {
         Tampil();
         
         btnDelete.Enabled = false;
         btnUpdate.Enabled = false;
         btnCancel.Enabled = false;


         WindowState = FormWindowState.Maximized;
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         Clear();
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Koneksi.conn.Open();
            String Queri = "UPDATE siswa SET `nama`='" + txtNama.Text + "', `jenkel`='" + cbJenkel.Text + "', `alamat`='" + txtAlamat.Text + "', `nohp`='" + txtHp.Text + "', `jurusan`='" + txtJurusan.Text + "', `email`='" + txtEmail.Text + "' WHERE  `id`='" + id + "'";
            cmd = new MySqlCommand(Queri, Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Update Data Siswa");
            Koneksi.conn.Close();

            Tampil();
            Clear();
         }
         catch (Exception)
         {

            MessageBox.Show("Update Gagal");
         }
      }

      private void dgSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         btnDelete.Enabled = true;
         btnUpdate.Enabled = true;
         btnCancel.Enabled = true;
         btnInsert.Enabled = false;

         int baris = dgSiswa.CurrentCell.RowIndex;
         id = dgSiswa.Rows[baris].Cells[0].Value.ToString();
         txtNama.Text = dgSiswa.Rows[baris].Cells[1].Value.ToString();
         cbJenkel.Text = dgSiswa.Rows[baris].Cells[2].Value.ToString();
         txtAlamat.Text = dgSiswa.Rows[baris].Cells[3].Value.ToString();
         txtHp.Text = dgSiswa.Rows[baris].Cells[4].Value.ToString();
         txtJurusan.Text = dgSiswa.Rows[baris].Cells[5].Value.ToString();
         txtEmail.Text = dgSiswa.Rows[baris].Cells[6].Value.ToString();

      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            Koneksi.conn.Open();

            cmd = new MySqlCommand("DELETE FROM siswa WHERE  `id`= '" + id + "'", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Hapus Data Siswa");
            Koneksi.conn.Close();

            Tampil();
            Clear();
         }
         catch (Exception)
         {

            MessageBox.Show("Hapus Data Gagal");
         }
      }

      private void txtCari_TextChanged(object sender, EventArgs e)
      {
         try
         {

            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `siswa` where nama LIKE '%" + txtCari.Text + "%'", Koneksi.conn);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dgSiswa.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
         }
         catch (Exception)
         {

            MessageBox.Show("Duh!!, Ada Error Nih di Pencarian");
         }
      }
   }
}
