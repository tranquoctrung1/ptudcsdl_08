using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.Form1;

namespace GUI
{
    public partial class ThongTinSanPham : Form
    {
        SendMessage send;
        public ThongTinSanPham(SendMessage send)
        {
            InitializeComponent();
            this.send = send;
        }

        private SanPham _tTSP;

        public SanPham TTSP { get => _tTSP; set => _tTSP = value; }

        QuanLySanPhamBUS bus = new QuanLySanPhamBUS();
        private void ThongTinSanPham_Load(object sender, EventArgs e)
        {
            cbUnitProduct.DataSource = bus.loadAllUnitProduct();
            cbUnitProduct.DisplayMember = "TenLoai";

            codeProduct.Text = TTSP.MaSP;
            nameProduct.Text = TTSP.TenSP;
            priceProduct.Text = TTSP.GiaTien.ToString();
            amountProduct.Text = TTSP.SoLuong.ToString();
            cbUnitProduct.Text = TTSP.DonVi;

        }

        private void updateButton2_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();

            sp.MaSP = codeProduct.Text;
            sp.TenSP = nameProduct.Text;
            sp.GiaTien = int.Parse(priceProduct.Text);
            sp.SoLuong = int.Parse(amountProduct.Text);
            sp.DonVi = "A" + (cbUnitProduct.SelectedIndex + 1);

            bus.updateProduct(sp);

            this.send();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.send();
        }
    }
}
