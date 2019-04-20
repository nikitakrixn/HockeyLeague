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
using System.Runtime.InteropServices;
using Kursa4_krixn_exploid.Class;

namespace Kursa4_krixn_exploid
{
    public partial class Main : Form
    {
        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Sqlconnect sqlhelp = new Sqlconnect(); // Ссылка на класс с sql запросами

        //SQL ROLES
        public bool admin;
        public bool guest;
        public bool manager_teams;
        public bool manager_games;

        public Main()
        {
            InitializeComponent();
        }

        //Загрузка формы
        private void Main_Load(object sender, EventArgs e)
        {
            Check_Role();
            VisibleOff();
        }

        private void Check_Role()
        {
            admin = sqlhelp.Check_Admin();
            guest = sqlhelp.Check_Guest();
            manager_games = sqlhelp.Check_ManagerGames();
            manager_teams = sqlhelp.Check_ManagerTeams();
            if (admin == true) lblAdmin.Text = "Администратор";
            else if(guest == true) lblAdmin.Text = "Гость";
            else if(manager_games == true) lblAdmin.Text = "Менеджер Игр";
            else if (manager_teams == true) lblAdmin.Text = "Менеджер Команд";
        }
        //Отключение видимости вспомогательных форм
        private void VisibleOff()
        {
            teams_fs1.Visible = false;
            players_fc1.Visible = false;
            coachs_fc1.Visible = false;
            games_fc1.Visible = false;
            stats_fc1.Visible = false;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);//Выход
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
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
            WindowState = FormWindowState.Minimized;//Свернуть
        }

        //Перемещение бокового меню
        private void btnMenuSlider_Click(object sender, EventArgs e)
        {
            
        }

        //Появление формы команды
        private void btnTeams_Click(object sender, EventArgs e)
        {
            if (!manager_games)
            {
                VisibleOff();
                teams_fs1.LoadData();
                teams_fs1.Visible = true;
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этому разделу");
                btnTeams.selected = false;
            }
        }

        //Развернуть форму
        private void btnFull_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        //Появление формы игроков
        private void btnPlayers_Click(object sender, EventArgs e)
        {
            if (!manager_games)
            {
                VisibleOff();
                players_fc1.LoadData();
                players_fc1.Visible = true;
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этому разделу");
                btnPlayers.selected = false;
            }
        }

        //Появление формы тренеров
        private void btnCoachs_Click(object sender, EventArgs e)
        {
            if (!manager_games)
            {
                VisibleOff();
                coachs_fc1.LoadData();
                coachs_fc1.Visible = true;
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этому разделу");
                btnCoachs.selected = false;
            }
        }

        //Появление формы матчей
        private void btnGames_Click(object sender, EventArgs e)
        {
            if (!manager_teams && !manager_teams)
            {
                VisibleOff();
                games_fc1.LoadData();
                games_fc1.Visible = true;
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этому разделу");
            }
        }

        //Появление формы статистики команд
        private void btnStats_Click(object sender, EventArgs e)
        {
            if (!manager_games)
            {
                VisibleOff();
                stats_fc1.LoadData();
                stats_fc1.Visible = true;
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этому разделу");
            }
        }
    }
}
