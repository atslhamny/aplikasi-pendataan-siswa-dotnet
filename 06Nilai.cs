using _06_LSP_ATSILAH_19;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_LSP_ATSILAH_19
{
   public partial class Nilai : Form
   {
      public MySqlCommand cmd;
      public MySqlDataReader dr;
      public String id;
      public Nilai()
      {
         InitializeComponent();
      }
      private void Tampil()
      {
        
            try
            {

               Koneksi.conn.Open();
               MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `vnilai`", Koneksi.conn);
               DataSet ds = new DataSet();
               da.Fill(ds);
               dgNilai.DataSource = ds.Tables[0];
               Koneksi.conn.Close();
            }
            catch (Exception)
            {
               MessageBox.Show("Duh!!, Ada Error Nih di Tampil");
            }
         
      }
      private void Clear()
      {
         cbMapel.Text = "";
         cbSiswa.Text = "";
         txtNilai.Text = "";

         txtCari.Text = "";

         btnDelete.Enabled = false;
         btnUpdate.Enabled = false;
         btnCancel.Enabled = false;
         btnInsert.Enabled = true;
      }
      private void Nilai_Load(object sender, EventArgs e)
      {
         Tampil();

         MySqlDataAdapter adp = new MySqlDataAdapter("select * from mapel", Koneksi.conn);
         DataTable dt = new DataTable();
         adp.Fill(dt);

         cbMapel.DataSource = dt;
         cbMapel.DisplayMember = "nama_mapel";
         cbMapel.ValueMember = "id";

         MySqlDataAdapter adp2 = new MySqlDataAdapter("select * from siswa", Koneksi.conn);
         DataTable dt2 = new DataTable();
         adp2.Fill(dt2);

         cbSiswa.DataSource = dt2;
         cbSiswa.DisplayMember = "nama";
         cbSiswa.ValueMember = "id";

         btnDelete.Enabled = false;
         btnUpdate.Enabled = false;
         btnCancel.Enabled = false;

         WindowState = FormWindowState.Maximized;
      }


      private void btnInsert_Click(object sender, EventArgs e)
      {
         try
         {
            Koneksi.conn.Open();
            String Queri = "INSERT INTO nilai (`siswa_id`, `mapel_id`, `nilai`) VALUES ('" + cbSiswa.SelectedValue + "','" + cbMapel.SelectedValue + "', '" + txtNilai.Text + "')";
            cmd = new MySqlCommand(Queri, Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Simpan Nilai Siswa");
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

            String Queri = "UPDATE `nilai` SET `siswa_id`='" + cbSiswa.SelectedValue + "', `mapel_id`='" + cbMapel.SelectedValue + "', `nilai`='" + txtNilai.Text + "' WHERE  `id`='" + id + "'";
            cmd = new MySqlCommand(Queri, Koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Update Data Nilai");
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


            cmd = new MySqlCommand("DELETE FROM nilai WHERE  `id`= '" + id + "'", Koneksi.conn);
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

      private void btnCancel_Click(object sender, EventArgs e)
      {
         Clear();
      }

      private void dgNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         btnDelete.Enabled = true;
         btnUpdate.Enabled = true;
         btnCancel.Enabled = true;
         btnInsert.Enabled = false;

         int baris = dgNilai.CurrentCell.RowIndex;
         id = dgNilai.Rows[baris].Cells[0].Value.ToString();
         cbSiswa.Text = dgNilai.Rows[baris].Cells[1].Value.ToString();
         cbMapel.Text = dgNilai.Rows[baris].Cells[3].Value.ToString();
         txtNilai.Text = dgNilai.Rows[baris].Cells[5].Value.ToString();
      }

      private void txtCari_TextChanged(object sender, EventArgs e)
      {
         try
         {

            Koneksi.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `vnilai` where nama LIKE '%" + txtCari.Text + "%'", Koneksi.conn);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dgNilai.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
         }
         catch (Exception)
         {

            MessageBox.Show("Duh!!, Ada Error Nih di Pencarian");
         }
      }
   }
}
