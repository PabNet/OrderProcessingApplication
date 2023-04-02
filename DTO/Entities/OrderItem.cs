using System.ComponentModel.DataAnnotations.Schema;
using OrderProcessingApplication.DTO.Entities.Templates;
using static OrderProcessingApplication.DTO.Constants.DataBaseConstantStorage;

namespace OrderProcessingApplication.DTO.Entities
{
    [Table(Tables.OrderItemTableName)]
    public class OrderItem : TemplateOrderEntityWithName
    {
        [Column(Columns.QuantityColumnName, TypeName = Types.DecimalColumnType)]
        public double Quantity { get; set; }
        
        [Column(Columns.UnitColumnName, TypeName = Types.StringColumnType)]
        public string? Unit { get; set; }
        
        [ForeignKey(Columns.OrderIdColumnName)]
        public virtual Order Order { get; set; } = null!;
    }
}