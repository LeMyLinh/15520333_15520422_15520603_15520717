﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using DataTranferObject;
    using System.Data;
    public class dalNhanVien : dalObject
    {
        public bool ThemNhanVien(dtoNhanVien nhanVien)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "INSERT INTO [dbo].[NHANVIEN] ([TRANGTHAI],[MAPHONG],[HOTEN],[CMND],[DIACHI],[NGAYSINH],[QUEQUAN],[SODT],[EMAIL],[GIOITINH],[MATKHAU]) VALUES (1,'"
                + nhanVien.MAPHONG + "',N'" + nhanVien.HOTEN + "','" + nhanVien.CMND + "',N'" + nhanVien.DIACHI + "','" + nhanVien.NGAYSINH.ToShortDateString() + "',N'" + nhanVien.QUEQUAN + "','" + nhanVien.SODT + "','" + nhanVien.EMAIL + "',N'" + nhanVien.GIOITINH + "','" + nhanVien.MATKHAU + "')";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;

        }

        public bool XoaNhanVien(int maNhanVien)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[NHANVIEN] SET TRANGTHAI='false' WHERE [MANHANVIEN]='" + maNhanVien + "'";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;
        }


        public bool SuaThongTinNhanVien(dtoNhanVien nhanVien)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "UPDATE [dbo].[NHANVIEN]" +
              "SET [MAPHONG] = '" + nhanVien.MAPHONG +
              "',[HOTEN] = N'" + nhanVien.HOTEN +
              "',[CMND] = '" + nhanVien.CMND +
              "',[DIACHI] = N'" + nhanVien.DIACHI +
              "',[NGAYSINH] = '" + nhanVien.NGAYSINH +
              "',[QUEQUAN] = N'" + nhanVien.QUEQUAN +
              "',[SODT] = '" + nhanVien.SODT +
              "',[EMAIL] = '" + nhanVien.EMAIL +
              "',[GIOITINH] = N'" + nhanVien.GIOITINH +
              "',[MATKHAU] = '" + nhanVien.MATKHAU +
              "' WHERE [MANHANVIEN]='" + nhanVien.MANHANVIEN + "'";
            if (this.Write(sql))
            {
                this.Close();
                return true;
            }
            this.Close();
            return false;
        }

        public bool DangNhap(string email, string matKhau)
        {
            if (!this.Connect())
            {
                return false;
            }
            string sql = "SELECT * FROM NHANVIEN WHERE EMAIL = '" + email + "'and MATKHAU=N'" + matKhau + "'";
            DataTable dtDangNhap = this.Read(sql);
            this.Close();
            if (dtDangNhap.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public dtoNhanVien LayThongTinNhanVien(int maNhanVien)
        {
            if (!this.Connect())
            {
                return null;
            }
            string sql = "SELECT [MANHANVIEN],[MAPHONG],[HOTEN],[CMND],[DIACHI],[NGAYSINH],[QUEQUAN],[SODT],[EMAIL],[GIOITINH],[MATKHAU] FROM [dbo].[NHANVIEN] WHERE MANHANVIEN = '" + maNhanVien + "'";
            dtoNhanVien nhanVien = new dtoNhanVien();
            DataTable dtNhanVien = this.Read(sql);
            this.Close();
            if (dtNhanVien.Rows.Count == 0)
            {
                return null;
            }
            nhanVien.MANHANVIEN = Int32.Parse(dtNhanVien.Rows[0][0].ToString());
            nhanVien.MAPHONG = Int32.Parse(dtNhanVien.Rows[0][1].ToString());
            nhanVien.HOTEN = dtNhanVien.Rows[0][2].ToString();
            nhanVien.CMND = dtNhanVien.Rows[0][3].ToString();
            nhanVien.DIACHI = dtNhanVien.Rows[0][4].ToString();
            nhanVien.NGAYSINH = dtNhanVien.Rows[0].Field<DateTime>("NGAYSINH");
            nhanVien.QUEQUAN = dtNhanVien.Rows[0][6].ToString();
            nhanVien.SODT = dtNhanVien.Rows[0][7].ToString();
            nhanVien.EMAIL = dtNhanVien.Rows[0][8].ToString();
            nhanVien.GIOITINH = dtNhanVien.Rows[0][9].ToString();
            nhanVien.MATKHAU = dtNhanVien.Rows[0][10].ToString();
            return nhanVien;
        }

        public dtoNhanVien LayThongTinNhanVien(string email)
        {
            if (!this.Connect())
            {
                return null;
            }
            string sql = "SELECT [MANHANVIEN],[MAPHONG],[HOTEN],[CMND],[DIACHI],[NGAYSINH],[QUEQUAN],[SODT],[EMAIL],[GIOITINH],[MATKHAU] FROM [dbo].[NHANVIEN] WHERE EMAIL = '" + email + "'";
            dtoNhanVien nhanVien = new dtoNhanVien();
            DataTable dtNhanVien = this.Read(sql);
            this.Close();
            if (dtNhanVien.Rows.Count == 0)
            {
                return null;
            }
            nhanVien.MANHANVIEN = Int32.Parse(dtNhanVien.Rows[0][0].ToString());
            nhanVien.MAPHONG = Int32.Parse(dtNhanVien.Rows[0][1].ToString());
            nhanVien.HOTEN = dtNhanVien.Rows[0][2].ToString();
            nhanVien.CMND = dtNhanVien.Rows[0][3].ToString();
            nhanVien.DIACHI = dtNhanVien.Rows[0][4].ToString();
            nhanVien.NGAYSINH = dtNhanVien.Rows[0].Field<DateTime>("NGAYSINH");
            nhanVien.QUEQUAN = dtNhanVien.Rows[0][6].ToString();
            nhanVien.SODT = dtNhanVien.Rows[0][7].ToString();
            nhanVien.EMAIL = dtNhanVien.Rows[0][8].ToString();
            nhanVien.GIOITINH = dtNhanVien.Rows[0][9].ToString();
            nhanVien.MATKHAU = dtNhanVien.Rows[0][10].ToString();
            return nhanVien;
        }

        public List<dtoNhanVien> LayDanhSachNhanVien(int maPhongBan)
        {
            if (!this.Connect())
            {
                return null;
            }
            string sql = "SELECT [MANHANVIEN],[MAPHONG],[HOTEN],[CMND],[DIACHI],[NGAYSINH],[QUEQUAN],[SODT],[EMAIL],[GIOITINH] FROM [dbo].[NHANVIEN] WHERE MAPHONG = '" + maPhongBan + "' and TRANGTHAI <> 'false'";
            DataTable dtNhanVien = this.Read(sql);
            this.Close();
            if (dtNhanVien.Rows.Count < 1)
            {
                return null;
            }
            List<dtoNhanVien> lDtoNhanVien = new List<dtoNhanVien>();
            foreach (DataRow dr in dtNhanVien.Rows)
            {
                dtoNhanVien dto_NhanVien = new dtoNhanVien();
                dto_NhanVien.MANHANVIEN = Int32.Parse(dr[0].ToString());
                dto_NhanVien.MAPHONG = Int32.Parse(dr[1].ToString());
                dto_NhanVien.HOTEN = dr[2].ToString();
                dto_NhanVien.CMND = dr[3].ToString();
                dto_NhanVien.DIACHI = dr[4].ToString();
                dto_NhanVien.NGAYSINH = dr.Field<DateTime>("NGAYSINH");
                dto_NhanVien.QUEQUAN = dr[6].ToString();
                dto_NhanVien.SODT = dr[7].ToString();
                dto_NhanVien.EMAIL = dr[8].ToString();
                dto_NhanVien.GIOITINH = dr[9].ToString();
                lDtoNhanVien.Add(dto_NhanVien);
            }
            return lDtoNhanVien;
        }

        public List<dtoNhanVien> LayDanhSachNhanVien()
        {
            if (!this.Connect())
            {
                return null;
            }
            string sql = "SELECT [MANHANVIEN],[MAPHONG],[HOTEN],[CMND],[DIACHI],[NGAYSINH],[QUEQUAN],[SODT],[EMAIL],[GIOITINH],[MATKHAU] FROM [dbo].[NHANVIEN]";
            DataTable dtNhanVien = this.Read(sql);
            this.Close();
            if (dtNhanVien.Rows.Count < 1)
            {
                return null;
            }
            List<dtoNhanVien> lDtoNhanVien = new List<dtoNhanVien>();
            foreach (DataRow dr in dtNhanVien.Rows)
            {
                dtoNhanVien dto_NhanVien = new dtoNhanVien();
                dto_NhanVien.MANHANVIEN = Int32.Parse(dr[0].ToString());
                dto_NhanVien.MAPHONG = Int32.Parse(dr[1].ToString());
                dto_NhanVien.HOTEN = dr[2].ToString();
                dto_NhanVien.CMND = dr[3].ToString();
                dto_NhanVien.DIACHI = dr[4].ToString();
                dto_NhanVien.NGAYSINH = dr.Field<DateTime>("NGAYSINH");
                dto_NhanVien.QUEQUAN = dr[6].ToString();
                dto_NhanVien.SODT = dr[7].ToString();
                dto_NhanVien.EMAIL = dr[8].ToString();
                dto_NhanVien.GIOITINH = dr[9].ToString();
                dto_NhanVien.MATKHAU = dr[10].ToString();
                lDtoNhanVien.Add(dto_NhanVien);
            }
            return lDtoNhanVien;
        }

    }
}

