namespace SubmitExercise1
{
    public class Customer //Klass customer
    {
        //Privat attribut som döljs för app och andra kunder genom "private".
        //Åtkomst sker endast genom public metod och public attribut

        private string name;

        //Validering som just nu är utan villkor vilket gör att all data går igenom.
        public string Name  //Public metod för åtkomst till privat attribut
        {
            get { return name; }
            set { name = value; } //Värdet för name ersätter value, dvs value = namnet
        }
        
        public string Manager(string name) //Konstruktor - attribut måste anges när ett obejkt av klassen
        {                             //Customer skapas. Attribut här är string name
            this.name = name;
            return name;
            
        }
        public void Employee() //Employee metoden som skriver ut "name" när den anropas.
        {
            Console.WriteLine($"Namnet på den anställde är: {name}");
        }
        
       
    }
}
