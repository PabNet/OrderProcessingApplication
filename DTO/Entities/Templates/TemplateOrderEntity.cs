using System.ComponentModel.DataAnnotations.Schema;
using static OrderProcessingApplication.DTO.Constants.DataBaseConstantStorage;

namespace OrderProcessingApplication.DTO.Entities.Templates
{
    public class TemplateOrderEntity
    {
        [Column(Columns.IdColumnName)]
        public uint Id { get; set; }
    }
}