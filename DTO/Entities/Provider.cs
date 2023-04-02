using System.ComponentModel.DataAnnotations.Schema;
using OrderProcessingApplication.DTO.Entities.Templates;
using static OrderProcessingApplication.DTO.Constants.DataBaseConstantStorage;

namespace OrderProcessingApplication.DTO.Entities
{
    [Table(Tables.ProviderTableName)]
    public class Provider : TemplateOrderEntityWithName { }
}