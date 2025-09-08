using System;
using System.Drawing; // Penting untuk properti warna, ukuran, dan font
using System.Windows.Forms; // Namespace utama untuk Windows Forms

namespace CobaWinForms // <<< GANTI INI DENGAN NAMESPACE PROYEK ANDA >>>
{
    public partial class Form1 : Form
    {
        // Deklarasi komponen UI
        private Label lblInstruksi;
        private TextBox txtNamaPengguna;
        private Button btnSapa;
        private Label lblPesanSapaan;

        // Constructor Form1
        public Form1()
        {
            InitializeComponent(); // Dihasilkan otomatis oleh Visual Studio Designer, JANGAN DIHAPUS
            InitializeCustomComponents(); // Metode untuk inisialisasi komponen kita secara manual
        }

        // Metode ini akan berisi kode untuk membuat dan mengatur komponen UI kita
        private void InitializeCustomComponents()
        {
            // --- Pengaturan Form ---
            this.Text = "Aplikasi Sapaan Sederhana C#"; // Judul jendela Form
            this.Size = new Size(400, 250); // Ukuran Form (lebar, tinggi)
            this.StartPosition = FormStartPosition.CenterScreen; // Form muncul di tengah layar

            // --- Label Instruksi ---
            lblInstruksi = new Label();
            lblInstruksi.Text = "Masukkan nama Anda di bawah:";
            lblInstruksi.Location = new Point(50, 30); // Posisi (x, y) dari pojok kiri atas Form
            lblInstruksi.AutoSize = true; // Ukuran label menyesuaikan teks
            this.Controls.Add(lblInstruksi); // Tambahkan label ke Form

            // --- TextBox Nama Pengguna ---
            txtNamaPengguna = new TextBox();
            txtNamaPengguna.Name = "txtNamaPengguna"; // Nama unik untuk diakses di kode
            txtNamaPengguna.Location = new Point(50, 60); // Di bawah label instruksi
            txtNamaPengguna.Size = new Size(200, 25); // Ukuran textbox
            this.Controls.Add(txtNamaPengguna); // Tambahkan textbox ke Form

            // --- Tombol Sapa ---
            btnSapa = new Button();
            btnSapa.Text = "Sapa Saya!"; // Teks pada tombol
            btnSapa.Name = "btnSapa"; // Nama unik
            btnSapa.Location = new Point(50, 100); // Di bawah textbox
            btnSapa.Size = new Size(100, 30); // Ukuran tombol
            // Menghubungkan tombol dengan metode saat diklik
            // Pastikan metode btnSapa_Click ada di bawah
            btnSapa.Click += new EventHandler(btnSapa_Click);
            this.Controls.Add(btnSapa); // Tambahkan tombol ke Form

            // --- Label Pesan Sapaan ---
            lblPesanSapaan = new Label();
            lblPesanSapaan.Text = "Halo!"; // Teks awal
            lblPesanSapaan.Location = new Point(50, 150); // Di bawah tombol
            lblPesanSapaan.AutoSize = true; // Ukuran label menyesuaikan teks
            lblPesanSapaan.Font = new Font("Arial", 12, FontStyle.Bold); // Gaya font
            lblPesanSapaan.ForeColor = Color.Blue; // Warna teks
            this.Controls.Add(lblPesanSapaan); // Tambahkan label ke Form
        }

        // --- Event Handler untuk Tombol Sapa ---
        // Metode ini akan dijalankan setiap kali tombol 'btnSapa' diklik
        private void btnSapa_Click(object sender, EventArgs e)
        {
            // Ambil teks yang dimasukkan pengguna dari TextBox
            string nama = txtNamaPengguna.Text;

            // Periksa apakah nama tidak kosong
            if (!string.IsNullOrWhiteSpace(nama))
            {
                // Ubah teks pada Label pesan sapaan
                lblPesanSapaan.Text = $"Halo, {nama}! Selamat datang di aplikasi C#!";
            }
            else
            {
                lblPesanSapaan.Text = "Silakan masukkan nama Anda!";
                MessageBox.Show("Nama tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}