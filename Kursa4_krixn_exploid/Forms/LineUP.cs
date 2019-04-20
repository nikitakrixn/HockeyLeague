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
    public partial class LineUP : Form
    {
        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string team_id;

        public LineUP()
        {
            InitializeComponent();
            CenterToScreen(); //Появление в центре экрана
        }

        public void LoadData()
        {
            Sqlconnect c = new Sqlconnect();
            c.query = "Exec LineUp_Select " + team_id;
            dvgLineUP.DataSource = c.Select();
            dvgLineUP.Columns["Команда"].Visible = false;
            dvgLineUP.Columns["Тренер"].Visible = false;
            dvgLineUP.Columns["ID"].Visible = false;
            dvgLineUP.Columns["IDCOACH"].Visible = false;
            dvgLineUP.Columns["IDPLAYER"].Visible = false;
            lblNameTeam.Text = dvgLineUP.Rows[0].Cells[0].Value.ToString();
            lblNameCoach.Text = dvgLineUP.Rows[0].Cells[1].Value.ToString();
            switch (int.Parse(team_id))
            {
                case 1: pctLogo.Image = Logos.Avangard_Omsk_logo; break;
                case 2: pctLogo.Image = Logos.Avtomobilist_Yekaterinburg_Logo; break;
                case 3: pctLogo.Image = Logos.Admiral_01; break;
                case 4: pctLogo.Image = Logos.Ak_Bars_Kazan_Logo; break;
                case 5: pctLogo.Image = Logos.Vityaz; break;
                case 6: pctLogo.Image = Logos.Dinamo_Minsk; break;
                case 7: pctLogo.Image = Logos.Dinamo_msk; break;
                case 8: pctLogo.Image = Logos.Dinamo_riga; break;
                case 9: pctLogo.Image = Logos.kunlun_red_star; break;
                case 10: pctLogo.Image = Logos.metallurg_magnitogorsk; break;
                case 11: pctLogo.Image = Logos.HC_Neftekhimik_logo; break;
                case 12: pctLogo.Image = Logos.Salavat_ulaev; break;
                case 13: pctLogo.Image = Logos.slovan_bratislava_min; break;
                case 14: pctLogo.Image = Logos.Severstal_Cherepovets; break;
                case 15: pctLogo.Image = Logos.SKA_2015; break;
                case 16: pctLogo.Image = Logos.sibir_novosibirskaya; break;
                case 17: pctLogo.Image = Logos.HC_Spartak_Moscow; break;
                case 18: pctLogo.Image = Logos.torpedo; break;
                case 19: pctLogo.Image = Logos.Traktor; break;
                case 20: pctLogo.Image = Logos.Cska; break;
                default:
                    pctLogo.Image = Logos.NoLogo;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LineUP_MouseMove(object sender, MouseEventArgs e)
        {
            //Перемещение
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить игрока " + dvgLineUP.CurrentRow.Cells["Игрок"].Value.ToString(), "Подтверждение удаления",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Sqlconnect LP = new Sqlconnect();
                    LP.id_lineup = (int)dvgLineUP.CurrentRow.Cells["ID"].Value;
                    LP.Delete_LineUP();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using(add_player addplayer = new add_player())
                {
                    addplayer.id_team = int.Parse(team_id);
                    addplayer.id_coach = (int)dvgLineUP.Rows[0].Cells["IDCOACH"].Value;
                    addplayer.LoadData();
                    addplayer.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadData();
            }
        }
    }
}
