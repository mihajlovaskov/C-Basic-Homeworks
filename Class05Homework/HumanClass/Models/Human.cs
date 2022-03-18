namespace HumanClassCreation
{
    public class Human//KOMENTARITE SE ZA MENE - tuka mora public, za da moze da go koristam vo program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human(string firstName, string lastName, int age)//ova e konstruktorot so parametri. ne mora da ima voopsto definirano konstruktor, tuku vo program moze da se povika difolniot konstruktor so Human human = new Human() pa posle se definiraat parametrite
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string GetPersonStats()//ova e baraniot metod. ako ima return togas mora da se definira tipot na return-ot (vo slucajov string). ako nema return togas se odi so void
        {
            return $"{FirstName} {LastName} is {Age} years old.";//tuka nema this kako vo JavaScript.
        }

    }
}
