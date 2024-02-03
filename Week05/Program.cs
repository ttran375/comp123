using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

// Define the object you want to serialize here. For example, a simple class instance.
var objectToSerialize = new MyClass();

BinaryFormatter formatter = new BinaryFormatter();
using (Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None))
{
    formatter.Serialize(stream, objectToSerialize);
}
