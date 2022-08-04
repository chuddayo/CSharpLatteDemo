public class VanillaSyrup : ToppingDecorator{

    public VanillaSyrup(EspressoBeverage newEspBev) : base(newEspBev){
        Console.WriteLine("Adding Vanilla Syrup");

    }
    new public string getDescription(){
        return tempEspresso.getDescription() + ", Vanilla Syrup";
    }
    new public double getCost(){
        return tempEspresso.getCost() + 0.80;
    }
}