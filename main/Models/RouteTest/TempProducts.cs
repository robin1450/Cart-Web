using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace main.Models.RouteTest
{
    public class TempProducts
    {
        // GET: TempProducts
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static List<TempProducts> getAllproduct()
        {
            List<TempProducts> result = new List<TempProducts>();
            result.Add(new main.Models.RouteTest.TempProducts
            {
                ID = 1,
                Name = "皮卡丘",
                Price = 30.0m
            });

            result.Add(new main.Models.RouteTest.TempProducts
            {
                ID = 2,
                Name = "小火龍",
                Price = 45.0m
            });

            result.Add(new main.Models.RouteTest.TempProducts
            {
                ID = 3,
                Name = "傑尼龜",
                Price = 50.0m
            });

            result.Add(new main.Models.RouteTest.TempProducts
            {
                ID =4,
                Name = "妙蛙種子",
                Price = 35.0m
            });

            return result;
        }


    }
    //把商品項目交到這裡面
  
}