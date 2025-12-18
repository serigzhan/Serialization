namespace Binary_Serialization
{
    internal class Department (string name)
    {

        public string DepartmentName { get; set; } = name;

        public List<Employee> Employees { get; set; } = [
            new Employee("Maks"),
            new Employee("Jhon"),
            new Employee("Sara")
        ];

    }
}
