// See https://aka.ms/new-console-template for more information
using ExtendedXmlSerializer.Configuration;
using ExtendedXmlSerializer;

try
{
    Console.WriteLine("Hello, World!");

    Details det = new Details();
    det.Objects.Add(new DerivedClass() { Property1 = "BaseDerivedClass1", Property2 = "Property2" });
    det.Objects.Add(new DerivedClass2() { Property1 = "BaseDerivedClass2", Property3 = "Property3" });
    det.Description = "test";

    // Add all the configurations
    IConfigurationContainer configContainer = new ConfigurationContainer();


    //var serializer = new XmlSerializer();
    configContainer = new BaseClassXmlConfiguration().Configure(configContainer);
    configContainer = new DerivedClass1XmlConfiguration().Configure(configContainer);
    configContainer = new DerivedClass2XmlConfiguration().Configure(configContainer);

    var serializer = configContainer.Create();
    var xml = serializer.Serialize(det); // Infinite loop


    Console.WriteLine(xml);
    Console.ReadLine();

}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.ReadLine();
}

// version 3.2.3
//<? xml version = "1.0" encoding = "utf-8" ?>
//< Details xmlns = "clr-namespace:;assembly=ConsoleApp1" >
//   < Description > test </ Description >
//   < Objects xmlns: sys = "https://extendedxmlserializer.github.io/system" xmlns: exs = "https://extendedxmlserializer.github.io/v2" exs: type = "sys:List[BaseClass]" >
//       < Capacity > 4 </ Capacity >
//       < DerivedClass >
//           < IsSelected > false </ IsSelected >
//           < Property2 > Property2 </ Property2 >
//       </ DerivedClass >
//       < DerivedClass2 >
//           < IsSelected > false </ IsSelected >
//           < Property3 > Property3 </ Property3 >
//       </ DerivedClass2 >
//   </ Objects >
//</ Details >

//veriosn 3.2.7
//<? xml version = "1.0" encoding = "utf-8" ?>
//< Details xmlns = "clr-namespace:;assembly=ConsoleApp1" >
//   < Description > test </ Description >
//   < Objects xmlns: sys = "https://extendedxmlserializer.github.io/system" xmlns: exs = "https://extendedxmlserializer.github.io/v2" exs: type = "sys:List[BaseClass]" >
//       < Capacity > 4 </ Capacity >
//       < DerivedClass >
//           < Property1 > BaseDerivedClass1 </ Property1 >
//           < IsSelected > false </ IsSelected >
//           < Property2 > Property2 </ Property2 >
//       </ DerivedClass >
//       < DerivedClass2 >
//           < Property1 > BaseDerivedClass2 </ Property1 >
//           < IsSelected > false </ IsSelected >
//           < Property3 > Property3 </ Property3 >
//       </ DerivedClass2 >
//   </ Objects >
//</ Details >