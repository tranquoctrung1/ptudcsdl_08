using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLySanPhamBUS
    {
        public DataTable loadAllProduct()
        {
            QuanLySanPhamDAO dao = new QuanLySanPhamDAO();

            return dao.loadAllProduct();
        }

        public DataTable loadAllUnitProduct()
        {
            QuanLySanPhamDAO dao = new QuanLySanPhamDAO();

            return dao.loadAllUnitProduct();
        }

        public int addProduct(SanPham sp)
        {
            QuanLySanPhamDAO dao = new QuanLySanPhamDAO();

            return dao.addProduct(sp);
        }

        public int removeProduct(string maSP)
        {
            QuanLySanPhamDAO dao = new QuanLySanPhamDAO();

            return dao.removeProduct(maSP);
        }

        public int updateProduct(SanPham sp)
        {
            QuanLySanPhamDAO dao = new QuanLySanPhamDAO();

            return dao.updateProduct(sp);
        }
    }
}
