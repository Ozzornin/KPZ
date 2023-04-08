using Facade.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Misc
{
    public class Box
    {

        public Burger Burger;
        public Cola Cola;
        public Potatoes Potatoes;
        public Napkins Napkins;
        public Price Price;

        public Box(Burger burger, Cola cola, Potatoes potatoes, Price price, Napkins napkins)
        {
            Burger = burger;
            Cola = cola;    
            Potatoes = potatoes;
            Price = price;
            Napkins = napkins;
        }

        public override string ToString()
        {
            return $"Your order contains: {Burger.Name}, {Cola.Name} {Cola.GetVolume()}ml, {Potatoes.Name} " +
                $"{Potatoes.GetWeight()}g, napkins({Napkins.Count}pcs).\nPrice: {Price.Amount} {Price.Currency}";
        }


    }
}
