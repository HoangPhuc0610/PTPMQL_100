
namespace FirstWebMVC.Models 
{
    public class DaiLy
    {
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }

        // Khóa ngoại tham chiếu tới HeThongPhanPhoi
        public string MaHTPP { get; set; }

        // Thuộc tính liên kết trực tiếp (association)
        public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}