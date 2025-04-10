using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Strings.LanguageString
{
    public class IndonesiaString : GetString
    {
        public string STR_LOADING { get; set; } = "Tunggu Sebentar...";
        public string STR_DLL_JSON_NULL { get; set; } = "Newtonsoft.Json.dll Tidak Ditemukan";
        public string STR_GET_SUPPORT_FILE { get; set; } = "Memeriksa File Yang Di Butuhkan";
        public string STR_SUCCESS_CHECK { get; set; } = "Pemeriksaan Berhasil...";
        public string STR_ALREADY_GAME { get; set; } = "Terdapat Program Yang Sudah Berjalan";
        public string STR_MAINTENANCE { get; set; } = "Server Saat Ini Sedang Dalam Maintenance";
        public string STR_CONNECTION_BROKEN { get; set; } = "Gagal Terhubung Ke Server \nKoneksi Server Rusak";
        public string STR_NULL_CONNECTION { get; set; } = "Gagal Terhubung Ke Server \nServer Status Tidak Ditemukan";
        public string STR_CHECK_CONNECTION { get; set; } = "Memeriksa Koneksi...";
        public string STR_MSG_MAINTENANCE { get; set; } = "Server Saat Ini Sedang Dalam Maintenance\nSilahkan Coba Lagi Nanti";
        public string STR_SAVE_SETTING { get; set; } = "Pengaturan Telah Tersimpan";
        public string STR_MINIMIZE_CHECK { get; set; } = "Minimize Program Saat Game Dimulai";
        public string STR_LOGIN_NAME { get; set; } = "Masuk";
        public string STR_REGISTER_NAME { get; set; } = "Daftar";
        public string STR_REGISTER_TEXT { get; set; } = "Daftar Disini";
        public string STR_FORGOT_PASS { get; set; } = "Lupa Password?";

        //=============== String Main Form =============

        public string STR_ABOUT_BUTTON { get; set; } = "TENTANG KAMI";
        public string STR_GAMELIST_BUTTON { get; set; } = "DAFTAR GAME";
        public string STR_ITEM_SHOP { get; set; } = "TOKO ITEM";
        public string STR_TOPUP_CENTER { get; set; } = "PUSAT TOPUP";
        public string STR_ACCOUNT_CENTER { get; set; } = "AKUN SAYA";
        public string STR_SETTING_BUTTON { get; set; } = "PENGATURAN";

        //=============== End String Main =============

        //=============== String Login Form =============

        public string STR_ID_OR_PASS { get; set; } = "Username atau Password Tidak Boleh Kosong";
        public string STR_WRONG_ID_OR_PASS { get; set; } = "Username atau Password Salah";
        public string STR_UPDATE_FIRST { get; set; } = "Silahkan Update Terlebih Dahulu";
    }
}
