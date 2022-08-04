class VanillaSyrup : ToppingDecorator{

    VanillaSyrup(EspressoBeverage newEspBev) : base(newEspBev){
        Console.WriteLine("Adding Vanilla Syrup");

    }
    string getDescription(){
        return tempEspresso.getDescription() + ", Vanilla Syrup";
    }
    double getCost(){
        return tempEspresso.getCost() + 0.80;
    }
}