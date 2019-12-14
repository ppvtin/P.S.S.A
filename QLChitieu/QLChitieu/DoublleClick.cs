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
    public partial class DoublleClickChi : Form
    {
        DatabaseManager business;
        public DoublleClickChi()
        {
            business = new DatabaseManager();
            InitializeComponent();
            btnSaveChiDB.Click += btnSaveChiDB_Click;
            btnCancelChi.Click += btnCancelChi_Click;
        }

        void btnCancelChi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSaveChiDB_Click(object sender, EventArgs e)
        {

            int ma = int.Parse(txtMaChi.Text);
            string tenthu = txtChiDB.Text;
            float giathu = float.Parse(txtGiaChiDB.Text);
            DateTime ngaythu = DateTime.Parse(ngaythangChiDB.Text);
            int soluong = int.Parse(txtSoluongDB.Text);
            business.EditChi(ma, tenthu, giathu,soluong, ngaythu );
            this.OnLoad(null);
        }
       
           

       
    }
}
