public class VanillaLatte implements EspressoBeverage{

    @Override
    public String getDescription() {
        return "Steamed Milk";
    }

    @Override
    public double getCost() {
        return 4.45;
    }
}
