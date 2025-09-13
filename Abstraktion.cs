namespace SubmitExercise1
{
    //Huvudklass abstrakt, subklass måste override huvudklassens metod.
    public abstract class House //Huvudklass House
    {
        public abstract void Door(); //Abstrakt metod Door
    }
    //Subklass
    public class Shed : House //Skapa underklass Shed av huvudklass House
    {
        public override void Door() //Override metod Door
        {
            Console.WriteLine("Door opens");
        }
    }
}   
