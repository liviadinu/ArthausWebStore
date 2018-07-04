using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models.Static
{
    [Flags]
    public enum AttributeType
    {
        Color  = 1,
        Brand = 2,
        Season = 3,
        Division = 4,
        Style = 5
    }
}
