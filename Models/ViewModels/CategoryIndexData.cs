﻿using Artene_Teona_Raluca_Lab2.Models;
namespace Artene_Teona_Raluca_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
