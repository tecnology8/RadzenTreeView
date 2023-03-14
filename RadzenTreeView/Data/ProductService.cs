namespace RadzenTreeView.Data
{
    public class ProductService
    {
        List<Category> categories = new List<Category>()
        {
            new Category{CategoryID = 1, CategoryName ="Category-1"},
            new Category{CategoryID = 2, CategoryName ="Category-2"},
            new Category{CategoryID = 3, CategoryName ="Category-3"},
        };

        List<Product> products = new List<Product>() { 
            new Product { ProductID = 1, CategoryID = 1, ProductName = "Keyboard", Price = 45009 }, 
            new Product { ProductID = 2, CategoryID = 1, ProductName = "Laptop", Price = 45009 }, 
            new Product { ProductID = 3, CategoryID = 2, ProductName = "Mouse", Price = 45009 }, 
            new Product { ProductID = 4, CategoryID = 2, ProductName = "Computer", Price = 45009 }, 
            new Product { ProductID = 5, CategoryID = 3, ProductName = "Speaker", Price = 45009 }, 
            new Product { ProductID = 6, CategoryID = 3, ProductName = "Pendrive", Price = 45009 }, 
            new Product { ProductID = 7, CategoryID = 3, ProductName = "Pendrive", Price = 45009 }, 
        };

        public async Task<List<Category>> CategoryList()
        {
            var categoryList = new List<Category>();
            foreach (var cat in categories)
            {
                cat.Products = products.Where(t=>t.CategoryID == cat.CategoryID).ToList();
                categoryList.Add(cat);
            }
            return await Task.FromResult(categoryList);
        }
    }
}
