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
    public partial class add_player : Form
    {

        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public int id_team; //Id команды
        public int id_coach; //Id тренера

        Sqlconnect SQL = new Sqlconnect(); //Ссылка на объект

        public add_player()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            SQL.query = "exec LineUp_Select 23";
            cmbPlayers.DataSource = SQL.Select();
            cmbPlayers.DisplayMember = "Игрок";
            cmbPlayers.ValueMember = "IDPLAYER";
            cmbPlayers.SelectedValue = -1;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Свернуть
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();//Выход
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            SQL.id_coach = id_coach;
            SQL.id_player = (int)cmbPlayers.SelectedValue;
            SQL.id_team = id_team;
            SQL.dateby = dtdateBy.Text.ToString();
            SQL.datefrom = dtDateFrom.Text.ToString();
            bool success = SQL.Update_LineUP();
            if (success == true)
            {
                MessageBox.Show("Игрок " + cmbPlayers.Text + " . Успешно добавился в команду!");
                Close();
            }
            else MessageBox.Show("Ошибка при добавлении игрока.");
        }
    }
}
