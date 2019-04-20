using Kursa4_krixn_exploid.Class;
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

namespace Kursa4_krixn_exploid.Forms
{
    public partial class coach_crud : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public int objstate;

        public bool success;

        Sqlconnect CC = new Sqlconnect();

        public coach_crud()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTOP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Length > 0 && txtLastname.Text.Length > 0 && txtCountry.Text.Length > 0)
            {
                if (objstate == 2)
                {
                    CC.firstname_coach = txtFirstname.Text;
                    CC.lastname_coach = txtLastname.Text;
                    CC.country_coach = txtCountry.Text;
                    CC.experience_coach = int.Parse(txtexp.Text);
                    CC.birthday_coach = txtBirthday.Value.ToShortDateString();
                    CC.id_coach = int.Parse(txtid_coach.Text);
                    string messbox = string.Format("Игрок {0} {1} был успешно отредактирован.", txtFirstname.Text, txtLastname.Text);
                    success = CC.Update_Coach();
                    if (success == true)
                    {
                        MessageBox.Show(messbox);
                        Close();
                    }
                    else MessageBox.Show("Ошибка при редактирование игрока.");
                }
                else if (objstate == 1)
                {
                    CC.firstname_coach = txtFirstname.Text;
                    CC.lastname_coach = txtLastname.Text;
                    CC.country_coach = txtCountry.Text;
                    CC.birthday_coach = txtBirthday.Value.ToShortDateString();
                    CC.experience_coach = int.Parse(txtexp.Text);
                    string messbox = string.Format("Тренер {0} {1} был успешно добавлен.", txtFirstname.Text, txtLastname.Text);
                    success = CC.Insert_Coach();
                    if (success == true)
                    {
                        MessageBox.Show(messbox);
                        Close();
                    }
                    else MessageBox.Show("Ошибка при добавление тренера.");
                }
            }
            else MessageBox.Show("Ошибка, проверьте чтобы все поля были заполнены.");
        }
    }
}
