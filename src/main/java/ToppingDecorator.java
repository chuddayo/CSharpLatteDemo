abstract class ToppingDecorator implements EspressoBeverage{

    protected EspressoBeverage tempEspresso;

    public ToppingDecorator(EspressoBeverage newEspBev){
        tempEspresso = newEspBev;
    }
    public String getDescription() {
        return tempEspresso.getDescription();
    }

    public double getCost() {
        return tempEspresso.getCost();
    }
}
