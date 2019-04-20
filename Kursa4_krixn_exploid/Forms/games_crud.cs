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
    public partial class games_crud : Form
    {
        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Sqlconnect CG = new Sqlconnect();

        public int objstate;

        private bool success;

        public bool status_game;

        public string date;

        public games_crud()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            CG.query = "exec Teams_Select";
            cmbHomeTeam.DataSource = CG.Select();
            cmbHomeTeam.DisplayMember = "НазваниеКоманды";
            cmbHomeTeam.ValueMember = "id_team";
            cmbAwayTeam.DataSource = CG.Select();
            cmbAwayTeam.DisplayMember = "НазваниеКоманды";
            cmbAwayTeam.ValueMember = "id_team";
            CG.query = "Select * From Stadium";
            cmbArena.DataSource = CG.Select();
            cmbArena.DisplayMember = "Name";
            cmbArena.ValueMember = "id_stadium";
        }
        private void games_crud_Load(object sender, EventArgs e)
        {
            if (objstate == 1)
            {
                cmbHomeTeam.SelectedValue = -1;
                cmbAwayTeam.SelectedValue = -1;
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCity.Text.Length > 3 && cmbAwayTeam.Text.Length > 3 && cmbHomeTeam.Text.Length > 3 && cmbArena.Text.Length > 3)
            {
                if (objstate == 1)
                {
                    CG.City_games = txtCity.Text;
                    CG.Date_games = txtDate.Value.ToShortDateString();
                    CG.Arena_games = (int)cmbArena.SelectedValue;
                    CG.HomeTeam_games = (int)cmbHomeTeam.SelectedValue;
                    CG.AwayTeam_games = (int)cmbAwayTeam.SelectedValue;
                    success = CG.Insert_Game();
                    if (success == true)
                    {
                        MessageBox.Show("Игра успешно была добавлена!");
                        Close();
                    }
                    else MessageBox.Show("Ошибка при добавлении игры.");
                }
                else if (objstate == 2)
                {
                    if ((int)cmbStatusGame.SelectedValue == 0)
                    {
                        status_game = true;
                    }
                    else if ((int)cmbStatusGame.SelectedValue == 1) status_game = false;
                    CG.City_games = txtCity.Text;
                    CG.Date_games = txtDate.Value.ToLongTimeString();
                    CG.Arena_games = (int)cmbArena.SelectedValue;
                    CG.HomeTeam_games = (int)cmbHomeTeam.SelectedValue;
                    CG.AwayTeam_games = (int)cmbAwayTeam.SelectedValue;
                    CG.AwayScore_games = (int)txtAwayScore.Value;
                    CG.HomeScore_games = (int)txtHomeScore.Value;
                    CG.id_games = int.Parse(txtid_game.Text);
                    CG.Status_games = status_game;
                    success = CG.Update_Game();
                    if (success == true)
                    {
                        MessageBox.Show("Игра успешно была отредактирована!");
                        Close();
                    }
                    else MessageBox.Show("Ошибка при редактировании игры.");
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
            //Перемещение
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Свернуть
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
