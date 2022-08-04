public class EspressoShot : ToppingDecorator{

    public EspressoShot(EspressoBeverage newEspBev) : base(newEspBev) {
        Console.WriteLine("Adding Espresso Shot");
        Console.WriteLine("Adding Steamed Milk");
    }
    new public string getDescription(){
        return tempEspresso.getDescription() + ", Extra Espresso Shot";
    }
    new public double getCost(){
        return tempEspresso.getCost() + 1.00;
    }

}