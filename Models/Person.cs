using System;
using System.Xml.Linq;

namespace Models;
public class Person
{
    //    Yeni bir Models adlı dll yaradırsınız.
    //İçərisində Person classı olur.
    //Personun sıra nömrəsini saxladığımız Id property-si olur,
    //Name,
    //Surname propertyləri,
    //PrintInfo ("Id. Name Surname" çap etsin) metodu olur.

    //Bu Models DLL`i əsas proyektimizə referans verir.
    //Yaranan hər bir obyekt yarandıqdan sonra PrintInfo methodunu işə salın. 
    //Yaranan hər obyekt üçün id property-si avtomatik 1 vahid artsın.

    private static int _instanceCount = 0;
    public int Id { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Person()
    {
        _instanceCount++;
        Id = _instanceCount;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"{Id} {Name} {Surname}");
    }



}

