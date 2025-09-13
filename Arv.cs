using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitExercise1
{ //I denna fil ska jag använda klassen arv. Arv är att man ärver/återanvänder attributer och metoder från
    //en annan class.
    public class Car //Huvudklass Car
    {
        public string Brand; //Attribut Brand

        public int Year; //Attribut Year

        public void Drive() //Metod Drive
        {
            Console.WriteLine("A car can go fast");
        }
        public void Brake() //Metod brake
        {
            Console.WriteLine("Cars needs to break to avoid crashing");
        }
    }
    public class Audi : Car //SKapa en subklass av car som heter audi
    {
        public int windows; //Attribut windows
            
        public new void Drive() //Metod Drive
        {
            Console.WriteLine("Audi cars can drive too"); 
        } 
    }

}
