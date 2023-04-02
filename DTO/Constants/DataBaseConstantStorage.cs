namespace OrderProcessingApplication.DTO.Constants
{
    public static class DataBaseConstantStorage
    {
        public static class Tables
        {
            public const string OrderTableName = "orders",
                OrderItemTableName = "orderItems",
                ProviderTableName = "providers";
        }
        public static class Columns
        {
            public const string NumberColumnName = "number",
                QuantityColumnName = "quantity",
                UnitColumnName = "unit",
                NameColumnName = "name",
                IdColumnName = "id",
                DateColumnName = "date",
                ProviderIdColumnName = "provider_id",
                OrderIdColumnName = "order_id";
        }

        public static class Types
        {
            public const string StringColumnType = "varchar(100)",
                DecimalColumnType = "numeric(12,5)",
                DateTimeColumnType = "timestamp";
        }
    }
}