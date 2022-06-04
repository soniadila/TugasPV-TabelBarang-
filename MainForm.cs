/*
 * Created by SharpDevelop.
 * User: User
 * Date: 22/05/2022
 * Time: 13:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace LatihanPV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
			private SqlCommand cmd;
        	private DataSet ds;
        	private SqlDataAdapter da;
        	
        	Koneksi konn = new Koneksi();
		
		void Bersihkan(){
            kode_barang.Text = "";
            nama_barang.Text = "";
            harga_jual.Text = "0";
            harga_beli.Text = "0";
            jumlah_barang.Text = "0";
            satuan_barang.Text = "";
            cari.Text = "";   
            TampilBarang();
            NoOtomatis();
        }
        	
        	void NoOtomatis(){
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeBarang from TBL_BARANG where KodeBarang in(select max(KodeBarang) from TBL_BARANG) order by kodebarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3,3)) + 1;
                string kodeurutan = "000" + hitung;
                urutan = "BRG" + kodeurutan.Substring(kodeurutan.Length - 3,3);
            }
            else{
                    urutan = "BRG001";
            }
            rd.Close();
            kode_barang.Text = urutan;
            conn.Close();
        }

        	
        	void MunculSatuan()
        	{
        		satuan_barang.Items.Add("Unit");
        		satuan_barang.Items.Add("Pcs");
        		satuan_barang.Items.Add("Kg");
        		satuan_barang.Items.Add("gram");
        		satuan_barang.Items.Add(7000);
        	}
		
			
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            kode_barang.Text = row.Cells["KodeBarang"].Value.ToString();
            nama_barang.Text = row.Cells["NamaBarang"].Value.ToString();
            harga_jual.Text = row.Cells["HargaJual"].Value.ToString();
            harga_beli.Text = row.Cells["HargaBeli"].Value.ToString();
            jumlah_barang.Text = row.Cells["JumlahBarang"].Value.ToString();
            satuan_barang.Text = row.Cells["SatuanBarang"].Value.ToString();
		}
		
		void TampilBarang()
		{
			SqlConnection conn = konn.GetConn();
			try {
				conn.Open();
				cmd = new SqlCommand("Select * from TBL_BARANG", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds,"TBL_BARANG");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TBL_BARANG";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			TampilBarang();
			Bersihkan();
			NoOtomatis();
			MunculSatuan();
		}
		
		void CariBarang()
        {
            SqlConnection conn = konn.GetConn();
            try{
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_BARANG where KodeBarang like '%"+cari.Text+"%' or NamaBarang like '%"+cari.Text+"%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_BARANG");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_BARANG";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
            finally{
                conn.Close();
            }
		}
		
		void CariTextChanged(object sender, EventArgs e)
		{
			CariBarang();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			/* Memeriksa apakah kolom teks kosong */

            if (kode_barang.Text.Trim() == "" || nama_barang.Text.Trim() == "" || harga_jual.Text.Trim() == "" || harga_beli.Text.Trim() == "" || jumlah_barang.Text.Trim() == "" || satuan_barang.Text.Trim() == ""){
                MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia!!!");
            }
            else{
                /* Simpan Data */
                SqlConnection conn = konn.GetConn();
                try{
                    conn.Open();
                    cmd = new SqlCommand("insert into TBL_BARANG values ('"+kode_barang.Text+"','"+nama_barang.Text+"','"+harga_jual.Text+"','"+harga_beli.Text+"','"+jumlah_barang.Text+"','"+satuan_barang.Text+"')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("insert Data Berhasil");
                    TampilBarang();
                    Bersihkan();
                }
                catch (Exception ex){
                    MessageBox.Show(ex.ToString());
                }
            }
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			/* Memeriksa apakah kolom teks kosong */

            if (kode_barang.Text.Trim() == "" || nama_barang.Text.Trim() == "" || harga_jual.Text.Trim() == "" || harga_beli.Text.Trim() == "" || jumlah_barang.Text.Trim() == "" || satuan_barang.Text.Trim() == ""){
                MessageBox.Show("Mohon isikan terlebih dahulu komlom-kolom yang tersedia!!!");
            }
            else{
                /* Update Data */
                SqlConnection conn = konn.GetConn();
                try{
                    conn.Open();
                    cmd = new SqlCommand("Update TBL_BARANG set KodeBarang='"+kode_barang.Text+"',NamaBarang='"+nama_barang.Text+"',HargaJual='"+harga_jual.Text+"',HargaBeli='"+harga_beli.Text+"',JumlahBarang='"+jumlah_barang.Text+"',SatuanBarang='"+satuan_barang.Text+"' where KodeBarang='"+kode_barang.Text+"'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Berhasil");
                    TampilBarang();
                    Bersihkan();
                }
                catch (Exception ex){
                    MessageBox.Show(ex.ToString());
                }
            }			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			 if(MessageBox.Show(nama_barang.Text+", Yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                SqlConnection conn = konn.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("Delete TBL_BARANG where KodeBarang='"+kode_barang.Text+"'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus Data Berhasil");
                    TampilBarang();
                    Bersihkan();
            }
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			kode_barang.Text = "";
            nama_barang.Text = "";
            harga_jual.Text = "0";
            harga_beli.Text = "0";
            jumlah_barang.Text = "0";
            satuan_barang.Text = "";
            cari.Text = ""; 			
		}
		
		void Harga_jualTextChanged(object sender, EventArgs e)
		{			
			
		}
		
		void Harga_jualKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void Harga_beliKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void Jumlah_barangTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Jumlah_barangKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
	}
}
