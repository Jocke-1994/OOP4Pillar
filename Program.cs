using static SubmitExercise1.Polymorfism;

namespace SubmitExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arv
            Car car1 = new Car();
            car1.Drive();

            Audi series5 = new Audi();
            series5.Drive();

            //Polymorfism

            Animal animal1 = new Animal(); //Från animal klassen skapas objekt animal1 och sen körs Eat metoden genom animal1/animal
            animal1.Eat();

            Tiger animal2 = new Tiger(); //Subklassen ärver/override Eat metoden och deklarerar egen Eat metod
            animal2.Eat();

            Lion animal3 = new Lion(); //Subklassen ärver/override Eat metoden och deklarerar egen Eat metod
            animal3.Eat();

            //Inkapsling

            Customer customerVIP = new Customer();
            customerVIP.Manager("Karl"); //Hämta namnet karl i metoden Manager
            customerVIP.Employee(); //Skriv ut namnet Karl genom metoden Employee.
            

            //Abstraktion

            Shed shed = new Shed();
            shed.Door();

        }
    }
}
