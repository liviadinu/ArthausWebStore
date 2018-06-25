using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models.Repositories
{
    public static class Common
    {
        public static string ReturnSinglePrice(string SKU, IEnumerable<ItemPrices> priceList)
        {
            decimal expectedPrice = 0;
            var price = priceList.Where(i => i.No == SKU).FirstOrDefault();
            expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();

            if (price.EndDateSales >= System.DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
            {
                expectedPrice = expectedPrice - (expectedPrice * price.DiscountPerc.Value / 100);
            }
            return expectedPrice.ToString("c");

        }

        public static string ReturnPicture(string SKU, IEnumerable<ItemPicture> picture)
        {
            var singlePicture = picture.FirstOrDefault(i => i.ItemNo == SKU);
            //System.IO.MemoryStream ms = new System.IO.MemoryStream(singlePicture.Picture);

            //ms.Position = 0;

            //var result = new FileStreamResult(ms, "image/jpg");
            //result.ToString
            String img64 = Convert.ToBase64String(singlePicture.Picture);
            String img64Url = string.Format("data:image/jpg" + ";base64,{0}", img64); //imagetype can be e.g. gif, jpeg, png etc.
       
            return img64Url;


        }
    }
}
