using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.AuthHelpers
{
    public class WebShopClaimTypes
    {
        public static List<string> ClaimsList { get; set; } = new List<string> { "Delete Product", "Delete Customer",
            "Add Service","Delete Service", "Delete Prices" };

    }
}
