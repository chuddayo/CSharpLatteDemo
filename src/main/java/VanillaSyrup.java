public class VanillaSyrup extends ToppingDecorator{

    public VanillaSyrup(EspressoBeverage newEspBev) {
        super(newEspBev);
        System.out.println("Adding Vanilla Syrup");

    }
    public String getDescription(){
        return tempEspresso.getDescription() + ", Vanilla Syrup";
    }
    public double getCost(){
        return tempEspresso.getCost() + 0.80;
    }
}
