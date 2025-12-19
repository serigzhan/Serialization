using System.Runtime.Serialization.Formatters.Binary;

namespace Custom.Serialization;

public class Program
{
    public static void Main()
    {

        Person person = new Person(1, "Mike");

        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream fs = new FileStream("person.bin", FileMode.Create))
        {

            formatter.Serialize(fs, person);

        }

        using (FileStream fs = new FileStream("person.bin", FileMode.Open))
        {

            Person newPerson = (Person)formatter.Deserialize(fs);

            Console.WriteLine("New person info: {0}: {1}", newPerson.Id, newPerson.Name);

        }

        Console.Read();

    }
}
