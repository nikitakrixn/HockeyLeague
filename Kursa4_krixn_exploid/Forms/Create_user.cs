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

namespace Kursa4_krixn_exploid
{
    public partial class Create_user : Form
    {
        public Create_user()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkPass_OnChange(object sender, EventArgs e)
        {
            if (chkPass.Checked == true) { txtPass.UseSystemPasswordChar = false; }
            else { txtPass.UseSystemPasswordChar = true; }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length >= 3 && txtPass.Text.Length >= 6)
            {
                try
                {
                    CreateLogin();
                    MessageBox.Show("Успешно! Добавился пользователь " + txtLogin.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Логин должен быть больше 3х символов. Пароль должен быть больше 6 знаков.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Create_user_Load(object sender, EventArgs e)
        {
            cmbServer.Clear();
            cmbServer.AddItem(Environment.MachineName);
            cmbServer.AddItem(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cmbServer.selectedIndex = 1;
        }

        //Создаём имя входа для пользователя
        private void CreateLogin()
        {
            string connect = string.Format("Data Source={0};Initial Catalog=HockeyLeague; Persist Security Info=True;User ID=krixN;Password=123456", cmbServer.selectedValue);
            string query = "Exec Users_Insert @loginame, @passwd, @Role";
            SqlConnection con = new SqlConnection(connect);
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@loginame", txtLogin.Text);
                cmd.Parameters.AddWithValue("@passwd", txtPass.Text);
                cmd.Parameters.AddWithValue("@Role", "New_User");
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
