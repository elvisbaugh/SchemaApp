// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using SchemaApp;

var data1 = SchemaGenerator.Generate<Person>("New Contract");
var data2 = SchemaGenerator.Generate<Address>("Address Contract");
Console.WriteLine(data1);
Console.WriteLine("\n");
Console.WriteLine(data2);

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public DateTime Created { get; set; }

}

public class Address
{
    public string City { get; set; }
    public string Region { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }
}