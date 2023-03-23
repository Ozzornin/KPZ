
using Singleton;

Console.WriteLine("Hello, World!");

DatabaseRepository db = DatabaseRepository.GetInstance;

db.DBConnect();

int res = db.getSomethingFromDb();
Console.WriteLine(res);
Console.ReadLine();