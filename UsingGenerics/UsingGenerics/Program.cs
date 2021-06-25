using System;

namespace UsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Range<float> TemeratureRange = new Range<float>(35.2f, 37.5f);
            bool result = TemeratureRange.IsIncluded(36.8f);
            if (result)
            {
                Console.WriteLine("La personne est vivante");
            }
            else
            {
                Console.WriteLine("La personne est morte");
            }
            Range<int> PointRange = new Range<int>(12, 19);
            result = PointRange.IsIncluded(14);
            if (result)
            {
                Console.WriteLine("La personne a réussi l'examen");
            }
            else
            {
                Console.WriteLine("La personne n'a pas réussi l'examen");
            }
        }
    }
}

