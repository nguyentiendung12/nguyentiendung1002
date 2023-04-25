using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ck
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost; Database=user; User Id=root;Password=kocomatkhau;Character Set=UTF8");


            string tk = txtuser.Text;
            string pass = txtpass.Text;
            string query = "select * from user where tennguoidung=" + "'" + tk + "'" + " and matkhau=" + "'" + pass + "'";
            this.Hide();
            DataProvider1.Instance.ExecuteQuery(query);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
