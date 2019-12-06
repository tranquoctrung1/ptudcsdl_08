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

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void SendMessage();

        QuanLySanPhamBUS bus = new QuanLySanPhamBUS();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (dgvListProduct.Rows.Count <= 0)
            {
                codeProduct.Text = "SP001";
            }

            cbUnitProduct.DataSource = bus.loadAllUnitProduct();
            cbUnitProduct.DisplayMember = "TenLoai";
            cbUnitProduct.SelectedIndex = -1;

            loadData();
        }

        private void loadData()
        {
            dgvListProduct.DataSource = bus.loadAllProduct();
        }

        private void dgvListProduct_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvListProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvListProduct.SelectedRows[0];

                codeProduct.Text = row.Cells[0].Value.ToString();
                nameProduct.Text = row.Cells[1].Value.ToString();
                priceProduct.Text = row.Cells[2].Value.ToString();
                amountProduct.Text = row.Cells[3].Value.ToString();
                cbUnitProduct.Text = row.Cells[4].Value.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            string codeProductRandom;

            if (dgvListProduct.Rows.Count >0 )
            {
                string codeProductFake = dgvListProduct.Rows[dgvListProduct.Rows.Count - 1].Cells[0].Value.ToString();
                codeProductRandom = "SP00" + (int.Parse(codeProductFake.Substring(2)) + 1);
            }
            else
            {
                codeProductRandom = codeProduct.Text;
            }

            sp.MaSP = codeProductRandom;
            sp.TenSP = nameProduct.Text;
            sp.GiaTien = int.Parse(priceProduct.Text);
            sp.SoLuong = int.Parse(amountProduct.Text);
            sp.DonVi = "A" + (cbUnitProduct.SelectedIndex + 1);


            bus.addProduct(sp);
            loadData();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            bus.removeProduct(codeProduct.Text);
            loadData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ThongTinSanPham screen = new ThongTinSanPham(Reload);
            SanPham sp = new SanPham();

            sp.MaSP = codeProduct.Text;
            sp.TenSP = nameProduct.Text;
            sp.GiaTien = int.Parse(priceProduct.Text);
            sp.SoLuong = int.Parse(amountProduct.Text);
            sp.DonVi = cbUnitProduct.Text;

            screen.TTSP = sp;
            screen.ShowDialog();
        }
        
        public void Reload()
        {
            loadData();
        }
    }
}
