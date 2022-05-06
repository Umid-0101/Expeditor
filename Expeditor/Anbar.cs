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
    public partial class Anbar : Form
    {
        public Anbar()
        {
            InitializeComponent();
        }
        private void btnanbrdystsdq_Click(object sender, EventArgs e)
        {
            string maincon = ConfigurationManager.ConnectionStrings["myconection"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);

            if (txtexpno.Text == "" || txtanbarno.Text == "")
            {
                MessageBox.Show("Məlumatları tam Girin!");
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    SqlCommand cmd = new SqlCommand("update GT_SALESMAN set WAREHOUSE_NUMBER=@whno where CODE=@expno", con);
                    cmd.Parameters.AddWithValue("@whno", txtanbarno.Text);
                    cmd.Parameters.AddWithValue("@expno", (txtexpno.Text).ToString());
                    DialogResult dialogResult = MessageBox.Show("Dəyişmək istədiyinizdən əminsiniz?", "Təsdiq", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int res = cmd.ExecuteNonQuery();
                        if (res >= 1)
                        {
                            MessageBox.Show("Dəyişiklik edildi!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Dəyişiklik edilə bilmədi! Məlumatların düzgünlüyünü yoxlayın.");
                        }
                    }
                    else
                    {
                        //No seciminde hecbir emeliyyat etme
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }
    }
}
