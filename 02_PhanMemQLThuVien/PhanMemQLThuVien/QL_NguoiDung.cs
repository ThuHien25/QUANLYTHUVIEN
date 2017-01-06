using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using BLL;
namespace PhanMemQLThuVien
{
   public class QL_NguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.CNPM_QLThuVien_ConnectString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.CNPM_QLThuVien_ConnectString);
            try
            {
                if (_Sqlconn.State == ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }

        public LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NGUOIDUNG where TENTAIKHOAN='"
                + pUser + "' and MATKHAU ='" + pPass + "'", Properties.Settings.Default.CNPM_QLThuVien_ConnectString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return LoginResult.Invalid;// User không tồn tại
            else if (dt.Rows[0][3] == null || dt.Rows[0][3].ToString() == "False")
            {
                return LoginResult.Disabled;// Không hoạt động
            }
            
          //  ThongTinNguoiDung.TenNhanVien = "adfdf";
            ThongTinNguoiDung.TenNguoiDung = pUser;
            ThongTinNguoiDung.MatKhau = pPass;
           
            return LoginResult.Success;// Đăng nhập thành công
        }
        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + "");
            da.Fill(dt);
            return dt;
        }
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            PhanMemQLThuVien.Properties.Settings.Default.CNPM_QLThuVien_ConnectString = "Data Source=" + pServer +
                ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            PhanMemQLThuVien.Properties.Settings.Default.Save();
        }

        //public const string PUBLIC_KEY = "05DHLTH";
        /// <summary>
        /// Encrypts the specified value (Mã hóa password).
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public string Encrypt(string value)
        {
            string publickKey = "HIENDONG";
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            byte[] bytesIn = Encoding.UTF8.GetBytes(value);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] bytesKey = Encoding.UTF8.GetBytes(publickKey);
            Array.Resize(ref bytesKey, des.Key.Length);
            Array.Resize(ref bytesKey, des.IV.Length);
            des.Key = bytesKey;
            des.IV = bytesKey;
            MemoryStream msOut = new MemoryStream();
            ICryptoTransform desdecrypt = des.CreateEncryptor();
            CryptoStream cryptStreem = new CryptoStream(msOut, desdecrypt, CryptoStreamMode.Write);
            cryptStreem.Write(bytesIn, 0, bytesIn.Length);
            cryptStreem.FlushFinalBlock();
            byte[] bytesOut = msOut.ToArray();
            cryptStreem.Close();
            msOut.Close();
            return Convert.ToBase64String(bytesOut);
        }
        //-------------------------------------------------------------------------------
        public List<string> GetMaNhomNguoiDung(string TenDangNhap)
        {
            List<string> kq = new List<string>();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select MANHOM from  NGUOIDUNG_NHOMNGUOIDUNG where TENNGUOIDUNG='" 
                + TenDangNhap + "'", Properties.Settings.Default.CNPM_QLThuVien_ConnectString);
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                kq.Add(item[0].ToString());
            }
            return kq;
        }
        public DataTable GetMaManHinh(string MaNhomNguoiDung)
        {
            List<string> kq = new List<string>();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select MAMH, COQUYEN from PHANQUYEN where MANHOM ='"
                + MaNhomNguoiDung + "'", Properties.Settings.Default.CNPM_QLThuVien_ConnectString);
            da.Fill(dt);
            return dt;
        }

        
    }
}
