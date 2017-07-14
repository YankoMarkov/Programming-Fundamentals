using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Persons
{
    public string Name { get; set; }
    public string Id { get; set; }
    public int Age { get; set; }
}

class OrderByAge
{
    static void Main(string[] args)
    {
        string inputs = null;
        var persons = AddPersons(inputs);

        persons = persons.OrderBy(x => x.Age).ToList();

        foreach (var item in persons)
        {
            Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
        }
    }

    private static List<Persons> AddPersons(string inputs)
    {
        List<Persons> persons = new List<Persons>();

        while ((inputs = Console.ReadLine()) != "End")
        {
            var input = inputs.Split().ToArray();
            var name = input[0];
            var id = input[1];
            var age = int.Parse(input[2]);

            Persons person = new Persons();
            person.Name = name;
            person.Id = id;
            person.Age = age;
            
            persons.Add(person);
        }
        return persons;
    }
}