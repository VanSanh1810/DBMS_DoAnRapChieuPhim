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

namespace DoAnRapChieuPhim
{
    public partial class LoginForm : Form
    {
        DB db = new DB();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tbx_username.Text.Trim() == "" || tbx_pass.Text.Trim() == "")
            {
                MessageBox.Show("Điền đủ thông tin");
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Check_Login(@User,@Pass)", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.Char).Value = tbx_username.Text;
                command.Parameters.Add("@Pass", SqlDbType.Char).Value = tbx_pass.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if(table.Rows.Count != 0)
                {
                    MainForm a = new MainForm(table.Rows[0][2].ToString(), table.Rows[0][0].ToString());
                    this.Hide();
                    if(a.ShowDialog() == DialogResult.Abort)
                    {
                        this.Show();
                        a.Dispose();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true && e.KeyCode == Keys.Enter)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Check_Login(@User,@Pass)", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.Char).Value = tbx_username.Text;
                command.Parameters.Add("@Pass", SqlDbType.Char).Value = tbx_pass.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count != 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
        }
    }
}
