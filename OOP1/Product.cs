using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        // Ürün Id'si
        public int Id { get; set; }
        // Ürünün Kategori Id'si: hangi kategoriye dahil bir ürün olduğu bilgisi
        public int CategoryId { get; set; }
        // Ürün ismi
        public string ProductName { get; set; }
        // Ürünün Birim Fiyatı
        public double UnitPrice { get; set; }
        // Ürünün Stok Adedi
        public int UnitsInStock { get; set; }
    }
}
