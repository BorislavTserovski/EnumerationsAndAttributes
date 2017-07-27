using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CoffeeMachine
{
    public List<CoffeeType> CoffeesSold { get; }
    public int Coins { get; set; }
    public CoffeeMachine()
    {
        this.CoffeesSold = new List<CoffeeType>();
    }
    public void BuyCoffee(string price, string type)
    {
        CoffeeType coffeeType = (CoffeeType) Enum.Parse(typeof(CoffeeType), type);
        CoffeePrice coffeePrice = (CoffeePrice) Enum.Parse(typeof(CoffeePrice), price);

        if (this.Coins>=(int)coffeePrice)
        {
            this.CoffeesSold.Add(coffeeType);
            this.Coins = 0;
        }
    }
    public void InsertCoin(string coin)
    {
        Coin toRemove = (Coin) Enum.Parse(typeof(Coin), coin);
        this.Coins += (int) toRemove;
    }
}

