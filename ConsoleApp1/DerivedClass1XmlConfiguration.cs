
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

public class DerivedClass1XmlConfiguration : IXmlConfiguration<DerivedClass>
{
    public ITypeConfiguration<DerivedClass> Configure(IConfigurationContainer config)
    {
        return config.Type<DerivedClass>();
    }
}

