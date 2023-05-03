using Product;

Produto produto1 = new Produto();

produto1.InStock = 0;
produto1.Price = 80;
double price = produto1.CalculateDiscount(15);
Console.WriteLine(produto1.Price);
Console.WriteLine(price);
produto1.AddToStock(5);
produto1.CalculateDiscount(0.10);
Console.WriteLine(produto1.AddToStock);
Console.WriteLine(produto1.CalculateDiscount);
