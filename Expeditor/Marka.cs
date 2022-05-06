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
    public partial class Marka : Form
    {
        public Marka()
        {
            InitializeComponent();
        }
        //BUNU SEHVEN VURDUM SİLECEM
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntsdq_Click(object sender, EventArgs e)
        {

            string maincon = ConfigurationManager.ConnectionStrings["myconection"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);
            if (txtmrkelvet.Text == "" || txtexpelvet.Text == "")
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
                    SqlCommand cmd = new SqlCommand("update GT_SALESMAN set GOODS_TYPE=CONCAT(GOODS_TYPE,',',@mrkkodu) where CODE = @exp", con);
                    cmd.Parameters.AddWithValue("@mrkkodu", (txtmrkelvet.Text).ToString());
                    cmd.Parameters.AddWithValue("@exp", (txtexpelvet.Text).ToString());
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
                            MessageBox.Show("Dəyişiklik edilə bilmədi!");
                        }
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
