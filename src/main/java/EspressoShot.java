public class EspressoShot extends ToppingDecorator{

    public EspressoShot(EspressoBeverage newEspBev) {
        super(newEspBev);
        System.out.println("Adding Espresso Shot");
        System.out.println("Adding Steamed Milk");
    }
    public String getDescription(){
        return tempEspresso.getDescription() + ", Extra Espresso Shot";
    }
    public double getCost(){
        return tempEspresso.getCost() + 1.00;
    }

}
