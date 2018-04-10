using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLThuVien
{
    public static class ThamSoKetNoi
    {
        public static string g_sServerName = ""; //Tên máy chủ
        public static string g_sDatabaseName = ""; //Tên CSDL
        public static string g_sUserName = ""; //Tên tài khoản
        public static string g_sPassword = ""; //Mật khẩu
        public static bool g_bWinAuthentication = false; //Loại xác thực

        public static string g_StringConnect = ""; //Chuỗi kết nối

        public static void TaoChuoiKetNoi()
        {
            //Tạo là chuỗi kết nối từ các tham số kết nối
            string Temp = "";

            Temp = "Data Source = " + g_sServerName + ";";
            Temp += "Initial Catalog = " + g_sDatabaseName + ";";
            if (g_bWinAuthentication == true)
                Temp += "Integrated security = true";
            else
                Temp += "Integrated security = false; User ID= " + g_sUserName + ";"
                        + "Password = " + g_sPassword;

            g_StringConnect = Temp;

        }
    }
}
