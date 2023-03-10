
using ConsoleApp;

Warehouse warehouse = new Warehouse();
IReporter consoleReporter = new ConsoleReporter();
IReporter fileReporter = new FileReporter();
WarehouseManager manager = new WarehouseManager(warehouse, consoleReporter);

manager.AddProduct(new Product("Комп'ютер", "Залізяка", 10, new Dollar(1999, 99)));
manager.AddProduct(new Product("Телевізор", "Ящик, який показує картинки", 15, new Euro(300, 0)));
manager.AddProduct(new Product("Тушонка", "Жестяна банка з окупантом всередині", 150000, new Hryvnia(1, 0)));
manager.AddProduct(new ExpirationProduct(DateTime.Now , "Ковбаса", "Смачна", 100, new Hryvnia(190, 50)));
manager.AddProduct(new ExpirationProduct(DateTime.Now , "Круасан", "Справжній, Француйький!", 100, new Euro(1, 0)));
manager.AddProduct(new ExpirationProduct(DateTime.Now , "Булка з маком", "Маку багато буває", 100, new Hryvnia(30, 0)));

manager.GetTotalProductPrice();
manager.ChangeProductPrice("Комп'ютер", new Hryvnia(80123, 0));
manager.GetTotalProductPrice();
manager.AddProduct(new Product("Комп'ютер", "Залізяка", 2, new Dollar(1999, 99)));
manager.GetProductQuantity("Комп'ютер");
manager.RemoveProduct("Круасан", 10);
manager.GetProductQuantity("Круасан");
manager = new WarehouseManager(warehouse, fileReporter);
manager.GetTotalProductPrice();
manager.ChangeProductPrice("Комп'ютер", new Dollar(2000, 5));
manager.GetTotalProductPrice();
manager.AddProduct(new Product("Комп'ютер", "Залізяка", 2, new Dollar(1999, 99)));
manager.GetProductQuantity("Комп'ютер");
manager.RemoveProduct("Круасан", 10);
manager.GetProductQuantity("Круасан");

Console.ReadKey();