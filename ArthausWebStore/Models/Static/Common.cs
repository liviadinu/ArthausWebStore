using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Text.RegularExpressions;
using ArthausWebStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using ArthausWebStore.Models.Interface;

namespace ArthausWebStore.Models.Repositories
{
    public static class Common 

    {

       private static IEnumerable<ItemPrices> _prices;

      private static IEnumerable<String>[] _attributes;

      public static void SetPricecollection(IEnumerable<ItemPrices> prices)
      {
            _prices = prices;
      }

        public static void SetAttributes(List<String>[] itemAttributes)
        {
            try
            {
                _attributes = itemAttributes;
            }
            catch (IndexOutOfRangeException ex)
            {
                var message = "Attribute index out of range";
            }
        }

        public static List<String> GetAttributes(int i)
        {
            return _attributes[i].ToList();
        }

        public static async Task<string> ReturnAppliedPrice(string SKU)
        {
            decimal expectedPrice = 1000;
            try
            {
                var price = await GetPriceRecord(SKU);
                expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();

                if (price.EndDateSales >= DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
                {
                    expectedPrice = expectedPrice - (expectedPrice * price.DiscountPerc.Value / 100);
                }
            }
            catch (NullReferenceException ex)
            {
                expectedPrice = 100;
            }

            return expectedPrice.ToString("c");            
        }

        public static async Task<string> ReturnNormalPrice(string SKU)
        {
            decimal expectedPrice = 100;
            var price = await GetPriceRecord(SKU);
            if (price != null)
            {
                expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();
            }
            return expectedPrice.ToString("c");
        }


        public static async Task<bool> ShowDiscounted(string SKU)
        {
            decimal normalPrice, discountPrice = 0;             
            var price = await GetPriceRecord(SKU);               
            if (price != null)
            {
                normalPrice = price.UnitPriceIncludingVat.GetValueOrDefault();
                discountPrice = normalPrice;

                if (price.EndDateSales >= DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
                {
                    discountPrice = normalPrice - (normalPrice * price.DiscountPerc.Value / 100);
                }
                return discountPrice == normalPrice;
            }
            else
            {
                return false;
            }
        }

        public static async Task<string>ReturnDiscountPerc(string SKU)
        {

            var price = await GetPriceRecord(SKU);
           if (price != null)
            {
                var discount = price.DiscountPerc.GetValueOrDefault();
                return discount.ToString();
            }
            return "";
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
                     return cloudinary.Api.UrlImgUp.Transform(new Transformation().Background("#ffffff").Height(400).
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

        private static Task<ItemPrices> GetPriceRecord(string SKU)
        {             
         return Task.Run(() => _prices.Where(p => p.No.StartsWith(SKU.ToUpper())).FirstOrDefault());
        }
    }
}
