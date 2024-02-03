using System;
using System.Runtime.Serialization.Formatters.Binary;
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

        BinaryFormatter formatter = new BinaryFormatter();
        using (Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None))
        {
            formatter.Serialize(stream, objectToSerialize);
        }
    }
}
