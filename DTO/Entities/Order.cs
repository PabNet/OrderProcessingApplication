using System;
using System.ComponentModel.DataAnnotations.Schema;
using OrderProcessingApplication.DTO.Entities.Templates;
using static OrderProcessingApplication.DTO.Constants.DataBaseConstantStorage;

namespace OrderProcessingApplication.DTO.Entities
{
    [Table(Tables.OrderTableName)]
    public class Order : TemplateOrderEntity
    {
        [Column(Columns.NumberColumnName, TypeName = Types.StringColumnType)]
        public string Number { get; set; } = null!;

        [Column(Columns.DateColumnName, TypeName = Types.DateTimeColumnType)]
        public DateTime Date { get; set; }
        
        [ForeignKey(Columns.ProviderIdColumnName)]
        public virtual Provider? Provider { get; set; }
    }
}