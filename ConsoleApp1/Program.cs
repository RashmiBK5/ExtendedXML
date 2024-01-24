// See https://aka.ms/new-console-template for more information
using ExtendedXmlSerializer.Configuration;
using System.Xml.Linq;
using System.Xml;
using ExtendedXmlSerializer;

try
{
    Console.WriteLine("Hello, World!");

    Details det = new Details();
    det.Objects.Add(new DerivedClass() { Property1= "BaseDerivedClass1", Property2= "Property2" });
    det.Objects.Add(new DerivedClass2() { Property1 = "BaseDerivedClass2", Property3 = "Property3" });
    det.Description = "test";


    var serializer = new ConfigurationContainer().Create();
    var xml = serializer.Serialize(det); // Infinite loop


    Console.WriteLine(xml);
    Console.ReadLine();

}
catch(Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.ReadLine();
}