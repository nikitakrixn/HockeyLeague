using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Kursa4_krixn_exploid.Class;

namespace Kursa4_krixn_exploid
{
    public partial class LoginSql : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public bool connected;

        Loading load = new Loading();

        public LoginSql()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginSql_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ДОРАБОТАТЬ ВЗАИМОДЕЙСТВИЕ С TEXTBOX
            connected = false;
            Sqlconnect SQLhelp = new Sqlconnect();
            SQLhelp.connection = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};", cmbServer.selectedValue, txtNameDataBase.Text, txtLogin.Text, txtPassword.Text);
            try
            {
                SQLhelp.sqlConnect();
                if (SQLhelp.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("cn", SQLhelp.connection);
                    MessageBox.Show("Ваша строка подключения успешно сохранена.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connected = true;
                    SQLhelp.ConnectClose();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void LoginSql_Load(object sender, EventArgs e)
        {
            cmbServer.Clear();
            cmbServer.AddItem(Environment.MachineName);
            cmbServer.AddItem(@".\SQLEXPRESS");
            cmbServer.AddItem(string .Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cmbServer.selectedIndex = 2;
            txtNameDataBase.Text = "hockeyleague";
        }

        private void lblLoginCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_user cuser = new Create_user();
            cuser.ShowDialog();
            this.Show();
        }
    }
}
