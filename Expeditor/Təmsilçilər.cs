using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expeditor
{
    public partial class Təmsilçilər : Form
    {
        public Təmsilçilər()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Təmsilçilər_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dtgrdexp.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("[Kodu]  LIKE '%{0}%' OR [Adı]  LIKE '%{0}%'",
                txtsearch.Text);
        }
    }
}
