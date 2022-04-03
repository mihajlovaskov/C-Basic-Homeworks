using ClassAnimalLINQ.Enums;
using ClassAnimalLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animals> animals = new List<Animals>()
            {
                new Animals("Elephant", "grey", 7, EnumsForGender.male),
                new Animals("Domestic Cat", "BrOwn", 5, EnumsForGender.female),
                new Animals("Stray Dog", "white", 4, EnumsForGender.male),
                new Animals("Alligator", "black", 3, EnumsForGender.male),
                new Animals("Ant", "red", 12, EnumsForGender.female),
                new Animals("Baboon", "browN", 7, EnumsForGender.male),
                new Animals("arctic Bear", "white", 7, EnumsForGender.male),
                new Animals("Sparrow", "Brown", 1, EnumsForGender.male),
                new Animals("Tiger", "brown", 2, EnumsForGender.male),
                new Animals("Snake", "black", 8, EnumsForGender.female),
            };
            List<string> animalsAgedFiveOrMore = animals.Where(a=>a.Age>=5).Select( an => $"{an.Name}, aged {an.Age}").ToList();
            Console.WriteLine($"I. This is a list of animals aged 5 or more:\n");
            int i = 1;
            foreach (string animal in animalsAgedFiveOrMore)
            {
                Console.WriteLine($"{i++}. {animal}");
            }
            List<string> animalsFirstLetterA = animals.Where(a => a.Name.ToUpper().StartsWith("A")).Select(an => $"{an.Name}").ToList();
            Console.WriteLine($"\nII. This is a list of animals starting with \"A\" - lowercase or uppercase:\n");
            //namerno go napraviv da bide nezavisno dali pocnuva so malo ili golemo A, cisto da isprobam da
            //chain-uvam i ToUpper().
            int k = 1;
            foreach (string animal in animalsFirstLetterA)
            {
                Console.WriteLine($"{k++}. {animal}");
            }
            List<string> animalsMaleAndBrown = animals.Where(a => a.Color.ToLower() == "brown" && a.Gender == EnumsForGender.male).Select(an => $"{an.Name}, {an.Color} {an.Gender}").ToList();
            Console.WriteLine($"\nIII. This is a list of brown male animals:\n");
            int p = 1;
            foreach (string animal in animalsMaleAndBrown)
            {
                Console.WriteLine($"{p++}. {animal}");
            }
            string firstAnimalWithOverTenCharacters = animals.FirstOrDefault(a => a.Name.Length > 10).Name;
            Console.WriteLine($"\nIV. This is the first animal in the object whose name is longer than 10 characters: {firstAnimalWithOverTenCharacters}.");
        }
    }
}
