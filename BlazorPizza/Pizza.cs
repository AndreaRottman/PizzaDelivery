using BlazorPizza.Components.Pages;

namespace BlazorPizza
{
    public class Pizza
    {
        public Topping PizzaTopping { get; set; }
        public Crust PizzaCrust { get; set; }
        public Pizza()
        {
            PizzaTopping = new Topping();
            PizzaCrust = new Crust();

        }
        public double GetFinalPrice()
        {
            return PizzaTopping.ToppingPrice();
        }
        public double GetCrustPrice()
        {
            return PizzaCrust.CrustPrice();
        }
    }
    public class Crust { 
    public bool Thin { get; set; }
    public bool Pan { get; set; }
    public bool Hand { get; set; }
    public double CrustPrice()
    {
        double cTotal = 0;
        if (Thin)
        {
            cTotal += 5.99;
        }
        if (Pan)
        {
            cTotal += 7.99;
        }
        if (Hand)
        {
            cTotal += 6.99;
        }
        
        return cTotal;

    }
}

public class Topping
    {
        public bool Pepperoni { get; set; }
        public bool ExtraCheese { get; set; }
        public bool Ham { get; set; }
        public bool Chicken { get; set; }
        public double ToppingPrice()
        {
            double runningTotal = 0;
            if (Pepperoni)
            {
                runningTotal += 1.50;
            }
            if (ExtraCheese)
            {
                runningTotal += 2.00 ;
            }
            if (Ham)
            {
                runningTotal += 1.79;
            }
            if (Chicken)
            {
                runningTotal += 3;
            }
            return runningTotal;

        }
    }
}
