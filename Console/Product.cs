using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    // цей приклад був створений для того щоб продемонструвати Interface segregation та Liskov принципи
    // принцип Interface segregation полягає в тому, що я створив один базовий інтерфейс для продукту та ще один
    // додатковий для продуктів, які можуть зберігатися до конкретної дати. 
    // принцип Liskov є результатом розділення інтерфейсів, продукти будуть мати тип IProduct у всій програмі, що дозволить
    // узагальнити їх та полегшити роботу при всіляких змінах
    // також тут можна прослідковувати Open/Closed принцип для класів, що імплементують інтерфейс. Їх можна доповнювати 
    // необхідним функціоналом, що не буде змінювати функції базового класу
    public interface IProduct
    {
        string Name { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }
        MoneyBase Price { get; set; }
    }
    public interface IExpirationProduct
    {
        DateTime ExpireDate { get; set; }
    }

    public class Product : IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public MoneyBase Price { get; set; }

        public Product(string name, string description, int quantity, MoneyBase price)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }
    
    public class ExpirationProduct : IExpirationProduct, IProduct
    {        
        public DateTime ExpireDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; } = 1;
        public MoneyBase Price { get; set; }

        public ExpirationProduct(DateTime expireDate, string name, string description, int quantity, MoneyBase price)
        {
            ExpireDate = expireDate;
            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }   

}
