﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace BLL
{
    using DataAccessLayer;
    using DataTranferObject;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

	public class KhachHang
	{
        private int MaKhachHang;
        private string LoaiKhachHang;
        private bool TrangThai;
        private int MaNhanVien;
        private string GioiTinh;
        private string DiaChi;
        private string TenDonVi;
        private string Email;
        private string SoDT;
        private string NguoiDaiDien;
        private int SoNguoi;
        public int pMaKhachHang
        {
            get { return MaKhachHang; }
            set { MaKhachHang = value; }
        }                
        public string pLoaiKhachHang
        {
            get { return LoaiKhachHang; }
            set { LoaiKhachHang = value; }
        }        
        public int pSoNguoi
        {
            get { return SoNguoi; }
            set { SoNguoi = value; }
        }        
        public string pNguoiDaiDien
        {
            get { return NguoiDaiDien; }
            set { NguoiDaiDien = value; }
        }        
        public string pSoDT
        {
            get { return SoDT; }
            set { SoDT = value; }
        }        
        public string pEmail
        {
            get { return Email; }
            set { Email = value; }
        }        
        public string pTenDonVi
        {
            get { return TenDonVi; }
            set { TenDonVi = value; }
        }
        
        public string pDiaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        
        public string pGioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        
        public int pMaNhanVien
        {
            get { return MaNhanVien; }
            set { MaNhanVien = value; }
        }
        
        public bool pTrangThai
        {
            get { return TrangThai; }
            set { TrangThai = value; }
        }
        public KhachHang(int _maKhachHang,int _maNhanVien, string _tenDonVi, string _nguoiDaiDien, string _gioiTinh, 
            string _email, string _soDT, int _soNguoi, string _diaChi, string _loaiKhachHang)
        {
            MaKhachHang = _maKhachHang;
            MaNhanVien = _maNhanVien;
            LoaiKhachHang = _loaiKhachHang;
            SoNguoi = _soNguoi;
            NguoiDaiDien = _nguoiDaiDien;
            SoDT = _soDT;
            Email = _email;
            GioiTinh = _gioiTinh;
            TenDonVi = _tenDonVi;
            DiaChi = _diaChi;
        }
        public KhachHang()
        {             
        }

        public KhachHang(dtoKhachHang dto)
        {
            //this.TrangThai=dto.TR
            this.MaKhachHang = dto.MAKHACHHANG;
            this.MaNhanVien = dto.MANHANVIEN;
            this.DiaChi = dto.DIACHI;
            this.Email = dto.EMAIL;
            this.LoaiKhachHang = dto.LOAIKHACHHANG;
            this.NguoiDaiDien = dto.NGUOIDAIDIEN;
            this.SoDT = dto.DIENTHOAI;
            this.SoNguoi = dto.SONGUOI;
            this.TenDonVi = dto.TENDONVI;
        }

        public void setKhachHang(dtoKhachHang _khachHang)
        {
            MaKhachHang = _khachHang.MAKHACHHANG;
            TenDonVi = _khachHang.TENDONVI;
            NguoiDaiDien = _khachHang.NGUOIDAIDIEN;
            GioiTinh = _khachHang.GIOITINH;
            Email = _khachHang.EMAIL;
            SoDT = _khachHang.DIENTHOAI;
            SoNguoi = _khachHang.SONGUOI;
            DiaChi = _khachHang.DIACHI;
            LoaiKhachHang = _khachHang.LOAIKHACHHANG;
        }
       
        //public List<dtoKhachHang> layDanhSachKhachHang()
        //{
        //    dalKhachHang _dalKhachHang = new dalKhachHang();
        //    return _dalKhachHang.LayDanhSachKhachHang2();
        //}
        public List<dtoKhachHang>layDanhSachKhachHang(int manv)
        {
            dalKhachHang _dalKhachHang = new dalKhachHang();
            return _dalKhachHang.LayDanhSachKhachHang(manv);
        }
        dtoKhachHang getdtoKhachHang() 
        {
            dtoKhachHang _khachHang = new dtoKhachHang(MaNhanVien,MaKhachHang, TenDonVi, NguoiDaiDien, GioiTinh, Email, SoDT, SoNguoi, DiaChi, LoaiKhachHang,1);
            return _khachHang;
        }
        public dtoKhachHang layKhachHang(int maKH) 
        {
            dalKhachHang dal = new dalKhachHang();
            return dal.LayKhachHang(maKH);
        }
		public bool CapNhat(dtoKhachHang dtoKhachHang)
		{
            dalKhachHang _dalKhachHang = new dalKhachHang();
            return _dalKhachHang.SuaThongTinKhachHang(dtoKhachHang);
		}

		public bool Luu()
		{
            dalKhachHang _dalKhachHang = new dalKhachHang();
            return _dalKhachHang.ThemKhachHang(getdtoKhachHang());
            
		}
        public int GetMaxMaKhachHang() 
        {
            dalKhachHang _dalKH = new dalKhachHang();
            return _dalKH.GetMaxMaKhachHang();
        }
		public bool Xoa(int makh)
		{
            dalKhachHang _dalKhachHang = new dalKhachHang();
            return _dalKhachHang.XoaKhachHang(makh);
		}

	}
}

