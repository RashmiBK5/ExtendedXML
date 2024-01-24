
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

public class DerivedClass2XmlConfiguration : IXmlConfiguration<DerivedClass2>
{
    public ITypeConfiguration<DerivedClass2> Configure(IConfigurationContainer config)
    {
        return config.Type<DerivedClass2>();
    }
}

