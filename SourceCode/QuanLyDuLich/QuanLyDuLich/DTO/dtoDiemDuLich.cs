﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace DataTranferObject
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class dtoDiemDuLich
	{
		public int MADIEMDULICH
		{
			get;
			set;
		}

		public int MANHANVIEN
		{
			get;
			set;
		}
        public int MATINH
        {
            get;
            set;
        }
		public string TENDIEMDULICH
		{
			get;
			set;
		}

		public string MOTA
		{
			get;
			set;
		}

        public dtoDiemDuLich() { }
        public dtoDiemDuLich(int _maDiemDuLich, int _maNhanVien, string _tenDiemDuLich, string _moTa,int _maTinh) 
        {
            MADIEMDULICH = _maDiemDuLich;
            MANHANVIEN = _maNhanVien;
            TENDIEMDULICH = _tenDiemDuLich;
            MOTA = _moTa;
            MATINH = _maTinh;
        }
	}
}

