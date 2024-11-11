using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23DH114456_MyStore.Models.ViewModel
{
    public class HomeProductVM
    {
        //search theo tên, mô tả hoặc loại sản phẩm
        public string SearchTerm { get; set; }

        //Thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; }  //Trang hiện tại
        public int PageSize { get; set; } = 10;  //Số sản phẩm mỗi trang

        //Danh sách sản phẩm nổi bật
        public List<Product> FeaturedProducts { get; set; }

        //Danh sách sản phẩm đã phân trang
        public PagedList.IPagedList<Product> NewProducts { get; set; }

        //Danh sách sản phẩm thỏa điều kiện cần thiết
        //public List<Product> Products { get; set; }
    }
}