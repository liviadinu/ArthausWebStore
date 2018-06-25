using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models.Interface
{
    public interface IProductsGrid : ISkuItemsList
    {
        IEnumerable<ItemPicture> GetAllPictures();
    }
}
