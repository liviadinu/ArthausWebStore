using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models
{
    public class ItemRatings
    {
        public int Id { get; set; }
        public int RatingScore { get; set; }
        public string ItemSKU { get; set; }
        public string Name { get; set; }
        public DateTimeKind ReviewDate { get; set; }
        [Required, StringLength(50)]
        public string Title { get; set; }
        [StringLength(250)]
        public string Message { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
