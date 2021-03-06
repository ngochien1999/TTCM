﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLBCMBEntities3 : DbContext
    {
        public QLBCMBEntities3()
            : base("name=QLBCMBEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chuyenbay> Chuyenbays { get; set; }
        public virtual DbSet<CTchuyenbay> CTchuyenbays { get; set; }
        public virtual DbSet<CTVe> CTVes { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<KM> KMs { get; set; }
        public virtual DbSet<Maybay> Maybays { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Sanbay> Sanbays { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TK> TKs { get; set; }
        public virtual DbSet<Tuyenbay> Tuyenbays { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }
    
        public virtual int chuyenbay_ha(string maMB, string maCB, Nullable<System.DateTime> ngaybay, Nullable<System.TimeSpan> thoigianbay, string sabden, string sabdi, Nullable<int> sLveLoaiI, Nullable<int> sLveloaiII, string maTB, Nullable<System.TimeSpan> thoigiandung, string sBtrunggian)
        {
            var maMBParameter = maMB != null ?
                new ObjectParameter("MaMB", maMB) :
                new ObjectParameter("MaMB", typeof(string));
    
            var maCBParameter = maCB != null ?
                new ObjectParameter("MaCB", maCB) :
                new ObjectParameter("MaCB", typeof(string));
    
            var ngaybayParameter = ngaybay.HasValue ?
                new ObjectParameter("Ngaybay", ngaybay) :
                new ObjectParameter("Ngaybay", typeof(System.DateTime));
    
            var thoigianbayParameter = thoigianbay.HasValue ?
                new ObjectParameter("Thoigianbay", thoigianbay) :
                new ObjectParameter("Thoigianbay", typeof(System.TimeSpan));
    
            var sabdenParameter = sabden != null ?
                new ObjectParameter("Sabden", sabden) :
                new ObjectParameter("Sabden", typeof(string));
    
            var sabdiParameter = sabdi != null ?
                new ObjectParameter("Sabdi", sabdi) :
                new ObjectParameter("Sabdi", typeof(string));
    
            var sLveLoaiIParameter = sLveLoaiI.HasValue ?
                new ObjectParameter("SLveLoaiI", sLveLoaiI) :
                new ObjectParameter("SLveLoaiI", typeof(int));
    
            var sLveloaiIIParameter = sLveloaiII.HasValue ?
                new ObjectParameter("SLveloaiII", sLveloaiII) :
                new ObjectParameter("SLveloaiII", typeof(int));
    
            var maTBParameter = maTB != null ?
                new ObjectParameter("MaTB", maTB) :
                new ObjectParameter("MaTB", typeof(string));
    
            var thoigiandungParameter = thoigiandung.HasValue ?
                new ObjectParameter("Thoigiandung", thoigiandung) :
                new ObjectParameter("Thoigiandung", typeof(System.TimeSpan));
    
            var sBtrunggianParameter = sBtrunggian != null ?
                new ObjectParameter("SBtrunggian", sBtrunggian) :
                new ObjectParameter("SBtrunggian", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("chuyenbay_ha", maMBParameter, maCBParameter, ngaybayParameter, thoigianbayParameter, sabdenParameter, sabdiParameter, sLveLoaiIParameter, sLveloaiIIParameter, maTBParameter, thoigiandungParameter, sBtrunggianParameter);
        }
    
        public virtual int chuyenbay123(string maMB, string maCB, Nullable<System.DateTime> ngaybay, Nullable<System.TimeSpan> thoigianbay, string sabden, string sabdi, Nullable<int> sLveLoaiI, Nullable<int> sLveloaiII, string maTB, Nullable<System.TimeSpan> thoigiandung, string sBtrunggian)
        {
            var maMBParameter = maMB != null ?
                new ObjectParameter("MaMB", maMB) :
                new ObjectParameter("MaMB", typeof(string));
    
            var maCBParameter = maCB != null ?
                new ObjectParameter("MaCB", maCB) :
                new ObjectParameter("MaCB", typeof(string));
    
            var ngaybayParameter = ngaybay.HasValue ?
                new ObjectParameter("Ngaybay", ngaybay) :
                new ObjectParameter("Ngaybay", typeof(System.DateTime));
    
            var thoigianbayParameter = thoigianbay.HasValue ?
                new ObjectParameter("Thoigianbay", thoigianbay) :
                new ObjectParameter("Thoigianbay", typeof(System.TimeSpan));
    
            var sabdenParameter = sabden != null ?
                new ObjectParameter("Sabden", sabden) :
                new ObjectParameter("Sabden", typeof(string));
    
            var sabdiParameter = sabdi != null ?
                new ObjectParameter("Sabdi", sabdi) :
                new ObjectParameter("Sabdi", typeof(string));
    
            var sLveLoaiIParameter = sLveLoaiI.HasValue ?
                new ObjectParameter("SLveLoaiI", sLveLoaiI) :
                new ObjectParameter("SLveLoaiI", typeof(int));
    
            var sLveloaiIIParameter = sLveloaiII.HasValue ?
                new ObjectParameter("SLveloaiII", sLveloaiII) :
                new ObjectParameter("SLveloaiII", typeof(int));
    
            var maTBParameter = maTB != null ?
                new ObjectParameter("MaTB", maTB) :
                new ObjectParameter("MaTB", typeof(string));
    
            var thoigiandungParameter = thoigiandung.HasValue ?
                new ObjectParameter("Thoigiandung", thoigiandung) :
                new ObjectParameter("Thoigiandung", typeof(System.TimeSpan));
    
            var sBtrunggianParameter = sBtrunggian != null ?
                new ObjectParameter("SBtrunggian", sBtrunggian) :
                new ObjectParameter("SBtrunggian", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("chuyenbay123", maMBParameter, maCBParameter, ngaybayParameter, thoigianbayParameter, sabdenParameter, sabdiParameter, sLveLoaiIParameter, sLveloaiIIParameter, maTBParameter, thoigiandungParameter, sBtrunggianParameter);
        }
    
        public virtual int deletecb(string macb)
        {
            var macbParameter = macb != null ?
                new ObjectParameter("macb", macb) :
                new ObjectParameter("macb", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletecb", macbParameter);
        }
    
        public virtual int deletekh(string maKH)
        {
            var maKHParameter = maKH != null ?
                new ObjectParameter("maKH", maKH) :
                new ObjectParameter("maKH", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletekh", maKHParameter);
        }
    
        public virtual int deletemb(string maMB)
        {
            var maMBParameter = maMB != null ?
                new ObjectParameter("maMB", maMB) :
                new ObjectParameter("maMB", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletemb", maMBParameter);
        }
    
        public virtual int deletenv(string manv)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletenv", manvParameter);
        }
    
        public virtual int deletesb(string masb)
        {
            var masbParameter = masb != null ?
                new ObjectParameter("masb", masb) :
                new ObjectParameter("masb", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletesb", masbParameter);
        }
    
        public virtual ObjectResult<doanhthu_Result> doanhthu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanhthu_Result>("doanhthu");
        }
    
        public virtual ObjectResult<dthu_Result> dthu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dthu_Result>("dthu");
        }
    
        public virtual ObjectResult<h_Result> h(Nullable<System.DateTime> ngaybay, string sanbaydi, string sanbayden, string hang)
        {
            var ngaybayParameter = ngaybay.HasValue ?
                new ObjectParameter("ngaybay", ngaybay) :
                new ObjectParameter("ngaybay", typeof(System.DateTime));
    
            var sanbaydiParameter = sanbaydi != null ?
                new ObjectParameter("sanbaydi", sanbaydi) :
                new ObjectParameter("sanbaydi", typeof(string));
    
            var sanbaydenParameter = sanbayden != null ?
                new ObjectParameter("sanbayden", sanbayden) :
                new ObjectParameter("sanbayden", typeof(string));
    
            var hangParameter = hang != null ?
                new ObjectParameter("hang", hang) :
                new ObjectParameter("hang", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<h_Result>("h", ngaybayParameter, sanbaydiParameter, sanbaydenParameter, hangParameter);
        }
    
        public virtual ObjectResult<hien_Result> hien(string sanden, string sandi, string hang, Nullable<System.DateTime> ngaybay)
        {
            var sandenParameter = sanden != null ?
                new ObjectParameter("sanden", sanden) :
                new ObjectParameter("sanden", typeof(string));
    
            var sandiParameter = sandi != null ?
                new ObjectParameter("sandi", sandi) :
                new ObjectParameter("sandi", typeof(string));
    
            var hangParameter = hang != null ?
                new ObjectParameter("Hang", hang) :
                new ObjectParameter("Hang", typeof(string));
    
            var ngaybayParameter = ngaybay.HasValue ?
                new ObjectParameter("Ngaybay", ngaybay) :
                new ObjectParameter("Ngaybay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hien_Result>("hien", sandenParameter, sandiParameter, hangParameter, ngaybayParameter);
        }
    
        public virtual ObjectResult<layhoadon_Result> layhoadon(string mahd, string machuyenbay, string makh, string manv, Nullable<System.DateTime> ngay, Nullable<int> tongtien)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            var machuyenbayParameter = machuyenbay != null ?
                new ObjectParameter("machuyenbay", machuyenbay) :
                new ObjectParameter("machuyenbay", typeof(string));
    
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("tongtien", tongtien) :
                new ObjectParameter("tongtien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<layhoadon_Result>("layhoadon", mahdParameter, machuyenbayParameter, makhParameter, manvParameter, ngayParameter, tongtienParameter);
        }
    
        public virtual int mahoadon(string maNV, Nullable<System.DateTime> nlap, Nullable<int> tongtien, string mave, Nullable<int> thueVAT, string tinhtrang, string maCB, string makh)
        {
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var nlapParameter = nlap.HasValue ?
                new ObjectParameter("Nlap", nlap) :
                new ObjectParameter("Nlap", typeof(System.DateTime));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("Tongtien", tongtien) :
                new ObjectParameter("Tongtien", typeof(int));
    
            var maveParameter = mave != null ?
                new ObjectParameter("Mave", mave) :
                new ObjectParameter("Mave", typeof(string));
    
            var thueVATParameter = thueVAT.HasValue ?
                new ObjectParameter("ThueVAT", thueVAT) :
                new ObjectParameter("ThueVAT", typeof(int));
    
            var tinhtrangParameter = tinhtrang != null ?
                new ObjectParameter("Tinhtrang", tinhtrang) :
                new ObjectParameter("Tinhtrang", typeof(string));
    
            var maCBParameter = maCB != null ?
                new ObjectParameter("MaCB", maCB) :
                new ObjectParameter("MaCB", typeof(string));
    
            var makhParameter = makh != null ?
                new ObjectParameter("Makh", makh) :
                new ObjectParameter("Makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("mahoadon", maNVParameter, nlapParameter, tongtienParameter, maveParameter, thueVATParameter, tinhtrangParameter, maCBParameter, makhParameter);
        }
    
        public virtual ObjectResult<NewSelectCommand_Result> NewSelectCommand()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NewSelectCommand_Result>("NewSelectCommand");
        }
    
        public virtual int rptChuyenBay()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("rptChuyenBay");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<them_Result> them()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<them_Result>("them");
        }
    
        public virtual int ThemDuLieu(string maCB, Nullable<System.DateTime> ngayBay, Nullable<System.TimeSpan> thoiGianBay, string maTB, Nullable<System.TimeSpan> thoigiandung, string sBtrunggian, string sBdi, string sBden, string maMB)
        {
            var maCBParameter = maCB != null ?
                new ObjectParameter("MaCB", maCB) :
                new ObjectParameter("MaCB", typeof(string));
    
            var ngayBayParameter = ngayBay.HasValue ?
                new ObjectParameter("NgayBay", ngayBay) :
                new ObjectParameter("NgayBay", typeof(System.DateTime));
    
            var thoiGianBayParameter = thoiGianBay.HasValue ?
                new ObjectParameter("ThoiGianBay", thoiGianBay) :
                new ObjectParameter("ThoiGianBay", typeof(System.TimeSpan));
    
            var maTBParameter = maTB != null ?
                new ObjectParameter("MaTB", maTB) :
                new ObjectParameter("MaTB", typeof(string));
    
            var thoigiandungParameter = thoigiandung.HasValue ?
                new ObjectParameter("Thoigiandung", thoigiandung) :
                new ObjectParameter("Thoigiandung", typeof(System.TimeSpan));
    
            var sBtrunggianParameter = sBtrunggian != null ?
                new ObjectParameter("SBtrunggian", sBtrunggian) :
                new ObjectParameter("SBtrunggian", typeof(string));
    
            var sBdiParameter = sBdi != null ?
                new ObjectParameter("SBdi", sBdi) :
                new ObjectParameter("SBdi", typeof(string));
    
            var sBdenParameter = sBden != null ?
                new ObjectParameter("SBden", sBden) :
                new ObjectParameter("SBden", typeof(string));
    
            var maMBParameter = maMB != null ?
                new ObjectParameter("MaMB", maMB) :
                new ObjectParameter("MaMB", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemDuLieu", maCBParameter, ngayBayParameter, thoiGianBayParameter, maTBParameter, thoigiandungParameter, sBtrunggianParameter, sBdiParameter, sBdenParameter, maMBParameter);
        }
    
        public virtual int themdulieu1(string maCB, Nullable<System.DateTime> ngayBay, Nullable<System.TimeSpan> thoiGianBay, string sabden, string sabdi, Nullable<int> sLveloaiI, Nullable<int> sLveloaiII, string maTB, Nullable<System.TimeSpan> thoigiandung, string sBtrunggian, string sBdi, string sBden, string maMB)
        {
            var maCBParameter = maCB != null ?
                new ObjectParameter("MaCB", maCB) :
                new ObjectParameter("MaCB", typeof(string));
    
            var ngayBayParameter = ngayBay.HasValue ?
                new ObjectParameter("NgayBay", ngayBay) :
                new ObjectParameter("NgayBay", typeof(System.DateTime));
    
            var thoiGianBayParameter = thoiGianBay.HasValue ?
                new ObjectParameter("ThoiGianBay", thoiGianBay) :
                new ObjectParameter("ThoiGianBay", typeof(System.TimeSpan));
    
            var sabdenParameter = sabden != null ?
                new ObjectParameter("Sabden", sabden) :
                new ObjectParameter("Sabden", typeof(string));
    
            var sabdiParameter = sabdi != null ?
                new ObjectParameter("Sabdi", sabdi) :
                new ObjectParameter("Sabdi", typeof(string));
    
            var sLveloaiIParameter = sLveloaiI.HasValue ?
                new ObjectParameter("SLveloaiI", sLveloaiI) :
                new ObjectParameter("SLveloaiI", typeof(int));
    
            var sLveloaiIIParameter = sLveloaiII.HasValue ?
                new ObjectParameter("SLveloaiII", sLveloaiII) :
                new ObjectParameter("SLveloaiII", typeof(int));
    
            var maTBParameter = maTB != null ?
                new ObjectParameter("MaTB", maTB) :
                new ObjectParameter("MaTB", typeof(string));
    
            var thoigiandungParameter = thoigiandung.HasValue ?
                new ObjectParameter("Thoigiandung", thoigiandung) :
                new ObjectParameter("Thoigiandung", typeof(System.TimeSpan));
    
            var sBtrunggianParameter = sBtrunggian != null ?
                new ObjectParameter("SBtrunggian", sBtrunggian) :
                new ObjectParameter("SBtrunggian", typeof(string));
    
            var sBdiParameter = sBdi != null ?
                new ObjectParameter("SBdi", sBdi) :
                new ObjectParameter("SBdi", typeof(string));
    
            var sBdenParameter = sBden != null ?
                new ObjectParameter("SBden", sBden) :
                new ObjectParameter("SBden", typeof(string));
    
            var maMBParameter = maMB != null ?
                new ObjectParameter("MaMB", maMB) :
                new ObjectParameter("MaMB", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themdulieu1", maCBParameter, ngayBayParameter, thoiGianBayParameter, sabdenParameter, sabdiParameter, sLveloaiIParameter, sLveloaiIIParameter, maTBParameter, thoigiandungParameter, sBtrunggianParameter, sBdiParameter, sBdenParameter, maMBParameter);
        }
    
        public virtual int themhd(string maNV, Nullable<System.DateTime> nlap, Nullable<int> tongtien, string mave, Nullable<int> thueVAT, string tinhtrang, string maCB, string makh)
        {
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var nlapParameter = nlap.HasValue ?
                new ObjectParameter("Nlap", nlap) :
                new ObjectParameter("Nlap", typeof(System.DateTime));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("Tongtien", tongtien) :
                new ObjectParameter("Tongtien", typeof(int));
    
            var maveParameter = mave != null ?
                new ObjectParameter("Mave", mave) :
                new ObjectParameter("Mave", typeof(string));
    
            var thueVATParameter = thueVAT.HasValue ?
                new ObjectParameter("ThueVAT", thueVAT) :
                new ObjectParameter("ThueVAT", typeof(int));
    
            var tinhtrangParameter = tinhtrang != null ?
                new ObjectParameter("Tinhtrang", tinhtrang) :
                new ObjectParameter("Tinhtrang", typeof(string));
    
            var maCBParameter = maCB != null ?
                new ObjectParameter("MaCB", maCB) :
                new ObjectParameter("MaCB", typeof(string));
    
            var makhParameter = makh != null ?
                new ObjectParameter("Makh", makh) :
                new ObjectParameter("Makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themhd", maNVParameter, nlapParameter, tongtienParameter, maveParameter, thueVATParameter, tinhtrangParameter, maCBParameter, makhParameter);
        }
    
        public virtual int themHoaDon(string manv, Nullable<int> tongtien, string makh, Nullable<System.DateTime> ngaylap, string mave)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("tongtien", tongtien) :
                new ObjectParameter("tongtien", typeof(int));
    
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var ngaylapParameter = ngaylap.HasValue ?
                new ObjectParameter("ngaylap", ngaylap) :
                new ObjectParameter("ngaylap", typeof(System.DateTime));
    
            var maveParameter = mave != null ?
                new ObjectParameter("mave", mave) :
                new ObjectParameter("mave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("themHoaDon", manvParameter, tongtienParameter, makhParameter, ngaylapParameter, maveParameter);
        }
    
        public virtual ObjectResult<TimKiemNangCao_Result> TimKiemNangCao(string sbdi, string sbden, string hang, Nullable<System.DateTime> ngaybay)
        {
            var sbdiParameter = sbdi != null ?
                new ObjectParameter("sbdi", sbdi) :
                new ObjectParameter("sbdi", typeof(string));
    
            var sbdenParameter = sbden != null ?
                new ObjectParameter("sbden", sbden) :
                new ObjectParameter("sbden", typeof(string));
    
            var hangParameter = hang != null ?
                new ObjectParameter("Hang", hang) :
                new ObjectParameter("Hang", typeof(string));
    
            var ngaybayParameter = ngaybay.HasValue ?
                new ObjectParameter("Ngaybay", ngaybay) :
                new ObjectParameter("Ngaybay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemNangCao_Result>("TimKiemNangCao", sbdiParameter, sbdenParameter, hangParameter, ngaybayParameter);
        }
    
        public virtual ObjectResult<string> tkcb(string mahd)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("tkcb", mahdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> tongdthu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("tongdthu");
        }
    
        public virtual int updatekey(string dem, string tk)
        {
            var demParameter = dem != null ?
                new ObjectParameter("dem", dem) :
                new ObjectParameter("dem", typeof(string));
    
            var tkParameter = tk != null ?
                new ObjectParameter("tk", tk) :
                new ObjectParameter("tk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatekey", demParameter, tkParameter);
        }
    
        public virtual int updatekeykh(string key, string tk)
        {
            var keyParameter = key != null ?
                new ObjectParameter("key", key) :
                new ObjectParameter("key", typeof(string));
    
            var tkParameter = tk != null ?
                new ObjectParameter("tk", tk) :
                new ObjectParameter("tk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updatekeykh", keyParameter, tkParameter);
        }
    
        public virtual ObjectResult<RPhoadon_Result> RPhoadon(string mahd)
        {
            var mahdParameter = mahd != null ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RPhoadon_Result>("RPhoadon", mahdParameter);
        }
    
        public virtual ObjectResult<banchay_Result> banchay()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<banchay_Result>("banchay");
        }
    }
}
