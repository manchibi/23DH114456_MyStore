using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace _23DH114456_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        public string SearchTerm { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        //Thứ tự sắp xếp
        public string SortOrder { get; set; }

        //Thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; }  //Trang hiện tại
        public int PageSize { get; set; } = 10;  //Số sản phẩm mỗi trang

        //Danh sách sản phẩm đã phân trang
        public PagedList.IPagedList<Product> Products { get; set; }

        //Danh sách sản phẩm thỏa điều kiện cần thiết
        //public List<Product> Products { get; set; }
    }
}