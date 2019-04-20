using System;
using System.Data;
using System.Windows.Forms;
using Kursa4_krixn_exploid.Class;
using System.Drawing;
using System.IO;

namespace Kursa4_krixn_exploid.Forms
{
    public partial class teams_fs : UserControl
    {
        Sqlconnect c = new Sqlconnect();

        public teams_fs()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            c.query = "EXEC Teams_Select";
            DataTable dt = c.Select();
            DataGridTeams.DataSource = dt;
        }

        private void DataGridTeams_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (preview_team previewTM = new preview_team())
            {
                previewTM.lblID.Text = DataGridTeams.CurrentRow.Cells[0].Value.ToString();
                previewTM.lblNameTeam.Text = "НАЗВАНИЕ: " + DataGridTeams.CurrentRow.Cells[1].Value.ToString();
                previewTM.lblCity.Text = "ГОРОД: " + DataGridTeams.CurrentRow.Cells[2].Value.ToString();
                previewTM.lblCountry.Text = "СТРАНА: " + DataGridTeams.CurrentRow.Cells[3].Value.ToString();
                previewTM.lblCreated.Text = "ДАТА СОЗДАНИЯ: " + DataGridTeams.CurrentRow.Cells[4].FormattedValue.ToString();
                switch ((int)DataGridTeams.CurrentRow.Cells[0].Value)
                {
                    case 1:previewTM.ptcBox.Image = Logos.Avangard_Omsk_logo;break;
                    case 2:previewTM.ptcBox.Image = Logos.Avtomobilist_Yekaterinburg_Logo;break;
                    case 3:previewTM.ptcBox.Image = Logos.Admiral_01;break;
                    case 4:previewTM.ptcBox.Image = Logos.Ak_Bars_Kazan_Logo;break;
                    case 5:previewTM.ptcBox.Image = Logos.Vityaz; break;
                    case 6: previewTM.ptcBox.Image = Logos.Dinamo_Minsk;break;
                    case 7:previewTM.ptcBox.Image = Logos.Dinamo_msk;break;
                    case 8: previewTM.ptcBox.Image = Logos.Dinamo_riga; break;
                    case 9: previewTM.ptcBox.Image = Logos.kunlun_red_star; break;
                    case 10: previewTM.ptcBox.Image = Logos.metallurg_magnitogorsk; break;
                    case 11: previewTM.ptcBox.Image = Logos.HC_Neftekhimik_logo; break;
                    case 12: previewTM.ptcBox.Image = Logos.Salavat_ulaev; break;
                    case 13: previewTM.ptcBox.Image = Logos.slovan_bratislava_min; break;
                    case 14: previewTM.ptcBox.Image = Logos.Severstal_Cherepovets; break;
                    case 15: previewTM.ptcBox.Image = Logos.SKA_2015; break;
                    case 16: previewTM.ptcBox.Image = Logos.sibir_novosibirskaya; break;
                    case 17: previewTM.ptcBox.Image = Logos.HC_Spartak_Moscow; break;
                    case 18: previewTM.ptcBox.Image = Logos.torpedo; break;
                    case 19: previewTM.ptcBox.Image = Logos.Traktor; break;
                    case 20: previewTM.ptcBox.Image = Logos.Cska; break;
                    default:
                        previewTM.ptcBox.Image = Logos.NoLogo;
                        break;
                }
                previewTM.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (team_crud previewTM = new team_crud())
            {
                try
                {
                    previewTM.objstate = (int)Enums.Checked.Update;
                    previewTM.lblFormName.Text = "Команда: Редактирования";
                    previewTM.txtid_team.Text = DataGridTeams.CurrentRow.Cells[0].Value.ToString();
                    previewTM.txtName.Text = DataGridTeams.CurrentRow.Cells[1].Value.ToString();
                    previewTM.txtCity.Text = DataGridTeams.CurrentRow.Cells[2].Value.ToString();
                    previewTM.txtCountry.Text = DataGridTeams.CurrentRow.Cells[3].Value.ToString();
                    previewTM.txtCreatedAt.Text = DataGridTeams.CurrentRow.Cells[4].FormattedValue.ToString();
                    switch ((int)DataGridTeams.CurrentRow.Cells[0].Value)
                    {
                        case 1: previewTM.logoPreview.Image = Logos.Avangard_Omsk_logo; break;
                        case 2: previewTM.logoPreview.Image = Logos.Avtomobilist_Yekaterinburg_Logo; break;
                        case 3: previewTM.logoPreview.Image = Logos.Admiral_01; break;
                        case 4: previewTM.logoPreview.Image = Logos.Ak_Bars_Kazan_Logo; break;
                        case 5: previewTM.logoPreview.Image = Logos.Vityaz; break;
                        case 6: previewTM.logoPreview.Image = Logos.Dinamo_Minsk; break;
                        case 7: previewTM.logoPreview.Image = Logos.Dinamo_msk; break;
                        case 8: previewTM.logoPreview.Image = Logos.Dinamo_riga; break;
                        case 9: previewTM.logoPreview.Image = Logos.kunlun_red_star; break;
                        case 10: previewTM.logoPreview.Image = Logos.metallurg_magnitogorsk; break;
                        case 11: previewTM.logoPreview.Image = Logos.HC_Neftekhimik_logo; break;
                        case 12: previewTM.logoPreview.Image = Logos.Salavat_ulaev; break;
                        case 13: previewTM.logoPreview.Image = Logos.slovan_bratislava_min; break;
                        case 14: previewTM.logoPreview.Image = Logos.Severstal_Cherepovets; break;
                        case 15: previewTM.logoPreview.Image = Logos.SKA_2015; break;
                        case 16: previewTM.logoPreview.Image = Logos.sibir_novosibirskaya; break;
                        case 17: previewTM.logoPreview.Image = Logos.HC_Spartak_Moscow; break;
                        case 18: previewTM.logoPreview.Image = Logos.torpedo; break;
                        case 19: previewTM.logoPreview.Image = Logos.Traktor; break;
                        case 20: previewTM.logoPreview.Image = Logos.Cska; break;
                        default:
                            previewTM.logoPreview.Image = Logos.NoLogo;
                            break;
                    }
                    previewTM.ShowDialog();
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (preview_team previewTM = new preview_team())
            {
                try
                {
                    previewTM.lblID.Text = DataGridTeams.CurrentRow.Cells[0].Value.ToString();
                    previewTM.lblNameTeam.Text = "НАЗВАНИЕ: " + DataGridTeams.CurrentRow.Cells[1].Value.ToString();
                    previewTM.lblCity.Text = "ГОРОД: " + DataGridTeams.CurrentRow.Cells[2].Value.ToString();
                    previewTM.lblCountry.Text = "СТРАНА: " + DataGridTeams.CurrentRow.Cells[3].Value.ToString();
                    previewTM.lblCreated.Text = "ДАТА СОЗДАНИЯ: " + DataGridTeams.CurrentRow.Cells[4].FormattedValue.ToString();
                    switch ((int)DataGridTeams.CurrentRow.Cells[0].Value)
                    {
                        case 1: previewTM.ptcBox.Image = Logos.Avangard_Omsk_logo; break;
                        case 2: previewTM.ptcBox.Image = Logos.Avtomobilist_Yekaterinburg_Logo; break;
                        case 3: previewTM.ptcBox.Image = Logos.Admiral_01; break;
                        case 4: previewTM.ptcBox.Image = Logos.Ak_Bars_Kazan_Logo; break;
                        case 5: previewTM.ptcBox.Image = Logos.Vityaz; break;
                        case 6: previewTM.ptcBox.Image = Logos.Dinamo_Minsk; break;
                        case 7: previewTM.ptcBox.Image = Logos.Dinamo_msk; break;
                        case 8: previewTM.ptcBox.Image = Logos.Dinamo_riga; break;
                        case 9: previewTM.ptcBox.Image = Logos.kunlun_red_star; break;
                        case 10: previewTM.ptcBox.Image = Logos.metallurg_magnitogorsk; break;
                        case 11: previewTM.ptcBox.Image = Logos.HC_Neftekhimik_logo; break;
                        case 12: previewTM.ptcBox.Image = Logos.Salavat_ulaev; break;
                        case 13: previewTM.ptcBox.Image = Logos.slovan_bratislava_min; break;
                        case 14: previewTM.ptcBox.Image = Logos.Severstal_Cherepovets; break;
                        case 15: previewTM.ptcBox.Image = Logos.SKA_2015; break;
                        case 16: previewTM.ptcBox.Image = Logos.sibir_novosibirskaya; break;
                        case 17: previewTM.ptcBox.Image = Logos.HC_Spartak_Moscow; break;
                        case 18: previewTM.ptcBox.Image = Logos.torpedo; break;
                        case 19: previewTM.ptcBox.Image = Logos.Traktor; break;
                        case 20: previewTM.ptcBox.Image = Logos.Cska; break;
                        default:
                            previewTM.ptcBox.Image = Logos.NoLogo;
                            break;
                    }
                    previewTM.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadData();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (team_crud previewTM = new team_crud())
            {
                previewTM.lblId_team.Visible = false;
                previewTM.txtid_team.Visible = false;
                previewTM.objstate = (int)Enums.Checked.Insert;
                previewTM.lblFormName.Text = "Команда: Добавление";
                previewTM.logoPreview.Image = Logos.NoLogo;
                previewTM.ShowDialog();
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string messege = string.Format("Удалить команду {0}", DataGridTeams.CurrentRow.Cells[1].Value.ToString());
                if (MessageBox.Show(messege, "Подтверждение удаления",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Sqlconnect CT = new Sqlconnect();
                    CT.id_team = (int)DataGridTeams.CurrentRow.Cells[0].Value;
                    CT.Delete_Team();
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

        private void txtSearchBox_OnTextChange(object sender, EventArgs e)
        {
           (DataGridTeams.DataSource as DataTable).DefaultView.RowFilter = string.Format("НазваниеКоманды LIKE '%{0}%'", txtSearchBox.text);
        }

        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            txtSearchBox.text = "Поиск";
            LoadData();
        }

        private void teams_fs_Load(object sender, EventArgs e)
        {
            
        }
    }
}
