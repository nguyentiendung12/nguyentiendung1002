using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKy_DP.DataObject.Factory;
using MySql.Data.MySqlClient;

namespace ck
{
    public partial class cosodulieu : Form
    {

        public cosodulieu()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cosodulieu_Load(object sender, EventArgs e)
        {
            string query_select = "Select * from car,cartype,color,engine,engine_car_type,geartype,model_car,modelcartype,wheel";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query_select);
        }

        private void btntrolai_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }
    }
}
