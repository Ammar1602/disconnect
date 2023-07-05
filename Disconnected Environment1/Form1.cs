using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataMahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }
    }
}
