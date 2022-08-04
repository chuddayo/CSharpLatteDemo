class Barista {
        static void Main(string[] args) {

        EspressoBeverage latte = new VanillaSyrup(new EspressoShot(new VanillaLatte()));

        Console.WriteLine("Ingredients: " + latte.getDescription());

        Console.WriteLine("Total Cost: " + latte.getCost());

    }
}