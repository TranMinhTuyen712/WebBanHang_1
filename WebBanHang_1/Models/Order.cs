using System.ComponentModel.DataAnnotations;
using System;

namespace WebBanHang_1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập họ và tên ")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ giao hàng")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại liên hệ")]
        public string Phone { get; set; }
        public double Total { get; set; }
        public string State { get; set; }

    }
}
