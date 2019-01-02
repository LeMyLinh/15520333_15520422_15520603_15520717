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

	public class LichTrinh
	{
        int maTour = 0;
        int maLichTrinh = 0;

        public int MaLichTrinh
        {
            get { return maLichTrinh; }
            set { maLichTrinh = value; }
        }
        public int MaTour
        {
            get { return maTour; }
            set { maTour = value; }
        }

        private string ngay;

        public string Ngay
        {
            get{return ngay;}
            set { ngay = value; }
        }

        private string tenLichTrinh;

        public string TenLichTrinh
        {
            get { return tenLichTrinh; }
            set { tenLichTrinh = value; }
        }


        private List<ChiTietLichTrinh> chiTietLichTrinh = new List<ChiTietLichTrinh>();

        public List<ChiTietLichTrinh> pChiTietLichTrinh
        {
            get { return chiTietLichTrinh; }
            set { chiTietLichTrinh = value; }
        }

        public void ThemChiTietLichTrinh(ChiTietLichTrinh ct)
        {
            pChiTietLichTrinh.Add(ct);
        }

        public void XoaChiTietLichTrinh(ChiTietLichTrinh ct)
        {
            pChiTietLichTrinh.Remove(ct);
        }

        public int Luu()
        {
            dalLichTrinh dal = new dalLichTrinh();
            dtoLichTrinh dto = new dtoLichTrinh();

            dto.MATOUR = MaTour;
            dto.NGAY = int.Parse(Ngay);
            dto.TENLICHTRINH = TenLichTrinh;            
            return dal.ThemLichTrinh(dto);
        }

        public LichTrinh() { }

        public LichTrinh(dtoLichTrinh dto)
        {
            this.ngay = dto.NGAY.ToString();
            this.tenLichTrinh = dto.TENLICHTRINH;            
            dalChiTietLichTrinh dal_ChiTietLichTrinh = new dalChiTietLichTrinh();
            List<dtoChiTietLichTrinh> ldtoCTLT = dal_ChiTietLichTrinh.LayDanhSachCTLT(dto.MALICHTRINH);
            foreach (dtoChiTietLichTrinh dtoCTLT in ldtoCTLT)
            {
                chiTietLichTrinh.Add(new ChiTietLichTrinh(dtoCTLT));
            }
        }
	
        public bool Xoa()
        {
            foreach(ChiTietLichTrinh i in pChiTietLichTrinh)
            {
                i.Xoa();
            }
            dalLichTrinh dal = new dalLichTrinh();
            return dal.XoaLichTrinh(this.MaLichTrinh);
        }
    }
}
