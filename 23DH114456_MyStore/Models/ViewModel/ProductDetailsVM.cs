﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace _23DH114456_MyStore.Models.ViewModel
{
    public class ProductDetailsVM
    {
        public Product product { get; set; }
        public int quantity { get; set; } = 1;
        //Tính giá trị tạm thời
        public decimal estimatedValue => quantity * product.ProductPrice;

        // Các thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 3;

        //danh sách 8 sản phẩm danh mục
        public PagedList.IPagedList<Product> RelatedProducts { get; set; }

        //danh sách 8 sản phẩm bán chạy nhất cùng danh mục
        public PagedList.IPagedList<Product> TopProducts { get; set; } 
    }
}