// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using SchemaApp;

var data = SchemaGenerator.Generate<Person>("New Contract");
Console.WriteLine(data);

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public DateTime Created { get; set; }

}