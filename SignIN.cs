using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анкетирование
{
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            string login = txt_login.Text.ToString();
            string pass = txt_pass.Text.ToString();

            int res = port_server.sign_in(login, pass);

            if (res == port_server.ERROR) return;

            my_global.id_store = res;
            Form ptr = new Anketirovanie();
            ptr.Show();
        }
    }
}
