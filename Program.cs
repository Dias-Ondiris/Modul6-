using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat.Person;
namespace Modul6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constant.SomeString);
            Console.WriteLine(Constant.SomeNumber);
            Person person = new Person("Dias", "Ondiris",new DateTime(2002,10,14),"male","Toregulova 70","Dificonfig@gmail.com","87781076714");
            string personinfo= PersonInfo.GetPersonInfo(person);
            Console.WriteLine(personinfo);
            Console.ReadKey();
        }
    }
}
