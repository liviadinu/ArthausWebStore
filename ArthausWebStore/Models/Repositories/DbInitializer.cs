using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models.Repositories
{
    public class DbInitializer
    {
        public static void Seed(ArthuisWebShopContext context)
        {
            if (!context.Item.Any())
            {
                context.AddRange();
                context.SaveChanges();
            }
        }
    }
}
