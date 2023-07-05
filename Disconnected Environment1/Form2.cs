using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Disconnected_Environment1
{
    public partial class Form2 : Form
    {
        private string stringConnection = "data sourcce=AMMAR\\MSSQLSERVER01;" + "database=prodi; User ID=sa;Password=12345";
        private SqlConnection koneksi;

        private  void refreshform()
        {
            textBox1.Text = "";
            textBox1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nmProdi = textBox1.Text;

            if (nmProdi == "")
            {
                MessageBox.Show("Masukkan Nama Prodi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                koneksi.Open();
                string str = "insert into dbo.prodi (nama_prodi)" + "values(@nama_prodi)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("nama_prodi", nmProdi));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Di Simpan", "Sukses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                refreshform();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;  

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
