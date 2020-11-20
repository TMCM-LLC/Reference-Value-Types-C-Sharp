using System;

namespace ReferenceVsValueTypes
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{Name} is a {Type} and weighs {Weight} pounds";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Value types
            Console.WriteLine("Value Types");

            var x = 5;
            var y = x;

            y += 10;
            ChangeNum(x);
            
            Console.WriteLine($"x is: {x}");
            Console.WriteLine($"y is: {y}");
            
            #endregion
            
            #region ReferenceType
            Console.WriteLine("\nReference Types");

            var pet1 = new Pet
            {
                Name = "Fluffy",
                Type = "Dog",
                Weight = 20
            };
            var pet2 = pet1;
            
            var pet3 = new Pet
            {
                Name = pet1.Name,
                Type = pet1.Type,
                Weight = pet1.Weight
            };

            ChangePetType(pet1);
            
            pet2.Name = "Fido";

            Console.WriteLine($"Pet1 is: {pet1}");
            Console.WriteLine($"Pet2 is: {pet2}");
            Console.WriteLine($"Pet3 is: {pet3}");
            
            #endregion
            
            #region Strings

            Console.WriteLine("\nStrings are immutable");

            var a = "cheese";
            var b = "";
            
            b += a;
            b += " pizza";

            Console.WriteLine($"a is: {a}");
            Console.WriteLine($"b is: {b}");
            
            #endregion
        }

        public static void ChangeNum(int num)
        {
            num += 7;
            Console.WriteLine($"num is: {num}");
        }

        public static void ChangePetType(Pet varPet)
        {
            varPet.Type = "Cat";
            varPet = new Pet
            {
                Name = "Spiro",
                Type = "Dragon",
                Weight = 40
            };
            Console.WriteLine($"varPet is: {varPet}");
        }
    }
}