namespace First_web_Mvc.Models
{
    public class HeThongPhanPhoi

    {
        public string MaHTPP { get; set; }
        public string TenHTPP { get; set; }
        public ICollection<DaiLy> DaiLys { get; set; } = new List<DaiLy>();
         
    }
}