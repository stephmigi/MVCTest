using System;
using System.Collections.Generic;

namespace ObjectModel
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class Category
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Category(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public Category()
        {
            Id = 0;
            Title = String.Empty;
            Description = String.Empty;
        }

        public static List<Category> GetFakeCategoryList()
        {
            return new List<Category>
                              {
                                  new Category(1, "Piscine", "Ceci est la catégorie piscine"),
                                  new Category(2, "Plomberie", "Ceci est la catégorie plomberie"),
                                  new Category(3, "Electricité", "Ceci est la catégorie électricité")
                              };
        }

        public List<SubCategory> GetSubCategories()
        {
            return SubCategory.GetAllSubCategories().Where(p => p.Parent.Id == this.Id).ToList();
        }
    }
}
