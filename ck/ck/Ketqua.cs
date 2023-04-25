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
    public partial class Ketqua : Form
    {
        string chuoiketnoi = "Server=localhost; Database=user; User Id=root;Password=kocomatkhau,Character Set=UTF8";
        public Ketqua()
        {
            InitializeComponent();
        }
        private string ketqua;
        public Ketqua(string ketqua)
        {
            InitializeComponent();
            this.ketqua = ketqua;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void labdachon_Click(object sender, EventArgs e)
        {

        }

        private void Ketqua_Load(object sender, EventArgs e)
        {
            labdachon.Text = ketqua;
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Trở lại trang chủ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtykien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngui_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(chuoiketnoi);
           
                connection.Open();
                string sql = "insert into ykien(opinion) values ('" + txtykien.Text + "')";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
                int kq = (int)mySqlCommand.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Ý kiến đã được tiếp nhận");
                }
                else
                {
                    MessageBox.Show("Chưa có ý kiến để gửi");
                }
                connection.Close();
           
        }
    }
}
