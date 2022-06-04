/*
 * Created by SharpDevelop.
 * User: User
 * Date: 22/05/2022
 * Time: 13:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LatihanPV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.kode_barang = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nama_barang = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.harga_jual = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.harga_beli = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.jumlah_barang = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cari = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.satuan_barang = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kode Barang";
			// 
			// kode_barang
			// 
			this.kode_barang.Location = new System.Drawing.Point(97, 11);
			this.kode_barang.Name = "kode_barang";
			this.kode_barang.Size = new System.Drawing.Size(136, 20);
			this.kode_barang.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nama Barang";
			// 
			// nama_barang
			// 
			this.nama_barang.Location = new System.Drawing.Point(97, 42);
			this.nama_barang.Name = "nama_barang";
			this.nama_barang.Size = new System.Drawing.Size(591, 20);
			this.nama_barang.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Harga Jual";
			// 
			// harga_jual
			// 
			this.harga_jual.Location = new System.Drawing.Point(97, 74);
			this.harga_jual.Name = "harga_jual";
			this.harga_jual.Size = new System.Drawing.Size(136, 20);
			this.harga_jual.TabIndex = 5;
			this.harga_jual.TextChanged += new System.EventHandler(this.Harga_jualTextChanged);
			this.harga_jual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Harga_jualKeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Harga Beli";
			// 
			// harga_beli
			// 
			this.harga_beli.Location = new System.Drawing.Point(97, 108);
			this.harga_beli.Name = "harga_beli";
			this.harga_beli.Size = new System.Drawing.Size(136, 20);
			this.harga_beli.TabIndex = 7;
			this.harga_beli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Harga_beliKeyPress);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Jumlah";
			// 
			// jumlah_barang
			// 
			this.jumlah_barang.Location = new System.Drawing.Point(97, 139);
			this.jumlah_barang.Name = "jumlah_barang";
			this.jumlah_barang.Size = new System.Drawing.Size(136, 20);
			this.jumlah_barang.TabIndex = 9;
			this.jumlah_barang.TextChanged += new System.EventHandler(this.Jumlah_barangTextChanged);
			this.jumlah_barang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Jumlah_barangKeyPress);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Satuan";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cari);
			this.groupBox1.Location = new System.Drawing.Point(257, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(430, 48);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pencarian Kode Barang";
			// 
			// cari
			// 
			this.cari.Location = new System.Drawing.Point(6, 19);
			this.cari.Name = "cari";
			this.cari.Size = new System.Drawing.Size(418, 20);
			this.cari.TabIndex = 0;
			this.cari.TextChanged += new System.EventHandler(this.CariTextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(263, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(68, 28);
			this.button1.TabIndex = 13;
			this.button1.Text = "Simpan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(346, 160);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 28);
			this.button2.TabIndex = 14;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(429, 160);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(68, 28);
			this.button3.TabIndex = 15;
			this.button3.Text = "Hapus";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(513, 160);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(68, 28);
			this.button4.TabIndex = 16;
			this.button4.Text = "Refresh";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 201);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(675, 331);
			this.dataGridView1.TabIndex = 17;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// satuan_barang
			// 
			this.satuan_barang.FormattingEnabled = true;
			this.satuan_barang.Location = new System.Drawing.Point(98, 172);
			this.satuan_barang.Name = "satuan_barang";
			this.satuan_barang.Size = new System.Drawing.Size(134, 21);
			this.satuan_barang.TabIndex = 18;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 544);
			this.Controls.Add(this.satuan_barang);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.jumlah_barang);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.harga_beli);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.harga_jual);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nama_barang);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.kode_barang);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "LatihanPV";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox cari;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox satuan_barang;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox jumlah_barang;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox harga_beli;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox harga_jual;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nama_barang;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox kode_barang;
		private System.Windows.Forms.Label label1;
	}
}
