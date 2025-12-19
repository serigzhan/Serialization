using System.Runtime.Serialization;

namespace Custom.Serialization;

[Serializable]
public class Person : ISerializable
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Person() { }

    public Person(int id, string name) { Id = id; Name = name; }

    protected Person(SerializationInfo info, StreamingContext context)
    {

        Id = info.GetInt32("custom_id");
        Name = info.GetString("custom_name");

    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {

        info.AddValue("custom_id", Id);
        info.AddValue("custom_name", Name);

    }
}
