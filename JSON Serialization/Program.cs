namespace JSON.Serialization;

public class Program
{
    public static void Main()
    {

        Department department = new("Sales");

        Employee employeeOne = new("Maks");
        department.Add(employeeOne);

        Employee employeeTwo = new("Jhon");
        department.Add(employeeTwo);

        Employee employeeThree = new("Sara");
        department.Add(employeeThree);

    }
}
