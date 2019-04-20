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

namespace Kursa4_krixn_exploid
{
    public partial class Stats_fc : UserControl
    {
        public Stats_fc()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            Sqlconnect c = new Sqlconnect();
            c.query = "exec stats_select";
            DataGridStats.DataSource = c.Select();
        }
    }
}
