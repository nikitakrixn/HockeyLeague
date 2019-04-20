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

namespace Kursa4_krixn_exploid.Forms
{
    public partial class players_fc : UserControl
    {
        public players_fc()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            Sqlconnect c = new Sqlconnect();
            c.query = "Exec Players_Select";
            DataGridPlayers.DataSource = c.Select();
        }

        private void txtSearchBox_OnValueChanged(object sender, EventArgs e)
        {
            (DataGridPlayers.DataSource as DataTable).DefaultView.RowFilter = string.Format("Имя LIKE '%{0}%' OR Фамилия Like '%{1}%'", txtSearchBox.text, txtSearchBox.text);
        }

        private void DataGridPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (preview_player previewPL = new preview_player())
                {
                    previewPL.lblFirstName.Text = "ИМЯ: " + DataGridPlayers.CurrentRow.Cells[1].Value.ToString();
                    previewPL.lblLastName.Text = "ФАМИЛИЯ: " + DataGridPlayers.CurrentRow.Cells[2].Value.ToString();
                    previewPL.lbljersy.Text = "НОМЕР ИГРОКА # " + DataGridPlayers.CurrentRow.Cells[3].Value.ToString();
                    previewPL.lblCountry.Text = "СТРАНА: " + DataGridPlayers.CurrentRow.Cells[4].Value.ToString();
                    previewPL.lblbirthday.Text = "ДАТА РОЖДЕНИЯ: " + DataGridPlayers.CurrentRow.Cells[5].FormattedValue.ToString();
                    previewPL.lblposition.Text = "ПОЗИЦИЯ: " + DataGridPlayers.CurrentRow.Cells[6].Value.ToString();
                    previewPL.ShowDialog();
                }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (player_crud previewPL = new player_crud())
                {
                    previewPL.objstate = (int)Enums.Checked.Update;
                    previewPL.lblFormName.Text = "Игрок: Редактирование";
                    previewPL.txtid_player.Text = DataGridPlayers.CurrentRow.Cells[0].Value.ToString();
                    previewPL.txtFirstname.Text = DataGridPlayers.CurrentRow.Cells[1].Value.ToString();
                    previewPL.txtLastname.Text = DataGridPlayers.CurrentRow.Cells[2].Value.ToString();
                    previewPL.txtJersey.Text = DataGridPlayers.CurrentRow.Cells[3].Value.ToString();
                    previewPL.txtCountry.Text = DataGridPlayers.CurrentRow.Cells[4].Value.ToString();
                    previewPL.txtBirthday.Text = DataGridPlayers.CurrentRow.Cells[5].FormattedValue.ToString();
                    previewPL.cmbPosition.Text = DataGridPlayers.CurrentRow.Cells[6].Value.ToString();
                    previewPL.ShowDialog();
                }
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                using (preview_player previewPL = new preview_player())
                {
                    previewPL.lblFirstName.Text = "ИМЯ: " + DataGridPlayers.CurrentRow.Cells[1].Value.ToString();
                    previewPL.lblLastName.Text = "ФАМИЛИЯ: " + DataGridPlayers.CurrentRow.Cells[2].Value.ToString();
                    previewPL.lbljersy.Text = "НОМЕР ИГРОКА # " + DataGridPlayers.CurrentRow.Cells[3].Value.ToString();
                    previewPL.lblCountry.Text = "СТРАНА: " + DataGridPlayers.CurrentRow.Cells[4].Value.ToString();
                    previewPL.lblbirthday.Text = "ДАТА РОЖДЕНИЯ: " + DataGridPlayers.CurrentRow.Cells[5].FormattedValue.ToString();
                    previewPL.lblposition.Text = "ПОЗИЦИЯ: " + DataGridPlayers.CurrentRow.Cells[6].Value.ToString();
                    previewPL.ShowDialog();
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
            using(player_crud previewPL = new player_crud())
            {
                previewPL.txtid_player.Visible = false;
                previewPL.lblId_team.Visible = false;
                previewPL.objstate = (int)Enums.Checked.Insert;
                previewPL.lblFormName.Text = "Игрок: Добавление";
                previewPL.ShowDialog();
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string messege = string.Format("Удалить игрока {0} {1}", DataGridPlayers.CurrentRow.Cells[1].Value.ToString(), DataGridPlayers.CurrentRow.Cells[2].Value.ToString());
                if (MessageBox.Show(messege, "Подтверждение удаления",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Sqlconnect CP = new Sqlconnect();
                    CP.id_player = (int)DataGridPlayers.CurrentRow.Cells[0].Value;
                    CP.Delete_Player();
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
