using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_LSP_ATSILAH_19
{
   public partial class Mapel : Form
   {
      public MySqlCommand cmd;
      public MySqlDataReader dr;
      public String id;
      public Mapel()
      {
         InitializeComponent();
      }
      private void Tampil()
      {
         try
         {
            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `dbdekstop`.`vmapel`", Koneksi.conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgMapel.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
         }
         catch (Exception)
         {

            MessageBox.Show("Duh!!, Ada Error Nih di Tampil");
         }
      }
      private void Clear()
      {
         txtNamaMapel.Text = "";
         txtKdMapel.Text = "";
         txtCari.Text = "";
         cbNmGuru.Text = "";

         btnDelete.Enabled = false;
         btnUpdate.Enabled = false;
         btnCancel.Enabled = false;
         btnInsert.Enabled = true;
      }
      private void Mapel_Load(object sender, EventArgs e)
        {
         Tampil();
         btnDelete.Enabled = false;
         btnUpdate.Enabled = false;
         btnCancel.Enabled = false;

         MySqlDataAdapter adp = new MySqlDataAdapter("select * from guru ", Koneksi.conn);
         DataTable dt = new DataTable();
         adp.Fill(dt);

         cbNmGuru.DataSource = dt;
         cbNmGuru.DisplayMember = "nama_guru";
         cbNmGuru.ValueMember = "id";

         WindowState = FormWindowState.Maximized;
      }

      private void btnInsert_Click(object sender, EventArgs e)
      {
         try
         {
            Koneksi.conn.Open();
            String Queri = "INSERT INTO mapel (`nama_mapel`, `kode_mapel`, `guru_id`) VALUES ('" + txtNamaMapel.Text + "', '" + txtKdMapel.Text + "', '" + cbNmGuru.SelectedValue + "')";
            cmd = new MySqlCommand(Queri, Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Simpan Data Mapel");
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
            String Queri = "UPDATE mapel SET `nama_mapel`='" + txtNamaMapel.Text + "', `kode_mapel`='" + txtKdMapel.Text + "', `guru_id`='" + cbNmGuru.SelectedValue + "' WHERE  `id`='" + id + "'";
            cmd = new MySqlCommand(Queri, Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Update Data Mapel");
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

            cmd = new MySqlCommand("DELETE FROM mapel WHERE  `id`= '" + id + "'", Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Hapus Data Mapel");
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

      private void dgMapel_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         btnDelete.Enabled = true;
         btnUpdate.Enabled = true;
         btnCancel.Enabled = true;
         btnInsert.Enabled = false;

         int baris = dgMapel.CurrentCell.RowIndex;
         id = dgMapel.Rows[baris].Cells[0].Value.ToString();
         txtNamaMapel.Text = dgMapel.Rows[baris].Cells[1].Value.ToString();
         txtKdMapel.Text = dgMapel.Rows[baris].Cells[2].Value.ToString();
         cbNmGuru.Text = dgMapel.Rows[baris].Cells[3].Value.ToString();
      }

      private void txtCari_TextChanged(object sender, EventArgs e)
      {
         try
         {

            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `vmapel` where nama_mapel LIKE '%" + txtCari.Text + "%'", Koneksi.conn);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dgMapel.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
         }
         catch (Exception)
         {

            MessageBox.Show("Duh!!, Ada Error Nih di Pencarian");
         }
      }
   }
}
