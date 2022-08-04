public abstract class ToppingDecorator : EspressoBeverage{

    protected EspressoBeverage tempEspresso;

    public ToppingDecorator(EspressoBeverage newEspBev){
        tempEspresso = newEspBev;
    }
    public string getDescription() {
        return tempEspresso.getDescription();
    }

    public double getCost() {
        return tempEspresso.getCost();
    }
}