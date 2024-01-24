
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using System.Xml;

internal class XmlSerializer
{

    IExtendedXmlSerializer serializer;

    private readonly XmlWriterSettings settings;


    public XmlSerializer()
    {

        serializer = ConfigureSerializerWithAllConfigs()
            .EnableParameterizedContentWithPropertyAssignments()
            .UseOptimizedNamespaces()
            .Create();


        settings = new XmlWriterSettings
        {
            Indent = true,
        };
    }

    private IConfigurationContainer ConfigureSerializerWithAllConfigs()
    {
        // Add all the configurations
        IConfigurationContainer configContainer = new ConfigurationContainer();


        configContainer = new BaseClassXmlConfiguration().Configure(configContainer);
        configContainer = new DerivedClass1XmlConfiguration().Configure(configContainer);
        configContainer = new DerivedClass2XmlConfiguration().Configure(configContainer);

        return configContainer;

    }


    public void Serialize(Details entity)
    {
        serializer.Serialize(settings, entity);
    }
}

