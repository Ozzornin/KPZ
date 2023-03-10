using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{  
    // клас Warehouse є просто складом
    public class Warehouse
    {
        public List<IProduct> products = new List<IProduct>();             
    }

    // клас WarehouseManager демонструє принцип Single Responsibility та працює лише з продуктами, які є на складі
    // він використовує об'єкт класу, що імплементує інтерфейс IReporter. Це було необхідно для демонстрації 
    // dependency inversion принципа
    public class WarehouseManager
    {
        private Warehouse _warehouse;
        private IReporter _reporter;
        
        public WarehouseManager(Warehouse warehouse, IReporter reporter)
        {
            _warehouse = warehouse;
            _reporter = reporter;
        }
        public void AddProduct(IProduct product)
        {
            int index = getProductIndex(product.Name);
            if(index>-1)
            {
                updateProductQuantity(index, product.Quantity);
            }
            else
            {
                _warehouse.products.Add(product);
            }            
        }

        public void GetProductQuantity(string name)
        {
            int index = getProductIndex(name);
            _reporter.Report(index > -1 ?
                $"Quantity of {name} is {_warehouse.products[index].Quantity}" :
                $"There is no such product as {name} in warehouse!"
                );
        }

        public void RemoveProduct(string name, int quantity)
        {
            int index = getProductIndex(name);
            if (index > -1)
            {
                updateProductQuantity(index, -quantity);
            }
            else
            {
                _reporter.Report("This product is out of stock!");
            }            
        }

        public void GetTotalProductPrice()
        {
            if (_warehouse.products.Count < 1) return;
            decimal uah=0, usd=0, eur=0;
            foreach(IProduct product in _warehouse.products) 
            {
                if (product.Price is Hryvnia)
                    uah += product.Price.GetMoneyValue();
                if (product.Price is Dollar)
                    usd += product.Price.GetMoneyValue();
                if (product.Price is Euro)
                    eur += product.Price.GetMoneyValue();
            }
            _reporter.Report($"Total price of products in warehouse is {uah} UAH + {usd} USD + {eur} EUR");
        }

        private int getProductIndex(string name)
        {
            for(int i = 0; i< _warehouse.products.Count; i++)
            {
                if (_warehouse.products[i].Name == name)
                    return i;
            }
            return -1;
        }
        public void ChangeProductPrice(string name, MoneyBase price)
        {
            int index = getProductIndex(name);
            if (index > -1)
            {
                _warehouse.products[index].Price = price;
                _reporter.Report($"The price of {name} is {price.Display()}");
            }
            else
                _reporter.Report($"Cannot find {name} in warehouse");
        }
        private void updateProductQuantity(int index, int quantity)
        {
            IProduct product = _warehouse.products[index];
            int prodQuantity = product.Quantity + quantity;
            if (prodQuantity > 0) 
            {
                string total = $"[total q: {prodQuantity}]";
                _reporter.Report(prodQuantity > product.Quantity?
                    $"Product {product.Name} has been added in quantity {quantity}. " + total :
                    $"Product {product.Name} has been removed from warehouse. " + total);
                product.Quantity = prodQuantity;
            }
            else
            { 
                _warehouse.products.Remove(product);
                _reporter.Report($"Product {product.Name} removed from warehouse");
            }
        }
    }
}
