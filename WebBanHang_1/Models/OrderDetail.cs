﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang_1.Models
{
    public class OrderDetail
        {
            public int Id { get; set; }
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }

            //Bổ sung mối kết hợp 1-n
            [ForeignKey("OrderId")]
            public Order Order { get; set; }
            [ForeignKey("ProductId")]
            public Product Product { get; set; }
        }
    }
