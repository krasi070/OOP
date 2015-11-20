using System;

class BarkingDogs
{
    static void Main()
    {
        Dog sharo = new Dog("Sharo", "German Shepherd");
        Dog mysteryDog = new Dog();
        Dog lesserDog = new Dog("Lesser Dog", null);
        sharo.Bark();
        mysteryDog.Bark();
        lesserDog.Bark();
    }
}

