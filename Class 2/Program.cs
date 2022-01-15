using System;

    class Car
    {
        public int MaxSpeed;
        public int Doors;
        public int Windows;
        public string CarName;
    };
    class program
    {
        static void Main(string[] args)
        {
            Car SarasCar = new Car();
            SarasCar.CarName = "benny";
            Console.WriteLine(SarasCar.CarName);
            Console.WriteLine(SarasCar);
        }
    }