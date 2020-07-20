using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int BasicCategoryId { get; set; }

        public static CategoryDTO ConvertToDTO(Category c)
        {
            CategoryDTO cd = new CategoryDTO();
            cd.CategoryId = c.CategoryId;
            cd.CategoryName = c.CategoryName;
            cd.BasicCategoryId = c.BasicCategoryId;
            return cd;
        }

        public static Category ConvertFromDTO(CategoryDTO cd)
        {
            Category c = new Category();
            c.CategoryId = cd.CategoryId;
            c.CategoryName = cd.CategoryName;
            c.BasicCategoryId = cd.BasicCategoryId;
            return c;
        }

        public static List<CategoryDTO> ConvertToListOfDTO(List<Category> lc)
        {
            List<CategoryDTO> lcd = new List<CategoryDTO>();
            for (int i = 0; i < lc.LongCount(); i++)
            {
                CategoryDTO cd = new CategoryDTO();
                cd.CategoryId = lc[i].CategoryId;
                cd.CategoryName = lc[i].CategoryName;
                cd.BasicCategoryId = lc[i].BasicCategoryId;
                lcd.Add(cd);
            }
            return lcd;
        }

        public static List<Category> ConvertToListFromDTO(List<CategoryDTO> lcd)
        {
            List<Category> lc = new List<Category>();
            for (int i = 0; i < lcd.LongCount(); i++)
            {
                Category c = new Category();
                c.CategoryId = lcd[i].CategoryId;
                c.CategoryName = lcd[i].CategoryName;
                c.BasicCategoryId = lcd[i].BasicCategoryId;
                lc.Add(c);
            }
            return lc;
        }
    }
}
