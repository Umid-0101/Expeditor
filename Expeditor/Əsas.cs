using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Expeditor
{
    public partial class Əsas : Form
    {
        public Əsas()
        {
            InitializeComponent();
        }

        private void təmsilçilərToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Təmsilçilər form = new Təmsilçilər();
            form.ShowDialog();
        }

        private void markaƏlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marka form = new Marka();
            form.ShowDialog();
        }

        private void markaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marka form = new Marka();
            form.ShowDialog();
        }

        private void anbarDəyişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anbar form = new Anbar();
            form.ShowDialog();
        }

        private void Əsas_Load(object sender, EventArgs e)
        {   
        }

        private void təmsilçiSiyahısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ffffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
