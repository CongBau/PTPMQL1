namespace First_web_Mvc.Models
{
    public class BMI
    {
        public string? HoTen { get; set; }
        public double CanNang { get; set; } //kg
        public double ChieuCao { get; set; } //m (Ngăn cách bằng dấu ,)
        public double GiaTriBMI { get; set; }
        public string? DanhGia { get; set; }
    }
}