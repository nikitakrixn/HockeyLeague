using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursa4_krixn_exploid.Class;

namespace Kursa4_krixn_exploid.Forms
{
    public partial class player_crud : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public int objstate;

        public bool success;

        Sqlconnect CP = new Sqlconnect();

        public player_crud()
        {
            InitializeComponent();
        }

        private void pnlTOP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Length > 0 && txtLastname.Text.Length > 0 && txtCountry.Text.Length > 0 && cmbPosition.Text.Length > 0)
            {
                if (objstate == 2)
                {
                    CP.firstname_player = txtFirstname.Text;
                    CP.lastname_player = txtLastname.Text;
                    CP.jersey_number_player = int.Parse(txtJersey.Text);
                    CP.country_player = txtCountry.Text;
                    CP.birthday_player = txtBirthday.Value.ToShortDateString();
                    CP.position_player = cmbPosition.Text.ToString();
                    CP.id_player = int.Parse(txtid_player.Text);
                    CP.Update_Player();
                    string messbox = string.Format("Игрок {0} {1} был успешно отредактирован.", txtFirstname.Text, txtLastname.Text);
                    success = CP.Update_Player();
                    if (success == true)
                    {
                        MessageBox.Show(messbox);
                        Close();
                    }
                    else MessageBox.Show("Ошибка при редактирование игрока.");
                }
                else if (objstate == 1)
                {
                    CP.firstname_player = txtFirstname.Text;
                    CP.lastname_player = txtLastname.Text;
                    CP.jersey_number_player = int.Parse(txtJersey.Text);
                    CP.country_player = txtCountry.Text;
                    CP.birthday_player = txtBirthday.Value.ToShortDateString();
                    CP.position_player = cmbPosition.Text.ToString();
                    string messbox = string.Format("Игрок {0} {1} был успешно добавлен.", txtFirstname.Text, txtLastname.Text);
                    success = CP.Insert_Player();
                    if (success == true)
                    {
                        MessageBox.Show(messbox);
                        Close();
                    }
                    else MessageBox.Show("Ошибка при добавление игрока.");
                }
            }
            else MessageBox.Show("Ошибка, проверьте чтобы все поля были заполнены.");
        }
    }
}
