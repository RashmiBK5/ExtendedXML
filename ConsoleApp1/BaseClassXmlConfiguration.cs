
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using System.Xml.Linq;

public class BaseClassXmlConfiguration : IXmlConfiguration<BaseClass>
{
    public ITypeConfiguration<BaseClass> Configure(IConfigurationContainer config)
    {
        return config.Type<BaseClass>()
             .Member(s => s.Property1).Ignore()
              .AddMigration(Migration);
    }

    /// <summary>
    /// Remove the error message when deserializing.
    /// </summary>
    /// <param name="element">Element to alter.</param>
    private void Migration(XElement element)
    {
        var errorMessageElement = element.Descendants(nameof(BaseClass.Property1)).FirstOrDefault();
        if (errorMessageElement != null) errorMessageElement.Remove();
    }
}

