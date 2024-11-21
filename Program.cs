using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace initializing_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person @bjarte = new Person();
            @bjarte.SetName("Bjarte");
            @bjarte.GenerateBirthday(5);
            @bjarte.GenerateHobbies("Coding");
            Console.WriteLine($"Objekt {@bjarte.Name}\nNavn : {bjarte.Name}\n Age: {bjarte.Birthdate}\n Hobbies: {bjarte.Hobbies}  ");
            Thread.Sleep(10000);
            // Run program
        }
    }
}
