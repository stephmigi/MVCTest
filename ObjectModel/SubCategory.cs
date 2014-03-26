using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{

    public class SubCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Category Parent { get; set; }

        public SubCategory()
        {
            
        }

        public SubCategory(int id, string title, Category parent)
        {
            this.Id = id;
            this.Title = title;
            this.Parent = parent;
        }

        //private Category GetParentCategory()
        //{
        //    if (this.Id >= 1 && this.Id <= 3)
        //        return Category.GetFakeCategoryList().FirstOrDefault(p => p.Id == 1);

        //    if (this.Id >= 4 && this.Id <= 6)
        //        return Category.GetFakeCategoryList().FirstOrDefault(p => p.Id == 2);

        //    if (this.Id >= 7 && this.Id <= 9)
        //        return Category.GetFakeCategoryList().FirstOrDefault(p => p.Id == 3);
        //    throw new Exception();
        //}

        public static List<SubCategory> GetAllSubCategories()
        {
            var subCatList = new List<SubCategory>();

            var catList = Category.GetFakeCategoryList();
            var p1 = catList.ElementAt(0);
            var p2 = catList.ElementAt(1);
            var p3 = catList.ElementAt(2);

            subCatList.Add(new SubCategory(1, "Carrelage", p1));
            subCatList.Add(new SubCategory(2, "Robots", p1));
            subCatList.Add(new SubCategory(3, "Entretien", p1));

            subCatList.Add(new SubCategory(4, "Fuites", p2));
            subCatList.Add(new SubCategory(5, "Chauffe eau", p2));
            subCatList.Add(new SubCategory(6, "Sanitaires", p2));

            subCatList.Add(new SubCategory(7, "Fusibles", p3));
            subCatList.Add(new SubCategory(8, "Cablages", p3));
            subCatList.Add(new SubCategory(9, "Compteurs", p3));

            return subCatList;
        }
    }
}
