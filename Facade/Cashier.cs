using Facade.Dishes;
using Facade.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //I needed to create some logic so that the order wouldn't appear out of nowhere,
    //so the cashier will act as a decorator who collects all the items and products in a box
    public class Cashier
    {
        public Box OrderBigmacMenu()
        {
            Burger burger = new Burger("BigMac", 200);
            Cola cola = new Cola(400);
            Potatoes potatoes = new Potatoes(300);
            Napkins napkins = new Napkins(5);
            Price price = new Price("UAH", 150.4);
            Box order = new Box(burger, cola, potatoes, price, napkins);
            return order;
        }
    }
}
