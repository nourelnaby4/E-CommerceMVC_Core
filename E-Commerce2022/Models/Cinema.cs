﻿using System.Collections.Generic;

namespace E_Commerce2022.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
