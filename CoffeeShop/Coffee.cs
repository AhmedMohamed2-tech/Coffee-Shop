namespace CoffeeShop
{
    
    public enum BeanType
    {
        Arabica,
        Robusta,
        Liberica,
        Excelsa
    }

     public enum RoastLevel
    {
        Light,
        Medium,
        Dark
    }
     public enum SugarType
    {
        White,
        Brown,
        Caster,
        Confectioners,
    }
    public enum SugarLvl
    {
        one,
        two,
        three,
        four,
        five     
    }
    public enum CoffeeType
    {
        Latte,
        Cappuccino,
        Mocha,
        Macchiato,
        Espresso,
        Americano,
        Frappuccino
    }
    public class Coffee : Beverage
    {
        public SugarType SugarType { get; set; }
        public SugarLvl SugarLvl { get; set; }
        public CoffeeType CoffeeType { get; set; }
        public BeanType BeanType { get; set; }
        public RoastLevel RoastLevel { get; set; }
    }
}
