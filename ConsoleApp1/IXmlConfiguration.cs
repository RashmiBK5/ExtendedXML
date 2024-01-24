using ExtendedXmlSerializer.Configuration;

internal interface IXmlConfiguration<TEntity> where TEntity : notnull
{
       public ITypeConfiguration<TEntity> Configure(IConfigurationContainer config);
}

