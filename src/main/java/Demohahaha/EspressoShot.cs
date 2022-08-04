class EspressoShot : ToppingDecorator{

    EspressoShot(EspressoBeverage newEspBev) : base(newEspBev) {
        Console.WriteLine("Adding Espresso Shot");
        Conso;e.WriteLine("Adding Steamed Milk");
    }
    string getDescription(){
        return tempEspresso.getDescription() + ", Extra Espresso Shot";
    }
    double getCost(){
        return tempEspresso.getCost() + 1.00;
    }

}