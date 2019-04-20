using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursa4_krixn_exploid.Forms;
using Kursa4_krixn_exploid.Class;

namespace Kursa4_krixn_exploid
{
    public partial class Loading : Form
    {
        Timer loading = new Timer();
        int plus = 3;

        public Loading()
        {
            InitializeComponent();
        }

        private void move(object sender, EventArgs e)
        {
            pnlMove.Left += plus;

            if(pnlMove.Left > 250) { plus = -3; }
            if(pnlMove.Left < 0) { plus = 3; }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            loading.Tick += new EventHandler(move);
            loading.Interval = 10;
            loading.Start();
            showLoading();
        }

        private async void showLoading()
        {
            LoginSql loginsql = new LoginSql();
            lblTextInfo.Text = "Загрузка, пожалуйста подождите...";
            begin:
            await Task.Delay(2000);
            lblTextInfo.Text = "Идёт соединение с базой данных...";
            loginsql.ShowDialog();
            if (loginsql.connected == true)
            {
                lblTextInfo.Text = "Соединение с базой данных выполнено...";
            }
            else
            {
                lblTextInfo.Text = "Ошибка с подключением базой данных...";
                await Task.Delay(2000);
                lblTextInfo.Text = "Повторите попытку";
                goto begin;
            }
            await Task.Delay(2000);
            lblTextInfo.Text = "Загрузка, пожалуйста подождите...";
            await Task.Delay(2000);
            Main mainform = new Main();
            mainform.ShowDialog();
            this.Close();
        }
    }
}
