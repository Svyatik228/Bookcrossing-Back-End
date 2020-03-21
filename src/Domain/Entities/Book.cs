﻿using System.Collections.Generic;

namespace Domain.Entities
{
    public class Book : IEntityBase
    { 

        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string Publisher { get; set; }
        public bool Available { get; set; }

        public virtual User User { get; set; }
        public virtual List<BookAuthor> BookAuthor { get; set; } 
        public virtual List<BookGenre> BookGenre { get; set; } 
        public virtual List<Request> Request { get; set; } 
    }
}