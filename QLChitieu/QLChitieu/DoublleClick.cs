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
    public partial class DoublleClick : Form
    {
        DatabaseManager business;
        public DoublleClick()
        {
            InitializeComponent();
            btnSaveChiDB.Click += btnSaveChiDB_Click;
        }

        void btnSaveChiDB_Click(object sender, EventArgs e)
        {
            string tenchi = txtChiDB.Text;
            double giachi = double.Parse(txtGiaChiDB.Text);
            int soluong = int.Parse(txtSoluongDB.Text);
            DateTime datetime = DateTime.Parse(ngaythangChiDB.Text);
            business.EditChi(tenchi, giachi, soluong, datetime);
            this.OnLoad(null);
        }
       
           

       
    }
}
