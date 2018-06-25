using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemPicture
    {
        public byte[] Timestamp { get; set; }
        public string ItemNo { get; set; }
        public string WebsiteNo { get; set; }
        public byte[] Picture { get; set; }
        public int Id { get; set; }
        public bool GridThumbnail { get; set; }
        public bool QuickView { get; set; }
    }
}
