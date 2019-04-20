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
    public partial class coachs_fc : UserControl
    {
        public coachs_fc()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            Sqlconnect c = new Sqlconnect();
            c.query = "Exec Coachs_Select";
            DataGridCoachs.DataSource = c.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(coach_crud previewCC = new coach_crud())
            {
                previewCC.txtid_coach.Visible = false;
                previewCC.lblId_team.Visible = false;
                previewCC.objstate = (int)Enums.Checked.Insert;
                previewCC.lblFormName.Text = "Тренер: Добавление";
                previewCC.ShowDialog();
            }
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (coach_crud previewCC = new coach_crud())
                {
                    previewCC.objstate = (int)Enums.Checked.Update;
                    previewCC.lblFormName.Text = "Тренер: Редактирование";
                    previewCC.txtid_coach.Text = DataGridCoachs.CurrentRow.Cells[0].Value.ToString();
                    previewCC.txtFirstname.Text = DataGridCoachs.CurrentRow.Cells[1].Value.ToString();
                    previewCC.txtLastname.Text = DataGridCoachs.CurrentRow.Cells[2].Value.ToString();
                    previewCC.txtCountry.Text = DataGridCoachs.CurrentRow.Cells[3].Value.ToString();
                    previewCC.txtexp.Text = DataGridCoachs.CurrentRow.Cells[4].Value.ToString();
                    previewCC.txtBirthday.Text = DataGridCoachs.CurrentRow.Cells[5].FormattedValue.ToString();
                    previewCC.ShowDialog();
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
                string messege = string.Format("Удалить тренера {0} {1}", DataGridCoachs.CurrentRow.Cells[1].Value.ToString(), DataGridCoachs.CurrentRow.Cells[2].Value.ToString());
                if (MessageBox.Show(messege, "Подтверждение удаления",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Sqlconnect CС = new Sqlconnect();
                    CС.id_coach = (int)DataGridCoachs.CurrentRow.Cells[0].Value;
                    CС.Delete_Coach();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                using(preview_coach previewCC = new preview_coach())
                {
                    previewCC.lblFirstName.Text = "ИМЯ: " + DataGridCoachs.CurrentRow.Cells[1].Value.ToString();
                    previewCC.lblLastName.Text = "ФАМИЛИЯ: " + DataGridCoachs.CurrentRow.Cells[2].Value.ToString();
                    switch ((int)DataGridCoachs.CurrentRow.Cells[4].Value)
                    {
                        case 1: previewCC.lblexp.Text = "ОПЫТ: " + DataGridCoachs.CurrentRow.Cells[4].Value.ToString() + " год"; break;
                        case 2 - 4: previewCC.lblexp.Text = "ОПЫТ: " + DataGridCoachs.CurrentRow.Cells[4].Value.ToString() + " года"; break;
                        default: previewCC.lblexp.Text = "ОПЫТ: " + DataGridCoachs.CurrentRow.Cells[4].Value.ToString() + " лет"; break;
                    }
                    previewCC.lblCountry.Text = "СТРАНА: " + DataGridCoachs.CurrentRow.Cells[3].Value.ToString();
                    previewCC.lblbirthday.Text = "ДАТА РОЖДЕНИЯ: " + DataGridCoachs.CurrentRow.Cells[5].FormattedValue.ToString();
                    previewCC.ShowDialog();
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

        private void DataGridCoachs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (preview_coach previewCC = new preview_coach())
                {
                    previewCC.lblFirstName.Text = "ИМЯ: " + DataGridCoachs.CurrentRow.Cells[1].Value.ToString();
                    previewCC.lblLastName.Text = "ФАМИЛИЯ: " + DataGridCoachs.CurrentRow.Cells[2].Value.ToString();
                    switch ((int)DataGridCoachs.CurrentRow.Cells[4].Value)
                    {
                        case 1: previewCC.lblexp.Text = "ОПЫТ: " + DataGridCoachs.CurrentRow.Cells[4].Value.ToString() + " год"; break;
                        case 2 - 4: previewCC.lblexp.Text = "ОПЫТ: " + DataGridCoachs.CurrentRow.Cells[4].Value.ToString() + " года"; break;
                        default: previewCC.lblexp.Text = "ОПЫТ: " + DataGridCoachs.CurrentRow.Cells[4].Value.ToString() + " лет"; break;
                    }
                    previewCC.lblCountry.Text = "СТРАНА: " + DataGridCoachs.CurrentRow.Cells[3].Value.ToString();
                    previewCC.lblbirthday.Text = "ДАТА РОЖДЕНИЯ: " + DataGridCoachs.CurrentRow.Cells[5].FormattedValue.ToString();
                    previewCC.ShowDialog();
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
            (DataGridCoachs.DataSource as DataTable).DefaultView.RowFilter = string.Format("Имя LIKE '%{0}%' OR Фамилия Like '%{1}%'", txtSearchBox.text, txtSearchBox.text);
        }
    }
}
