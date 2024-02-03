using System;
using System.Xml.Serialization;
using System.IO;

[Serializable]
public class MyClass
{
    public int MyProperty { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Define the object you want to serialize here.
        var objectToSerialize = new MyClass { MyProperty = 123 };

        XmlSerializer serializer = new XmlSerializer(typeof(MyClass));
        using (TextWriter writer = new StreamWriter("MyFile.xml"))
        {
            serializer.Serialize(writer, objectToSerialize);
        }
    }
}
