using static Product;
ProductType1 p1 = new ProductType1();
p1.Name = "Product 1";
p1.Price = 15000;
Console.WriteLine(p1.GetDiscount());
