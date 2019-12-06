using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLySanPhamDAO
    {
        public DataTable loadAllProduct()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT SP.MaSP, SP.TenSP, SP.GiaTien, SP.SoLuong, DV.TenLoai FROM SanPham SP JOIN DonViTinh DV ON SP.DonViTinh = DV.Loai";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSQL);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable loadAllUnitProduct()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT * FROM DonViTinh";
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, strSQL);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public int addProduct(SanPham sp)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO SanPham VALUES(@MaSP, @TenSP, @GiaTien, @SoLuong, @DonVi)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,
                        new SqlParameter { ParameterName = "@MaSP", Value = sp.MaSP },
                        new SqlParameter { ParameterName = "@TenSP", Value = sp.TenSP },
                        new SqlParameter { ParameterName = "@GiaTien", Value = sp.GiaTien },
                        new SqlParameter { ParameterName = "@SoLuong", Value = sp.SoLuong },
                        new SqlParameter { ParameterName = "@DonVi", Value = sp.DonVi }
                    );
                if (nRow > 0)
                    return 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public int removeProduct(string maSP)
        {
            Provider provider = new Provider();
            int nRow = 0;

            try
            {
                string SqlQuery = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, SqlQuery,
                        new SqlParameter { ParameterName = "@MaSp", Value = maSP }
                        );
                if (nRow > 0)
                    return 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public int updateProduct(SanPham sp)
        {
            Provider provider = new Provider();
            int nRow = 0;

            try
            {
                string SqlQuery = "UPDATE SanPham SET TenSP = @TenSP, GiaTien = @GiaTien, SoLuong = @SoLuong, DonViTinh = @DonViTinh WHERE MaSP = @MaSP";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, SqlQuery,
                        new SqlParameter { ParameterName = "@MaSP", Value = sp.MaSP },
                        new SqlParameter { ParameterName = "@TenSP", Value = sp.TenSP },
                        new SqlParameter { ParameterName = "@GiaTien", Value = sp.GiaTien },
                        new SqlParameter { ParameterName = "@SoLuong", Value = sp.SoLuong },
                        new SqlParameter { ParameterName = "@DonViTinh", Value = sp.DonVi }
                    );
                if (nRow > 0)
                    return 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }

            return nRow;
        }
    }
}
