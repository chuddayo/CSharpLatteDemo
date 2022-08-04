abstract class ToppingDecorator : EspressoBeverage{

    protected EspressoBeverage tempEspresso;

    ToppingDecorator(EspressoBeverage newEspBev){
        tempEspresso = newEspBev;
    }
    string getDescription() {
        return tempEspresso.getDescription();
    }

    double getCost() {
        return tempEspresso.getCost();
    }
}