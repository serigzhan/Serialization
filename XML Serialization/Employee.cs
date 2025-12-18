using System.Xml.Serialization;

namespace XML.Serialization;

[XmlType("Employee")]
public class Employee
{

    [XmlAttribute("name", DataType = "string")]
    public string EmployeeName { get; set; }

    public Employee () { }

    public Employee (string name)
    {

        EmployeeName = name;

    }

}
