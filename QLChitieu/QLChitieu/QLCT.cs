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
    public partial class QLCT : Form
    {
        DatabaseManager business;
        public QLCT(string taiKhoan)
        {
            InitializeComponent();
            this.grdThuvao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grdChi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Load += QLCT_Load;
            txtTaiKhoan.Text = taiKhoan;
            business = new DatabaseManager();
            btnSaveChi.Click += btnSaveChi_Click;
            btnSavethu.Click += btnSavethu_Click;
            btnDeleteChi.Click += btnDeleteChi_Click;
            btnDeleteThu.Click += btnDeleteThu_Click;
            btnSaveMocTien.Click += btnSaveMocTien_Click;
            grdChi.DoubleClick += grdChi_DoubleClick;
            grdThuvao.DoubleClick += grdThuvao_DoubleClick;
        }

        void grdThuvao_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickThu dbclick = new DoubleClickThu();
            //string ten = this.grdThuvao.SelectedRows[0].Cells[2].Value.ToString();
            //double giatien = double.Parse(this.grdThuvao.SelectedRows[0].Cells[3].Value.ToString());
            //DateTime thoigian = DateTime.Parse(this.grdThuvao.SelectedRows[0].Cells[5].Value.ToString());
            dbclick.ShowDialog();
        }

        void grdChi_DoubleClick(object sender, EventArgs e)
        {
            DoublleClickChi dbclick = new DoublleClickChi();
            string ten = this.grdChi.SelectedRows[0].Cells[2].Value.ToString();
            double giatien = double.Parse(this.grdChi.SelectedRows[0].Cells[3].Value.ToString());
            int soluong = int.Parse(this.grdChi.SelectedRows[0].Cells[4].Value.ToString());
            DateTime thoigian = DateTime.Parse(this.grdChi.SelectedRows[0].Cells[5].Value.ToString());
            dbclick.ShowDialog();
        }

        void btnSaveMocTien_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            double Moctien = double.Parse(txtMocTien.Text);
            business.SetMoctien(Moctien , taikhoan);
            this.OnLoad(null);
            MessageBox.Show("Đã thay đổi mốc tiền của TK : "+ taikhoan + " thành " + business.GetMocTien(taikhoan));

        }

        void btnDeleteThu_Click(object sender, EventArgs e)
        {
            business.deleteThu(int.Parse(grdThuvao.SelectedRows[0].Cells[0].Value.ToString()));
            this.OnLoad(null);
        }

        void btnDeleteChi_Click(object sender, EventArgs e)
        {
            business.deleteChi(int.Parse(grdChi.SelectedRows[0].Cells[0].Value.ToString()));
            this.OnLoad(null);
        }

       

        void btnSavethu_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string tenThu = txtThu.Text;
            double gia = double.Parse(txtGiathu.Text);
            DateTime t = DateTime.Parse(ngaythangthu.Text);
            business.SetThuvao(taikhoan, tenThu, gia, t);
            this.OnLoad(null);
        }

        void btnSaveChi_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string tenChi = txtChi.Text;
            float gia = float.Parse(txtGiaChi.Text);
            int soluong = int.Parse(txtSoluong.Text);
            DateTime t = DateTime.Parse(ngaythangChi.Text);
            business.SetChiRa(taikhoan, tenChi, gia, soluong, t);
            this.OnLoad(null);
            if (business.GetTongTienThu() - business.GetTongTienChi() < business.GetMocTien(taikhoan))
            {
                MessageBox.Show("Hiện tiền hiện có của bạn đang dưới VND" + business.GetMocTien(taikhoan));
            }

        }

        private void QLCT_Load(object sender, EventArgs e)
        {
            grdChi.DataSource = business.GetChiRa();
            grdChi.Columns["TaiKhoan"].Visible = false;
            grdThuvao.DataSource = business.GetThuVao();
            grdThuvao.Columns["TaiKhoan"].Visible = false;
            txtTongChi.Text = business.GetTongTienChi().ToString();
            txtTongThu.Text = business.GetTongTienThu().ToString();
            
        }

     









    }
}
