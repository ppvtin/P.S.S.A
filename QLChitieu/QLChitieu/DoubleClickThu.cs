using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChitieu
{
    public partial class DoubleClickThu : Form
    {
        DatabaseManager business;
        public DoubleClickThu(string tenthu , double giatri , DateTime ngaythangnam)
        {

            InitializeComponent();
            btnSavethuDBT.Click += btnSavethuDBT_Click;
        }

        void btnSavethuDBT_Click(object sender, EventArgs e)
        {
            string tenthu = txtThuDBT.Text;
            double giathu = double.Parse(txtGiathuDBT.Text);
            DateTime datetime = DateTime.Parse(ngaythangthuDBT.Text);
            business.Editthu(tenthu, giathu, datetime);
            this.OnLoad(null);
        }
    }
}
