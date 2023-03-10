using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{    
    //клас MoneyBase слугує базою для валюти та демонструє принцип Liskov
    //ми можемо використовувати дочірні класи MoneyBase і взаємодіяти з ними через цей клас
    public abstract class MoneyBase 
    {
        public int Papers { get; set; }
        public int Coins { get; set; }

        public string Display()
        {
            return $"{Papers}.{Coins} {GetCurrencySymbol()}";
        }

        protected abstract string GetCurrencySymbol();

        private void setMoneyAmount(int papers, int coins)
        {
            Papers = papers + coins / 100;
            Coins = coins % 100;
        }
        public MoneyBase(int papers, int coins)
        {
            setMoneyAmount(papers, coins);
        }

        public decimal GetMoneyValue()
        {
            return (decimal)Papers + (decimal)Coins / 100;
        }
    }

    public class Hryvnia : MoneyBase
    {
        public Hryvnia(int papers, int coins) : base(papers, coins){}

        protected override string GetCurrencySymbol()
        {
            return "UAH";
        }

    }

    public class Dollar : MoneyBase
    {
        public Dollar(int papers, int coins) : base(papers, coins){}

        protected override string GetCurrencySymbol()
        {
            return "USD";
        }
    }

    public class Euro : MoneyBase
    {
        public Euro(int papers, int coins) : base(papers, coins) { }

        protected override string GetCurrencySymbol()
        {
            return "EUR";
        }
    }
}
