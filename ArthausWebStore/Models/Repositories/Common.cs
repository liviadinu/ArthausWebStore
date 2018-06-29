using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Text.RegularExpressions;
using ArthausWebStore.ViewModels;

namespace ArthausWebStore.Models.Repositories
{
    public static class Common
    {
       public static string ReturnAppliedPrice(string SKU, IEnumerable<ItemPrices> priceList)
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

        public static string ReturnAppliedPrice(string SKU, ItemPrices price)
        {
            decimal expectedPrice = 0;
            expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();

            if (price.EndDateSales >= System.DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
            {
                expectedPrice = expectedPrice - (expectedPrice * price.DiscountPerc.Value / 100);
            }
            return expectedPrice.ToString("c");
        }

        public static string ReturnNormalPrice(string SKU, IEnumerable<ItemPrices> priceList)
        {
            decimal expectedPrice = 0;
            var price = priceList.Where(i => i.No == SKU).FirstOrDefault();
            expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();
            return expectedPrice.ToString("c");

        }
        public static bool ShowDiscounted(string SKU, IEnumerable<ItemPrices> prices)
        {
            decimal normalPrice,discountPrice = 0;
            var price = prices.Where(i => i.No == SKU).FirstOrDefault();
            normalPrice = price.UnitPriceIncludingVat.GetValueOrDefault();
            discountPrice = normalPrice;

            if (price.EndDateSales >= System.DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
            {
                discountPrice = normalPrice - (normalPrice * price.DiscountPerc.Value / 100);
            }

            return discountPrice == normalPrice;
        }

        public static string ReturnDiscountPerc(string SKU, IEnumerable<ItemPrices> priceList)
        {
            var price = priceList.Where(i => i.No == SKU).FirstOrDefault();
            var discount = price.DiscountPerc.GetValueOrDefault();
            return discount.ToString();
        }
        public static string ReturnPicture(string SKU, PictureSizes size)
        {

            Account account = new Account(
                              "dofen60gc",
                              "187345354299731",
                              "iaR5cE8qs_DZM4t-vqjvIBckpiM");

            Cloudinary cloudinary = new Cloudinary(account);


            switch (size)
            {
                case PictureSizes.Thumbnail:
                    return
                        cloudinary.Api.UrlImgUp.Transform(new Transformation().Background("#ffffff").Height(250).
                          Width(250).Crop("scale")).BuildUrl(String.Format("pictures/{0}.jpeg", SKU));
                case PictureSizes.SingleLarge:
                     return cloudinary.Api.UrlImgUp.Transform(new Transformation().Background("#ffffff").Height(450).
                          Width(70).Crop("scale")).BuildUrl(String.Format("pictures/{0}.jpeg", SKU));
                case PictureSizes.SmallBanner:
                     return cloudinary.Api.UrlImgUp.Transform(new Transformation().Background("#ffffff").Height(470).
                          Width(470).Crop("scale")).BuildUrl(String.Format("pictures/{0}.jpeg", SKU));
                //case PictureSizes.SingleMedium:
                //       return String.Format("~/img/single-product/medium/{0}.jpeg", SKU);
                //case PictureSizes.SingleSmall:
                //       return String.Format("~/img/single-product/samll/{0}.jpeg", SKU);
                case PictureSizes.Discount:
                    return cloudinary.Api.UrlImgUp.Transform(new Transformation().Background("#ffffff").Height(340).
                        Width(290).Crop("scale")).BuildUrl(String.Format("pictures/{0}.jpeg", SKU));
                case PictureSizes.Cart:
                    return
                        cloudinary.Api.UrlImgUp.Transform(new Transformation().Background("#ffffff").Height(90).
                           Width(90).Crop("scale")).BuildUrl(String.Format("pictures/{0}.jpeg", SKU));
                case PictureSizes.Quickview:
                    return
                        cloudinary.Api.UrlImgUp.Transform(new Transformation().Background("#ffffff").Height(370).
                           Width(450).Crop("scale")).BuildUrl(String.Format("pictures/{0}.jpeg", SKU));

                //case PictureSizes.BlogSquare:
                //       return String.Format("~/img/blog/square/{0}.jpeg", SKU);
                //case PictureSizes.BlogRectangle:
                //       return String.Format("~/img/blog/rectangle/{0}.jpeg", SKU);
                //default: return String.Format("~/img/product/All/{0}.jpeg", SKU);

                default:
                    return 
                        cloudinary.Api.UrlImgUp.Transform(new Transformation().Background("#ffffff").
                          Width(250).Crop("scale")).BuildUrl(String.Format("pictures/{0}.jpeg", SKU));
            }

        }
    }
}
