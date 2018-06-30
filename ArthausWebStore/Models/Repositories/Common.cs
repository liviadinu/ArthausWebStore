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

namespace ArthausWebStore.Models.Repositories
{
    public static class Common

    {
        

        public static async Task LogError(string message,string SKU, string exception)
        {
            using (var context = new ArthuisWebShopContext())
            {
                try
                {
                    var error = new ErrorLog {
                         Category = "Item Price",
                          Exception = exception,
                           ItemSKU = SKU,
                            Message = message
                    };
                    context.ErrorLog.Add(error);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {

                    Console.WriteLine("Unable to save changes. ");
                }
            }

        }
        public static string ReturnAppliedPrice(string SKU, IEnumerable<ItemPrices> priceList)
        {           
            decimal expectedPrice = 0;
            try
            {
                var price = priceList.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
                expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();

                if (price.EndDateSales >= System.DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
                {
                    expectedPrice = expectedPrice - (expectedPrice * price.DiscountPerc.Value / 100);
                }
            }
            catch (NullReferenceException ex)
            {
                expectedPrice = 100;
                var message = "Cannot find Unit Price incl. VAT for this item.";
                var exceptionText = "";// ex.InnerException.ToString();
                Task.Run(() => LogError(message,SKU,exceptionText));
            }

            return expectedPrice.ToString("c");
        }


        public static string ReturnAppliedPrice(string SKU, ItemPrices price)
        {
            decimal expectedPrice = 0;
            try
            {
                expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();

                if (price.EndDateSales >= System.DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
                {
                    expectedPrice = expectedPrice - (expectedPrice * price.DiscountPerc.Value / 100);
                }

            }
            catch (NullReferenceException ex)
            {

                expectedPrice = 100;
                var message = "Cannot find Unit Price incl. VAT for this item.";
                var exceptionText = ex.InnerException.ToString();
                Task.Run(() => LogError(message, SKU, exceptionText));
            }
            return expectedPrice.ToString("c");
        }

        //public static string ReturnAppliedPrice(string SKU)
        //{
        //    using (var context = new ArthuisWebShopContext())
        //    {
        //        var price = context.ItemPrices.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
        //        decimal expectedPrice = 0;
        //        try
        //        {
        //            expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();

        //            if (price.EndDateSales >= System.DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
        //            {
        //                expectedPrice = expectedPrice - (expectedPrice * price.DiscountPerc.Value / 100);
        //            }
        //        }
        //        catch (NullReferenceException ex)
        //        {
        //            expectedPrice = 100;
        //            var message = "Cannot find Unit Price incl. VAT for this item.";
        //            var exceptionText = ex.InnerException.ToString();
        //            Task.Run(() => LogError(message, SKU, exceptionText));
        //        }
        //        return expectedPrice.ToString("c");
        //    }
        //}

        public static string ReturnNormalPrice(string SKU, IEnumerable<ItemPrices> priceList)
        {
            decimal expectedPrice = 100;
            var price = priceList.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
            if (price != null)
            {
                expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();
            }
            else
            {
                var message = "Cannot find Unit Price incl. VAT for this item.";
                var exceptionText = "Return Normal Price from IEnumerable ItemPrices";
                Task.Run(() => LogError(message, SKU, exceptionText));
            }

            return expectedPrice.ToString("c");

        }

        //public static string ReturnNormalPrice(string SKU)
        //{
        //    using (var context = new ArthuisWebShopContext())
        //    {
        //        var price = context.ItemPrices.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
        //        decimal expectedPrice = 100;
        //        if (price != null)
        //        {
        //            expectedPrice = price.UnitPriceIncludingVat.GetValueOrDefault();
        //        }
        //        else
        //        {
        //            var message = "Cannot find Unit Price incl. VAT for this item.";
        //            var exceptionText = "Return Normal Price from string";
        //            Task.Run(() => LogError(message, SKU, exceptionText));
        //        }

        //        return expectedPrice.ToString("c");
        //    }
        //}

        public static bool ShowDiscounted(string SKU, IEnumerable<ItemPrices> prices)
        {
            decimal normalPrice,discountPrice = 0;
            var price = prices.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
            if (price != null)
            {
                normalPrice = price.UnitPriceIncludingVat.GetValueOrDefault();
                discountPrice = normalPrice;

                if (price.EndDateSales >= System.DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
                {
                    discountPrice = normalPrice - (normalPrice * price.DiscountPerc.Value / 100);
                }
                return discountPrice == normalPrice;
            }
            else
            {
                var message = "Cannot find Unit Price incl. VAT for this item.";
                var exceptionText = "Show Discount from IEnumerable ItemPrices";
                Task.Run(() => LogError(message, SKU, exceptionText));
            }
            return false;
        }

        //public static bool ShowDiscounted(string SKU)
        //{
        //    using (var context = new ArthuisWebShopContext())
        //    {
        //        decimal normalPrice, discountPrice = 0;
        //        var price = context.ItemPrices.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
        //        if (price != null)
        //        {
        //            normalPrice = price.UnitPriceIncludingVat.GetValueOrDefault();
        //            discountPrice = normalPrice;

        //            if (price.EndDateSales >= System.DateTime.Today && price.DiscountPerc.Value != 0 && price.DiscountPerc.HasValue)
        //            {
        //                discountPrice = normalPrice - (normalPrice * price.DiscountPerc.Value / 100);
        //            }
        //            return discountPrice == normalPrice;
        //        }
        //        else
        //        {
        //            var message = "Cannot find Unit Price incl. VAT for this item.";
        //            var exceptionText = "Show Discount from SKU string";
        //            Task.Run(() => LogError(message, SKU, exceptionText));
        //        }
        //        return false;
        //    }
        //}

        public static string ReturnDiscountPerc(string SKU, IEnumerable<ItemPrices> priceList)
        {
            var price = priceList.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
            if (price != null)
            {
                var discount = price.DiscountPerc.GetValueOrDefault();
                return discount.ToString();
            }
            else
            {
                var message = "Cannot find Unit Price incl. VAT for this item.";
                var exceptionText = "Return Discount Perc. from IEnumerable ItemPrices";
                Task.Run(() => LogError(message, SKU, exceptionText));
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
    }
}
