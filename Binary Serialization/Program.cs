using System.Runtime.Serialization.Formatters.Binary;

namespace Binary.Serialization;

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


        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream fs = new FileStream("department.bin", FileMode.Create))
        {

            formatter.Serialize(fs, department);

        }

        using (FileStream fs = new FileStream("department.bin", FileMode.Open))
        {

            Department newDepartment = (Department)formatter.Deserialize(fs);

            Console.WriteLine("New department name: {0}", newDepartment.DepartmentName);

        }

        Console.Read();

    }
}

