using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models.Static
{
    public static class Colors
    {
        public static string GetColorClass(string ColorName)
        {
            switch (ColorName)
            {
                case "white": return "color color-12";
                case "black": return "color color-11";
                case "nude":  return "color color-13";
                case "brown": return "color color-14";
                case "clear": return "color color-18";
                case "multicolor": return "color color-5";
                case "silver": return "color color-10";
                case "orange": return "color color-1";
                case "wood": return "color color-7";
                case "light brown": return "color color-15";
                case "red": return "color color-3";
                case "blue": return "color color-17";
                case "beige": return "color color-16";
                case "electric green": return "color color-9";
                case "deep blue": return "color color-4";
                case "green": return "color color-6";
                case "yellow": return "color color-8";
                case "gold": return "color color-19";
                case "grey": return "color color-20";
                case "dark grey": return "color color-21";
                case "turqoise": return "color color-22";

                default:
                    return "color color-2";
            }
        }
    }
}
