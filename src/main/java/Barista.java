public class Barista {

    public static void main(String[] args) {

        EspressoBeverage latte = new VanillaSyrup(new EspressoShot(new VanillaLatte()));

        System.out.println("Ingredients: " + latte.getDescription());

        System.out.println("Total Cost: " + latte.getCost());

    }
}
