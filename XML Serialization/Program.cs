using System.Xml.Serialization;
using XML.Serialization;

public class Program
{
    static void Main()
    {

        Department department = new("Sales");

        Employee employeeOne = new("Maks");
        department.Add(employeeOne);

        Employee employeeTwo = new("Jhon");
        department.Add(employeeTwo);

        Employee employeeThree = new("Sara");
        department.Add(employeeThree);

        XmlSerializer serializer = new XmlSerializer(typeof(Department));

        using (StreamWriter writer = new StreamWriter("department.xml"))
        {

            serializer.Serialize(writer, department);
            Console.WriteLine("Department serialized to XML successfully.");

        }

        using (FileStream reader = new FileStream("department.xml", FileMode.Open))
        {

            Department newDepartment = (Department)serializer.Deserialize(reader);

            Console.WriteLine("New department name: {0}", newDepartment.DepartmentName);

        }

        Console.ReadLine();

    }
}
