using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DongBoService.DataAccess
{
    public class DongBoDB
    {
        public static SqlDataHelper db1 = new SqlDataHelper(ConfigurationManager.AppSettings["Connect125"]);
        public static SqlDataHelper db2 = new SqlDataHelper(ConfigurationManager.AppSettings["Connect54"]);
        public static SqlDataHelper db3 = new SqlDataHelper(ConfigurationManager.AppSettings["Connect32"]);
        public DongBoDB() { }

        public static bool DongBoTinh()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmtinh").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@matinh", dr["ma_tinh"].ToString()),
                        new SqlParameter("@tentinh", dr["ten_tinh"].ToString()),
                        new SqlParameter("@mien", dr["ma_vung"].ToString()),
                        new SqlParameter("@kyhieu", dr["ky_hieu"].ToString()),
                        new SqlParameter("@pos", dr["pos"].ToString()),
                        new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                        new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                    };


                    SqlParameter[] param2 = new SqlParameter[]
                    {
                        new SqlParameter("@matinh", dr["ma_tinh"].ToString()),
                        new SqlParameter("@tentinh", dr["ten_tinh"].ToString()),
                        new SqlParameter("@mien", dr["ma_vung"].ToString()),
                        new SqlParameter("@kyhieu", dr["ky_hieu"].ToString()),
                        new SqlParameter("@pos", dr["pos"].ToString()),
                        new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                        new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                    };

                    db1.ExecuteNonQuery("usp_DongBo_Tinh", param);
                    db3.ExecuteNonQuery("usp_DongBo_Tinh", param2);
                }

                return true;
            }
           catch
            {
                return false;
            }
        }

        public static bool DongBoHuyen()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmhuyen").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                    new SqlParameter("@mahuyen", dr["ma_huyen"].ToString()),
                    new SqlParameter("@tenhuyen", dr["ten_huyen"].ToString()),
                    new SqlParameter("@matinh", dr["ma_tinh"].ToString()),
                    new SqlParameter("@pos", dr["pos"].ToString()),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                   {
                    new SqlParameter("@mahuyen", dr["ma_huyen"].ToString()),
                    new SqlParameter("@tenhuyen", dr["ten_huyen"].ToString()),
                    new SqlParameter("@matinh", dr["ma_tinh"].ToString()),
                    new SqlParameter("@pos", dr["pos"].ToString()),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                   };

                    db1.ExecuteNonQuery("usp_DongBo_huyen", param);
                    db3.ExecuteNonQuery("usp_DongBo_huyen", param2);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DongBoXa()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmxa").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                    new SqlParameter("@maxa", dr["ma_xa"].ToString()),
                    new SqlParameter("@tenxa", dr["ten_xa"].ToString()),
                    new SqlParameter("@mahuyen", dr["ma_huyen"].ToString()),
                    new SqlParameter("@pos", dr["pos"].ToString()),
                    new SqlParameter("@km", dr["km"].ToString()),
                    new SqlParameter("@gia", (!string.IsNullOrEmpty(dr["gia"].ToString())) ? float.Parse(dr["gia"].ToString()) : 0),
                    new SqlParameter("@kieu", (!string.IsNullOrEmpty(dr["kieu"].ToString())) ? int.Parse(dr["kieu"].ToString()) : 0),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                   {
                    new SqlParameter("@maxa", dr["ma_xa"].ToString()),
                    new SqlParameter("@tenxa", dr["ten_xa"].ToString()),
                    new SqlParameter("@mahuyen", dr["ma_huyen"].ToString()),
                    new SqlParameter("@pos", dr["pos"].ToString()),
                    new SqlParameter("@km", dr["km"].ToString()),
                    new SqlParameter("@gia", (!string.IsNullOrEmpty(dr["gia"].ToString())) ? float.Parse(dr["gia"].ToString()) : 0),
                    new SqlParameter("@kieu", (!string.IsNullOrEmpty(dr["kieu"].ToString())) ? int.Parse(dr["kieu"].ToString()) : 0),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                   };

                    db1.ExecuteNonQuery("usp_DongBo_Xa", param);
                    db3.ExecuteNonQuery("usp_DongBo_Xa", param2);
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoVung()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmvung").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                    new SqlParameter("@mavung", dr["ma_vung"].ToString()),
                    new SqlParameter("@tenvung", dr["ten_vung"].ToString()),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                   {
                    new SqlParameter("@mavung", dr["ma_vung"].ToString()),
                    new SqlParameter("@tenvung", dr["ten_vung"].ToString()),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                   };


                    db1.ExecuteNonQuery("usp_DongBo_Vung", param);
                    db3.ExecuteNonQuery("usp_DongBo_Vung", param2);
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoSerial()
        {
            try
            {
                string timeDongBo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                db3.ExecuteNonQuery("update ThoiGianDongBo set ThoiGian = '" + timeDongBo + "'");
                db1.ExecuteNonQuery("update ThoiGianDongBo set ThoiGian = '" + timeDongBo + "'");
                //
                DataTable dt = db2.ExecuteDataSet("select * from serial where ngay_cn > '" + timeDongBo + "'").Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                    new SqlParameter("@serial", dr["serial"].ToString()),
                    new SqlParameter("@mavt", dr["ma_vt"].ToString()),
                    new SqlParameter("@tembh", (!string.IsNullOrEmpty(dr["tem_bh"].ToString()) ? dr["tem_bh"].ToString() : "")),
                    new SqlParameter("@ngayhhbh", (!string.IsNullOrEmpty(dr["ngay_hh_bh"].ToString()) ? dr["ngay_hh_bh"].ToString() : "")),
                    new SqlParameter("@iFlag", (!string.IsNullOrEmpty(dr["iFlag"].ToString())) ? int.Parse(dr["iFlag"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                   {
                    new SqlParameter("@serial", dr["serial"].ToString()),
                    new SqlParameter("@mavt", dr["ma_vt"].ToString()),
                    new SqlParameter("@tembh", (!string.IsNullOrEmpty(dr["tem_bh"].ToString()) ? dr["tem_bh"].ToString() : "")),
                    new SqlParameter("@ngayhhbh", (!string.IsNullOrEmpty(dr["ngay_hh_bh"].ToString()) ? dr["ngay_hh_bh"].ToString() : "")),
                    new SqlParameter("@iFlag", (!string.IsNullOrEmpty(dr["iFlag"].ToString())) ? int.Parse(dr["iFlag"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString())
                   };

                    db1.ExecuteNonQuery("usp_DongBo_Serial", param);
                    db3.ExecuteNonQuery("usp_DongBo_Serial", param2);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DongBoVatTu()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmvt").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                    new SqlParameter("@mavt", dr["ma_vt"].ToString()),
                    new SqlParameter("@tenvt", dr["ten_vt"].ToString()),
                    new SqlParameter("@dvt", dr["dvt"].ToString()),
                    new SqlParameter("@gia", (!string.IsNullOrEmpty(dr["gia"].ToString())) ? float.Parse(dr["gia"].ToString()) : 0),
                    new SqlParameter("@model", dr["model"].ToString()),
                    new SqlParameter("@manh", dr["ma_nh"].ToString()),
                    new SqlParameter("@nhomphu", dr["nhom_phu"].ToString()),
                    new SqlParameter("@lkro", (!string.IsNullOrEmpty(dr["lk_ro"].ToString())) ? int.Parse(dr["lk_ro"].ToString()) : 0)
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                    {
                    new SqlParameter("@mavt", dr["ma_vt"].ToString()),
                    new SqlParameter("@tenvt", dr["ten_vt"].ToString()),
                    new SqlParameter("@dvt", dr["dvt"].ToString()),
                    new SqlParameter("@gia", (!string.IsNullOrEmpty(dr["gia"].ToString())) ? float.Parse(dr["gia"].ToString()) : 0),
                    new SqlParameter("@model", dr["model"].ToString()),
                    new SqlParameter("@manh", dr["ma_nh"].ToString()),
                    new SqlParameter("@nhomphu", dr["nhom_phu"].ToString()),
                    new SqlParameter("@lkro", (!string.IsNullOrEmpty(dr["lk_ro"].ToString())) ? int.Parse(dr["lk_ro"].ToString()) : 0)
                    };

                    db1.ExecuteNonQuery("usp_DongBo_VatTu", param);
                    db3.ExecuteNonQuery("usp_DongBo_VatTu", param2);
                }

                return true;
            }
           catch(Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoNhomVatTu()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmnhvt").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                    new SqlParameter("@manh", dr["ma_nh"].ToString()),
                    new SqlParameter("@tennh", dr["ten_nh"].ToString()),
                    new SqlParameter("@lkro", (!string.IsNullOrEmpty(dr["lk_ro"].ToString())) ? int.Parse(dr["lk_ro"].ToString()) : 0),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString()),
                    };


                    SqlParameter[] param2 = new SqlParameter[]
                    {
                    new SqlParameter("@manh", dr["ma_nh"].ToString()),
                    new SqlParameter("@tennh", dr["ten_nh"].ToString()),
                    new SqlParameter("@lkro", (!string.IsNullOrEmpty(dr["lk_ro"].ToString())) ? int.Parse(dr["lk_ro"].ToString()) : 0),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString()),
                    };
                    db1.ExecuteNonQuery("usp_DongBo_NhomVatTu", param);
                    db3.ExecuteNonQuery("usp_DongBo_NhomVatTu", param2);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoKho()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmkho").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                    new SqlParameter("@makho", dr["ma_kho"].ToString()),
                    new SqlParameter("@madvcs", dr["ma_dvcs"].ToString()),
                    new SqlParameter("@matinh", dr["ma_tinh"].ToString()),
                    new SqlParameter("@mahuyen",  dr["ma_huyen"].ToString()),
                    new SqlParameter("@maxa",  dr["ma_xa"].ToString()),
                    new SqlParameter("@tenkho",  dr["ten_kho"].ToString()),
                    new SqlParameter("@shortname",  dr["short_name"].ToString()),
                    new SqlParameter("@ongba",  dr["ong_ba"].ToString()),
                    new SqlParameter("@diachi",  dr["dia_chi"].ToString()),
                    new SqlParameter("@dienthoai",  dr["dien_thoai"].ToString()),
                    new SqlParameter("@fax",  dr["fax"].ToString()),
                    new SqlParameter("@email",  dr["email"].ToString()),
                    new SqlParameter("@hanmuc",  (!string.IsNullOrEmpty(dr["han_muc"].ToString())) ? float.Parse(dr["han_muc"].ToString()) : 0),
                    new SqlParameter("@mank",  dr["ma_nk"].ToString()),
                    new SqlParameter("@phicodinh",  dr["phi_codinh"].ToString()),
                    new SqlParameter("@congno",  dr["cong_no"].ToString()),
                    new SqlParameter("@khoktv",  dr["kho_ktv"].ToString()),
                    new SqlParameter("@makk",  dr["ma_kk"].ToString()),
                    new SqlParameter("@trangthai",  dr["trang_thai"].ToString()),
                    new SqlParameter("@maxaqly",  dr["maxa_qly"].ToString()),
                    new SqlParameter("@tenxaqly",  dr["tenxa_qly"].ToString()),
                    new SqlParameter("@trangthaiqly",  dr["trangthai_qly"].ToString()),
                    new SqlParameter("@ghichuqly",  dr["ghichu_qly"].ToString()),
                    new SqlParameter("@ghichu",  dr["ghi_chu"].ToString())
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                    {
                    new SqlParameter("@makho", dr["ma_kho"].ToString()),
                    new SqlParameter("@madvcs", dr["ma_dvcs"].ToString()),
                    new SqlParameter("@matinh", dr["ma_tinh"].ToString()),
                    new SqlParameter("@mahuyen",  dr["ma_huyen"].ToString()),
                    new SqlParameter("@maxa",  dr["ma_xa"].ToString()),
                    new SqlParameter("@tenkho",  dr["ten_kho"].ToString()),
                    new SqlParameter("@shortname",  dr["short_name"].ToString()),
                    new SqlParameter("@ongba",  dr["ong_ba"].ToString()),
                    new SqlParameter("@diachi",  dr["dia_chi"].ToString()),
                    new SqlParameter("@dienthoai",  dr["dien_thoai"].ToString()),
                    new SqlParameter("@fax",  dr["fax"].ToString()),
                    new SqlParameter("@email",  dr["email"].ToString()),
                    new SqlParameter("@hanmuc",  (!string.IsNullOrEmpty(dr["han_muc"].ToString())) ? float.Parse(dr["han_muc"].ToString()) : 0),
                    new SqlParameter("@mank",  dr["ma_nk"].ToString()),
                    new SqlParameter("@phicodinh",  dr["phi_codinh"].ToString()),
                    new SqlParameter("@congno",  dr["cong_no"].ToString()),
                    new SqlParameter("@khoktv",  dr["kho_ktv"].ToString()),
                    new SqlParameter("@makk",  dr["ma_kk"].ToString()),
                    new SqlParameter("@trangthai",  dr["trang_thai"].ToString()),
                    new SqlParameter("@maxaqly",  dr["maxa_qly"].ToString()),
                    new SqlParameter("@tenxaqly",  dr["tenxa_qly"].ToString()),
                    new SqlParameter("@trangthaiqly",  dr["trangthai_qly"].ToString()),
                    new SqlParameter("@ghichuqly",  dr["ghichu_qly"].ToString()),
                    new SqlParameter("@ghichu",  dr["ghi_chu"].ToString())
                    };

                    db1.ExecuteNonQuery("usp_DongBo_Kho", param);
                    db3.ExecuteNonQuery("usp_DongBo_NhomVatTu", param2);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoHienTuong()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmhientuong").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                    new SqlParameter("@maht", dr["ma_ht"].ToString()),
                    new SqlParameter("@tenht", dr["ten_ht"].ToString()),
                    new SqlParameter("@manh", dr["ma_nh"].ToString()),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString()),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                   {
                    new SqlParameter("@maht", dr["ma_ht"].ToString()),
                    new SqlParameter("@tenht", dr["ten_ht"].ToString()),
                    new SqlParameter("@manh", dr["ma_nh"].ToString()),
                    new SqlParameter("@ghichu", dr["ghi_chu"].ToString()),
                    new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                   };

                    db1.ExecuteNonQuery("usp_DongBo_HienTuong", param);
                    db3.ExecuteNonQuery("usp_DongBo_HienTuong", param2);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoLoi()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmloi").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@maloi", dr["ma_loi"].ToString()),
                        new SqlParameter("@manh", dr["ma_nh"].ToString()),
                        new SqlParameter("@tenloi", dr["ten_loi"].ToString()),
                        new SqlParameter("@motaloi", dr["mota_loi"].ToString()),
                        new SqlParameter("@ghichu", dr["ghi_chu"].ToString()),
                        new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                    {
                        new SqlParameter("@maloi", dr["ma_loi"].ToString()),
                        new SqlParameter("@manh", dr["ma_nh"].ToString()),
                        new SqlParameter("@tenloi", dr["ten_loi"].ToString()),
                        new SqlParameter("@motaloi", dr["mota_loi"].ToString()),
                        new SqlParameter("@ghichu", dr["ghi_chu"].ToString()),
                        new SqlParameter("@trangthai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                    };

                    db1.ExecuteNonQuery("usp_DongBo_Loi", param);
                    db3.ExecuteNonQuery("usp_DongBo_Loi", param2);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoMaSC()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmmasc").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@ma_sc", dr["ma_sc"].ToString()),
                        new SqlParameter("@ma_nh", dr["ma_nh"].ToString()),
                        new SqlParameter("@ten_sc", dr["ten_sc"].ToString()),
                        new SqlParameter("@mota_sc", dr["mota_sc"].ToString()),
                        new SqlParameter("@tien_asc", (!string.IsNullOrEmpty(dr["tien_asc"].ToString())) ? float.Parse(dr["tien_asc"].ToString()) : 0),
                        new SqlParameter("@tien_ktv", (!string.IsNullOrEmpty(dr["tien_ktv"].ToString())) ? float.Parse(dr["tien_ktv"].ToString()) : 0),
                        new SqlParameter("@kieu_sc", (!string.IsNullOrEmpty(dr["kieu_sc"].ToString())) ? int.Parse(dr["kieu_sc"].ToString()) : 0),
                        new SqlParameter("@ktv_bac", (!string.IsNullOrEmpty(dr["ktv_bac"].ToString())) ? float.Parse(dr["ktv_bac"].ToString()) : 0),
                        new SqlParameter("@ktv_trung", (!string.IsNullOrEmpty(dr["ktv_trung"].ToString())) ? float.Parse(dr["ktv_trung"].ToString()) : 0),
                        new SqlParameter("@ktv_nam", (!string.IsNullOrEmpty(dr["ktv_nam"].ToString())) ? float.Parse(dr["ktv_nam"].ToString()) : 0),
                        new SqlParameter("@asc_bac", (!string.IsNullOrEmpty(dr["asc_bac"].ToString())) ? float.Parse(dr["asc_bac"].ToString()) : 0),
                        new SqlParameter("@asc_trung", (!string.IsNullOrEmpty(dr["asc_trung"].ToString())) ? float.Parse(dr["asc_trung"].ToString()) : 0),
                        new SqlParameter("@asc_nam", (!string.IsNullOrEmpty(dr["asc_nam"].ToString())) ? float.Parse(dr["asc_nam"].ToString()) : 0),
                        new SqlParameter("@ghi_chu", dr["ghi_chu"].ToString()),
                        new SqlParameter("@trang_thai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                   {
                        new SqlParameter("@ma_sc", dr["ma_sc"].ToString()),
                        new SqlParameter("@ma_nh", dr["ma_nh"].ToString()),
                        new SqlParameter("@ten_sc", dr["ten_sc"].ToString()),
                        new SqlParameter("@mota_sc", dr["mota_sc"].ToString()),
                        new SqlParameter("@tien_asc", (!string.IsNullOrEmpty(dr["tien_asc"].ToString())) ? float.Parse(dr["tien_asc"].ToString()) : 0),
                        new SqlParameter("@tien_ktv", (!string.IsNullOrEmpty(dr["tien_ktv"].ToString())) ? float.Parse(dr["tien_ktv"].ToString()) : 0),
                        new SqlParameter("@kieu_sc", (!string.IsNullOrEmpty(dr["kieu_sc"].ToString())) ? int.Parse(dr["kieu_sc"].ToString()) : 0),
                        new SqlParameter("@ktv_bac", (!string.IsNullOrEmpty(dr["ktv_bac"].ToString())) ? float.Parse(dr["ktv_bac"].ToString()) : 0),
                        new SqlParameter("@ktv_trung", (!string.IsNullOrEmpty(dr["ktv_trung"].ToString())) ? float.Parse(dr["ktv_trung"].ToString()) : 0),
                        new SqlParameter("@ktv_nam", (!string.IsNullOrEmpty(dr["ktv_nam"].ToString())) ? float.Parse(dr["ktv_nam"].ToString()) : 0),
                        new SqlParameter("@asc_bac", (!string.IsNullOrEmpty(dr["asc_bac"].ToString())) ? float.Parse(dr["asc_bac"].ToString()) : 0),
                        new SqlParameter("@asc_trung", (!string.IsNullOrEmpty(dr["asc_trung"].ToString())) ? float.Parse(dr["asc_trung"].ToString()) : 0),
                        new SqlParameter("@asc_nam", (!string.IsNullOrEmpty(dr["asc_nam"].ToString())) ? float.Parse(dr["asc_nam"].ToString()) : 0),
                        new SqlParameter("@ghi_chu", dr["ghi_chu"].ToString()),
                        new SqlParameter("@trang_thai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                   };

                    db1.ExecuteNonQuery("usp_DongBo_MaSC", param);
                    db3.ExecuteNonQuery("usp_DongBo_MaSC", param2);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoGoiBD()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from goibd").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@ma_bd", dr["ma_bd"].ToString()),
                        new SqlParameter("@ten_bd", dr["ten_bd"].ToString()),
                        new SqlParameter("@mo_ta", dr["mo_ta"].ToString()),
                        new SqlParameter("@thoi_gian", (!string.IsNullOrEmpty(dr["thoi_gian"].ToString())) ? int.Parse(dr["thoi_gian"].ToString()) : 0),
                        new SqlParameter("@don_gia", (!string.IsNullOrEmpty(dr["don_gia"].ToString())) ? float.Parse(dr["don_gia"].ToString()) : 0),
                        new SqlParameter("@thuong_tv", (!string.IsNullOrEmpty(dr["thuong_tv"].ToString())) ? int.Parse(dr["thuong_tv"].ToString()) : 0),
                        new SqlParameter("@thuong_ky", (!string.IsNullOrEmpty(dr["thuong_ky"].ToString())) ? int.Parse(dr["thuong_ky"].ToString()) : 0),
                        new SqlParameter("@ghi_chu", dr["ghi_chu"].ToString()),
                        new SqlParameter("@trang_thai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                    {
                        new SqlParameter("@ma_bd", dr["ma_bd"].ToString()),
                        new SqlParameter("@ten_bd", dr["ten_bd"].ToString()),
                        new SqlParameter("@mo_ta", dr["mo_ta"].ToString()),
                        new SqlParameter("@thoi_gian", (!string.IsNullOrEmpty(dr["thoi_gian"].ToString())) ? int.Parse(dr["thoi_gian"].ToString()) : 0),
                        new SqlParameter("@don_gia", (!string.IsNullOrEmpty(dr["don_gia"].ToString())) ? float.Parse(dr["don_gia"].ToString()) : 0),
                        new SqlParameter("@thuong_tv", (!string.IsNullOrEmpty(dr["thuong_tv"].ToString())) ? int.Parse(dr["thuong_tv"].ToString()) : 0),
                        new SqlParameter("@thuong_ky", (!string.IsNullOrEmpty(dr["thuong_ky"].ToString())) ? int.Parse(dr["thuong_ky"].ToString()) : 0),
                        new SqlParameter("@ghi_chu", dr["ghi_chu"].ToString()),
                        new SqlParameter("@trang_thai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                    };

                    db1.ExecuteNonQuery("usp_DongBo_GoiBD", param);
                    db3.ExecuteNonQuery("usp_DongBo_GoiBD", param2);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoPhiKM()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from phi_km").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@ma_phi", (!string.IsNullOrEmpty(dr["ma_phi"].ToString())) ? int.Parse(dr["ma_phi"].ToString()) : 0),
                        new SqlParameter("@ten_phi", dr["ten_phi"].ToString()),
                        new SqlParameter("@tu_km", (!string.IsNullOrEmpty(dr["tu_km"].ToString())) ? float.Parse(dr["tu_km"].ToString()) : 0),
                        new SqlParameter("@den_km", (!string.IsNullOrEmpty(dr["den_km"].ToString())) ? float.Parse(dr["den_km"].ToString()) : 0),
                        new SqlParameter("@so_tien", (!string.IsNullOrEmpty(dr["so_tien"].ToString())) ? float.Parse(dr["so_tien"].ToString()) : 0),
                        new SqlParameter("@tien_km", (!string.IsNullOrEmpty(dr["tien_km"].ToString())) ? float.Parse(dr["tien_km"].ToString()) : 0),
                        new SqlParameter("@ghi_chu", dr["ghi_chu"].ToString()),
                        new SqlParameter("@trang_thai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                    {
                        new SqlParameter("@ma_phi", (!string.IsNullOrEmpty(dr["ma_phi"].ToString())) ? int.Parse(dr["ma_phi"].ToString()) : 0),
                        new SqlParameter("@ten_phi", dr["ten_phi"].ToString()),
                        new SqlParameter("@tu_km", (!string.IsNullOrEmpty(dr["tu_km"].ToString())) ? float.Parse(dr["tu_km"].ToString()) : 0),
                        new SqlParameter("@den_km", (!string.IsNullOrEmpty(dr["den_km"].ToString())) ? float.Parse(dr["den_km"].ToString()) : 0),
                        new SqlParameter("@so_tien", (!string.IsNullOrEmpty(dr["so_tien"].ToString())) ? float.Parse(dr["so_tien"].ToString()) : 0),
                        new SqlParameter("@tien_km", (!string.IsNullOrEmpty(dr["tien_km"].ToString())) ? float.Parse(dr["tien_km"].ToString()) : 0),
                        new SqlParameter("@ghi_chu", dr["ghi_chu"].ToString()),
                        new SqlParameter("@trang_thai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0)
                    };

                    db1.ExecuteNonQuery("sp_DongBo_PhiKM", param);
                    db3.ExecuteNonQuery("sp_DongBo_PhiKM", param2);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoStatus()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from status").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@iPage", (!string.IsNullOrEmpty(dr["iPage"].ToString())) ? int.Parse(dr["iPage"].ToString()) : 0),
                        new SqlParameter("@StatusID", (!string.IsNullOrEmpty(dr["StatusID"].ToString())) ? int.Parse(dr["StatusID"].ToString()) : 0),
                        new SqlParameter("@StatusName", dr["StatusName"].ToString()),
                        new SqlParameter("@Pos", dr["Pos"].ToString()),
                        new SqlParameter("@Notes",(!string.IsNullOrEmpty(dr["StatusID"].ToString())) ? dr["Notes"].ToString() : ""),
                        new SqlParameter("@iType", int.Parse(dr["iType"].ToString()))
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                    {
                        new SqlParameter("@iPage", (!string.IsNullOrEmpty(dr["iPage"].ToString())) ? int.Parse(dr["iPage"].ToString()) : 0),
                        new SqlParameter("@StatusID", (!string.IsNullOrEmpty(dr["StatusID"].ToString())) ? int.Parse(dr["StatusID"].ToString()) : 0),
                        new SqlParameter("@StatusName", dr["StatusName"].ToString()),
                        new SqlParameter("@Pos", dr["Pos"].ToString()),
                        new SqlParameter("@Notes",(!string.IsNullOrEmpty(dr["StatusID"].ToString())) ? dr["Notes"].ToString() : ""),
                        new SqlParameter("@iType", int.Parse(dr["iType"].ToString()))
                    };

                    db1.ExecuteNonQuery("usp_DongBo_Status", param);
                    db3.ExecuteNonQuery("usp_DongBo_Status", param2);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoVungQuanLy()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from vung_qly").Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@ma_qly", (!string.IsNullOrEmpty(dr["ma_qly"].ToString())) ? int.Parse(dr["ma_qly"].ToString()) : 0),
                        new SqlParameter("@ma_kho", dr["ma_kho"].ToString()),
                        new SqlParameter("@ma_xa", dr["ma_xa"].ToString()),
                        new SqlParameter("@ma_huyen", dr["ma_huyen"].ToString()),
                        new SqlParameter("@ma_tinh", dr["ma_tinh"].ToString()),
                        new SqlParameter("@trang_thai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                        new SqlParameter("@ghi_chu", dr["ghi_chu"].ToString())
                    };

                    SqlParameter[] param2 = new SqlParameter[]
                    {
                        new SqlParameter("@ma_qly", (!string.IsNullOrEmpty(dr["ma_qly"].ToString())) ? int.Parse(dr["ma_qly"].ToString()) : 0),
                        new SqlParameter("@ma_kho", dr["ma_kho"].ToString()),
                        new SqlParameter("@ma_xa", dr["ma_xa"].ToString()),
                        new SqlParameter("@ma_huyen", dr["ma_huyen"].ToString()),
                        new SqlParameter("@ma_tinh", dr["ma_tinh"].ToString()),
                        new SqlParameter("@trang_thai", (!string.IsNullOrEmpty(dr["trang_thai"].ToString())) ? int.Parse(dr["trang_thai"].ToString()) : 0),
                        new SqlParameter("@ghi_chu", dr["ghi_chu"].ToString())
                    };

                    db1.ExecuteNonQuery("sp_DongBo_VungQLy", param);
                    db3.ExecuteNonQuery("sp_DongBo_VungQLy", param2);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DongBoDanhMucKhac()
        {
            try
            {
                DataTable dt = db2.ExecuteDataSet("select * from dmkhac").Tables[0];
                foreach(DataRow dr in dt.Rows)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("@iPage", int.Parse(dr["iPage"].ToString())),
                        new SqlParameter("@ma_dm", int.Parse(dr["ma_dm"].ToString())),
                        new SqlParameter("@ten_dm", dr["ten_dm"].ToString()),
                        new SqlParameter("@ghi_chu", dr["ghi_chu"].ToString()),
                        new SqlParameter("@trang_thai", int.Parse(dr["trang_thai"].ToString()))
                    };

                    db1.ExecuteNonQuery("usp_DongBo_DMKhac", param);
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}