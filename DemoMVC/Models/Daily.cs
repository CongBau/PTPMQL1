namespace First_web_Mvc.Models
{
    public class DaiLy
    {
         public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }

        // Khóa ngoại (tham chiếu đến HeThongPhanPhoi)
        public string MaHTPP { get; set; }

        // Navigation property
        public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}