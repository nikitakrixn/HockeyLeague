using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursa4_krixn_exploid.Class;
using Kursa4_krixn_exploid.Forms;

namespace Kursa4_krixn_exploid
{
    public partial class games_fc : UserControl
    {
        public games_fc()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            Sqlconnect c = new Sqlconnect();
            c.query = "exec Games_Select";
            DataGridGames.DataSource = c.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                using (preview_game previewGG = new preview_game())
                {
                    previewGG.lblHscore.Text = DataGridGames.CurrentRow.Cells[6].Value.ToString();
                    previewGG.lblAscore.Text = DataGridGames.CurrentRow.Cells[7].Value.ToString();
                    previewGG.lblCurrentCity.Text = DataGridGames.CurrentRow.Cells[1].Value.ToString();
                    previewGG.lblStadium.Text = DataGridGames.CurrentRow.Cells[3].Value.ToString();
                    previewGG.lblDateMatch.Text = DataGridGames.CurrentRow.Cells[2].FormattedValue.ToString();

                    switch (DataGridGames.CurrentRow.Cells[4].Value.ToString())
                    {
                        case "Avangard": previewGG.pctHteam.Image = Logos.Avangard_Omsk_logo; break;
                        case "Automobilist": previewGG.pctHteam.Image = Logos.Avtomobilist_Yekaterinburg_Logo; break;
                        case "Admiral": previewGG.pctHteam.Image = Logos.Admiral_01; break;
                        case "Ak-Bars": previewGG.pctHteam.Image = Logos.Ak_Bars_Kazan_Logo; break;
                        case "Vityaz": previewGG.pctHteam.Image = Logos.Vityaz; break;
                        case "Dinamo Minsk": previewGG.pctHteam.Image = Logos.Dinamo_Minsk; break;
                        case "Dinamo Moscow": previewGG.pctHteam.Image = Logos.Dinamo_msk; break;
                        case "Dinamo Riga": previewGG.pctHteam.Image = Logos.Dinamo_riga; break;
                        case "Kunlun RedStar": previewGG.pctHteam.Image = Logos.kunlun_red_star; break;
                        case "Metallurg": previewGG.pctHteam.Image = Logos.metallurg_magnitogorsk; break;
                        case "Neftekhimik": previewGG.pctHteam.Image = Logos.HC_Neftekhimik_logo; break;
                        case "Salavat-Yulayev": previewGG.pctHteam.Image = Logos.Salavat_ulaev; break;
                        case "Slovan": previewGG.pctHteam.Image = Logos.slovan_bratislava_min; break;
                        case "Severstal": previewGG.pctHteam.Image = Logos.Severstal_Cherepovets; break;
                        case "SKA": previewGG.pctHteam.Image = Logos.SKA_2015; break;
                        case "Sibir": previewGG.pctHteam.Image = Logos.sibir_novosibirskaya; break;
                        case "Spartak": previewGG.pctHteam.Image = Logos.HC_Spartak_Moscow; break;
                        case "Torpedo": previewGG.pctHteam.Image = Logos.torpedo; break;
                        case "Traktor": previewGG.pctHteam.Image = Logos.Traktor; break;
                        case "CSKA": previewGG.pctHteam.Image = Logos.Cska; break;
                        default:
                            previewGG.pctHteam.Image = Logos.NoLogo;
                            break;
                    }
                    switch (DataGridGames.CurrentRow.Cells[5].Value.ToString())
                    {
                        case "Avangard": previewGG.pctAteam.Image = Logos.Avangard_Omsk_logo; break;
                        case "Automobilist": previewGG.pctAteam.Image = Logos.Avtomobilist_Yekaterinburg_Logo; break;
                        case "Admiral": previewGG.pctAteam.Image = Logos.Admiral_01; break;
                        case "Ak-Bars": previewGG.pctAteam.Image = Logos.Ak_Bars_Kazan_Logo; break;
                        case "Vityaz": previewGG.pctAteam.Image = Logos.Vityaz; break;
                        case "Dinamo Minsk": previewGG.pctAteam.Image = Logos.Dinamo_Minsk; break;
                        case "Dinamo Moscow": previewGG.pctAteam.Image = Logos.Dinamo_msk; break;
                        case "Dinamo Riga": previewGG.pctAteam.Image = Logos.Dinamo_riga; break;
                        case "Kunlun RedStar": previewGG.pctAteam.Image = Logos.kunlun_red_star; break;
                        case "Metallurg": previewGG.pctAteam.Image = Logos.metallurg_magnitogorsk; break;
                        case "Neftekhimik": previewGG.pctAteam.Image = Logos.HC_Neftekhimik_logo; break;
                        case "Salavat-Yulayev": previewGG.pctAteam.Image = Logos.Salavat_ulaev; break;
                        case "Slovan": previewGG.pctAteam.Image = Logos.slovan_bratislava_min; break;
                        case "Severstal": previewGG.pctAteam.Image = Logos.Severstal_Cherepovets; break;
                        case "SKA": previewGG.pctAteam.Image = Logos.SKA_2015; break;
                        case "Sibir": previewGG.pctAteam.Image = Logos.sibir_novosibirskaya; break;
                        case "Spartak": previewGG.pctAteam.Image = Logos.HC_Spartak_Moscow; break;
                        case "Torpedo": previewGG.pctAteam.Image = Logos.torpedo; break;
                        case "Traktor": previewGG.pctAteam.Image = Logos.Traktor; break;
                        case "CSKA": previewGG.pctAteam.Image = Logos.Cska; break;
                        default:
                            previewGG.pctAteam.Image = Logos.NoLogo;
                            break;
                    }
                    if((bool)DataGridGames.CurrentRow.Cells[8].Value == true)
                    {
                        previewGG.lblMatchInfo.Text = "Матч состоялся";
                    }
                    else previewGG.lblMatchInfo.Text = "Матч не состоялся";
                    previewGG.ShowDialog();
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
                using (games_crud game = new games_crud())
                {
                    game.txtHomeScore.Visible = false;
                    game.txtAwayScore.Visible = false;
                    game.lblAwayScore.Visible = false;
                    game.lblHomeScore.Visible = false;
                    game.lblFormName.Text = "Игра: Добавление";
                    game.lblId_team.Visible = false;
                    game.txtid_game.Visible = false;
                    game.cmbStatusGame.Visible = false;
                    game.lblStatusGame.Visible = false;
                    game.objstate = (int)Enums.Checked.Insert;
                    game.LoadData();
                    game.ShowDialog();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string messege = string.Format("Удалить игру №{0} между командами {1} и {2}", DataGridGames.CurrentRow.Cells[0].Value.ToString(), 
                    DataGridGames.CurrentRow.Cells[4].Value.ToString(), DataGridGames.CurrentRow.Cells[5].Value.ToString());
                if (MessageBox.Show(messege, "Подтверждение удаления",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Sqlconnect CG = new Sqlconnect();
                    CG.id_games = (int)DataGridGames.CurrentRow.Cells[0].Value;
                    CG.Delete_Game();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (games_crud game = new games_crud())
                {
                    //game.LoadData();
                    game.txtid_game.Text = DataGridGames.CurrentRow.Cells[0].Value.ToString();
                    game.txtCity.Text = DataGridGames.CurrentRow.Cells[1].Value.ToString();
                    game.txtDate.Text = DataGridGames.CurrentRow.Cells[2].Value.ToString();
                    game.cmbArena.SelectedValue = (int)DataGridGames.CurrentRow.Cells[3].Value;
                    game.cmbHomeTeam.SelectedValue = (int)DataGridGames.CurrentRow.Cells[4].Value;
                    game.cmbAwayTeam.SelectedValue = (int)DataGridGames.CurrentRow.Cells[5].Value;
                    game.txtHomeScore.Value = (int)DataGridGames.CurrentRow.Cells[6].Value;
                    game.txtAwayScore.Value = (int)DataGridGames.CurrentRow.Cells[7].Value;
                    if((bool)DataGridGames.CurrentRow.Cells[8].Value == true)
                    {
                        game.status_game = true;
                        game.cmbStatusGame.SelectedValue = 0;
                    }
                    else
                    {
                        game.status_game = false;
                        game.cmbStatusGame.SelectedValue = 1;
                    }
                    game.objstate = (int)Enums.Checked.Update;
                    game.lblFormName.Text = "Игрок: Редактирование";
                    game.LoadData();
                    game.ShowDialog();
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
