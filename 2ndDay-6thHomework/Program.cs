using System;

namespace _2ndDay_6thHomework
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 1;
            product1.productName = "Matematik Kitabı";
            product1.productCategory = "Kitap";
            product1.productCategoryId = 1;

            Product product2 = new Product();
            product2.productId = 2;
            product2.productName = "Tükenmez Kalem";
            product2.productCategory = "Kalem";
            product2.productCategoryId = 2;

            Product product3 = new Product();
            product2.productId = 3;
            product2.productName = "İngilizce Sözlük";
            product2.productCategory = "Sözlük";
            product2.productCategoryId = 3;

            Product[] product = new Product[] { product1, product2, product3 };

            Console.WriteLine("Foreach döngüsü:");

            Console.WriteLine("         ");

            foreach (var pro in product)
            {
                Console.WriteLine("Ürün Id" + " :" + pro.productId);
                Console.WriteLine("Ürün Adı" + ":" + pro.productName);
                Console.WriteLine("Ürün Kategorisi" + ":" + pro.productCategory);
                Console.WriteLine("Ürün Kategori Id" + ":" + pro.productCategoryId);

            }

            Console.WriteLine("         ");
            Console.WriteLine("For Döngüsü");
            Console.WriteLine("         ");

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine("Ürün Id" + " :" + product[i].productId);
                Console.WriteLine("Ürün Adı" + ":" + product[i].productName);
                Console.WriteLine("Ürün Kategorisi" + ":" + product[i].productCategory);
                Console.WriteLine("Ürün Kategori Id" + ":" + product[i].productCategoryId);
            }

            Console.WriteLine("         ");
            Console.WriteLine("While::");
            Console.WriteLine("         ");

            int k = 0;
            while (k < product.Length)
            {

                Console.WriteLine("Ürün Id" + " :" + product[k].productId);
                Console.WriteLine("Ürün Adı" + ":" + product[k].productName);
                Console.WriteLine("Ürün Kategorisi" + ":" + product[k].productCategory);
                Console.WriteLine("Ürün Kategori Id" + ":" + product[k].productCategoryId);

                k++;
            }

        }

        public class Product
        {
            public int productId { get; set; }
            public string productName { get; set; }
            public string productCategory { get; set; }
            public int productCategoryId { get; set; }
        }
    }
}
