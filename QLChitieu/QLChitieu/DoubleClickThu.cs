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
        public DoubleClickThu()
        { 
            business = new DatabaseManager();
            InitializeComponent();
            btnSavethuDBT.Click += btnSavethuDBT_Click;
            btncancelDBCT.Click += btncancelDBCT_Click;
        }

        void btncancelDBCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSavethuDBT_Click(object sender, EventArgs e)
        {
            
            int ma = int.Parse(txtMaThu.Text);
            string tenthu = txtThuDBT.Text;
            float giathu = float.Parse(txtGiathuDBT.Text);
            DateTime ngaythu = DateTime.Parse(ngaythangthuDBT.Text);
            business.Editthu(ma, tenthu, giathu, ngaythu);
            this.OnLoad(null);
            this.Close();
        }
    }
}
