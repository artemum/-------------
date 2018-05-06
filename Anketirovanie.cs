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
    public partial class Anketirovanie : Form
    {
        public Anketirovanie()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anketa ptr = new anketa();
            ptr.qwestion[0] = "123?";
            ptr.qwestion[1] = "123?";
            my_global.bank_anket.Add(ptr);
            my_global.write_in_db();
        }
    }
}
