﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDll.Entities
{
    public class Genre : AbstractEntity
    {
        public string Name { get; set; }
        public virtual List<Movie> Movies { get; set; }

    }
}
