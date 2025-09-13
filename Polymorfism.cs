namespace SubmitExercise1
{
    internal class Polymorfism //Denna fil handlar om polymorfism
    {
        public class Animal //Huvudklass Animal
        {
            public string Type; //Attribut som anger typ av djur

            public virtual void Eat() //Metod Eat
            {
                Console.WriteLine("Djur måste äta");
            }
        }
        public class Tiger : Animal //Skapa underklass Tiger till huvudklass Animal.
        {
            public override void Eat() //Metod eat som skriver över huvudklassens eat metod
            {
                Console.WriteLine("Tigrar kan äta");
            }
        }
        public class Lion : Animal //Skapa underklass Lion till huvudklass Animal.
        {
            public override void Eat() //Metod eat som också skriver över huvudklassens eat metod
            {
                Console.WriteLine("Lejon måste också äta!");
            }
        }
    }
}
