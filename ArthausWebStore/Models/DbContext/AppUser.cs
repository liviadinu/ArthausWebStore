﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models
{
    public class AppUser : IdentityUser
    {
        [Required, StringLength(100)]
         public string FullName { get; set; }
         public int ContactInfoId { get; set; }

    }
}
