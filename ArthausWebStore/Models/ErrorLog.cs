using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models
{
    public partial class ErrorLog
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string ItemSKU { get; set; }
        public string Category { get; set; }
        public string Exception { get; set; }
    }
}
