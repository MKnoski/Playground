﻿using System.Collections.Generic;

namespace pg.EntityFramework.Database
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Url { get; set; }

        public IEnumerable<Post> Posts { get; } 
    }
}