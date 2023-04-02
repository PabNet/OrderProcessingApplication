using System.ComponentModel.DataAnnotations.Schema;
using static OrderProcessingApplication.DTO.Constants.DataBaseConstantStorage;

namespace OrderProcessingApplication.DTO.Entities.Templates
{
    public class TemplateOrderEntityWithName : TemplateOrderEntity
    {
        [Column(Columns.NameColumnName, TypeName = Types.StringColumnType)]
        public string Name { get; set; } = null!;
    }
}