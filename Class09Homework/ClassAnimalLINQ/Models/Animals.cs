using ClassAnimalLINQ.Enums;
namespace ClassAnimalLINQ.Models
{
    public class Animals
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public EnumsForGender Gender { get; set; }

        public Animals(string name, string color, int age, EnumsForGender gender) 
        {
            Name = name;
            Color = color;
            Age = age;
            Gender = gender;
        } 
    }
}
