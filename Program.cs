using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

//Her er linkene  til TK-undervisning i morgen :)
//[console-basics-cs] (https://github.com/krigjo25/console-basics-cs),
//[Console - game - cs](https://github.com/krigjo25/console-games-cs),
//[console - objects - cs](https://github.com/krigjo25/console-objects-cs)
namespace initializing_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person @bjarte = new Person();
            @bjarte.SetName("Bjarte");
            @bjarte.GenerateBirthday(5);
            @bjarte.GenerateHobbies();
            Console.WriteLine($"Objekt {@bjarte.Name}\nNavn : {bjarte.Name}\n Age: {bjarte.Birthdate} ");
            Thread.Sleep(10000);
            // Run program
        }
    }
}
