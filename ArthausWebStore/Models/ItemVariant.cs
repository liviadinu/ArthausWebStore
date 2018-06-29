using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models
{
    public partial class ItemVariant
    {
        public int Id { get; set; }
        public string ItemNo { get; set; }
        public string ItemDescription { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
    }
}
