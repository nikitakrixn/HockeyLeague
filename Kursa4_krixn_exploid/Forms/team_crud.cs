using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursa4_krixn_exploid.Class;
using System.Runtime.InteropServices;
using System.IO;

namespace Kursa4_krixn_exploid.Forms
{
    public partial class team_crud : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Sqlconnect CT = new Sqlconnect();

        public bool success;

        public int objstate;
        
        public team_crud()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtCity.Text.Length > 0 && txtCountry.Text.Length > 0 && txtCreatedAt.Text.Length > 0)
            {
                if (objstate == 2)
                {
                    //Вносим в данные в класс Contact_teams
                    CT.Name_team = txtName.Text;
                    CT.City_team = txtCity.Text;
                    CT.Country_team = txtCountry.Text;
                    CT.CreatedAt_team = txtCreatedAt.Value.ToShortDateString();
                    CT.id_team = int.Parse(txtid_team.Text);
                    string messbox = string.Format("Команда {0} была успешно отредактирована.", txtName.Text);
                    success = CT.Update_Team();
                    if (success == true)
                    {
                        MessageBox.Show(messbox);
                        Close();
                    }
                    else MessageBox.Show("Ошибка при редактирование команды.");
                }
                else if (objstate == 1)
                {
                    CT.Name_team = txtName.Text;
                    CT.City_team = txtCity.Text;
                    CT.Country_team = txtCountry.Text;
                    CT.CreatedAt_team = txtCreatedAt.Value.ToShortDateString();
                    string messbox = string.Format("Команда {0} была успешно добавлена.", txtName.Text);
                    success = CT.Insert_Team();
                    if (success == true)
                    {
                        MessageBox.Show(messbox);
                        Close();
                    }
                    else MessageBox.Show("Ошибка при добавлении команды.");
                }
            }
            else MessageBox.Show("Ошибка, проверьте чтобы все поля были заполнены.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void chooseImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
            /*using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PNG|*.png", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    logoPreview.Image = Image.FromFile(ofd.FileName);
                }
            }*/
        }
    }
}
