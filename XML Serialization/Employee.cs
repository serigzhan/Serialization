using System.Xml.Serialization;

namespace XML.Serialization;

[Serializable]
public class Employee
{

    [XmlAttribute("name")]
    string EmployeeName { get; set; }

    public Employee () { }

    public Employee (string name)
    {

        EmployeeName = name;

    }

}
