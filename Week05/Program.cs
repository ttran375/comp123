using System;
using System.IO;
using System.Text.Json;

public class MyClass
{
    public int MyProperty { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass deserializedObject;

        using (FileStream fs = new FileStream("MyFile.json", FileMode.Open))
        {
            deserializedObject = JsonSerializer.DeserializeAsync<MyClass>(fs).Result;
        }

        Console.WriteLine(deserializedObject.MyProperty);
    }
}
