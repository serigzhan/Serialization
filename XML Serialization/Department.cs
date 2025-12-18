using System.Xml.Serialization;

namespace XML.Serialization;

[Serializable]
public class Department
{

    [XmlAttribute("name")]
    public string DepartmentName { get; set; }

    [XmlArray("Employees")]
    public List<Employee> Employees { get; set; } = [];

    public Department () { }

    public Department (string name)
    {

        DepartmentName = name;

    }

    public void Add(Employee employee)
    {

        Employees.Add(employee);

    }

}
