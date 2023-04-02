namespace OrderProcessingApplication.DTO.Constants
{
    public static class ViewConstantStorage
    {
        public const string ConfigurationFileName = "appsettings.json";

        public static class Pages
        {
            public const string Orders = "/orders",
                OrderItems = "/orderItems",
                Providers = "/providers",
                OrderForm = "/orderForm",
                OrderItemForm = "/orderItemForm",
                ProviderForm = "/providerForm",
                Home = "/";
        }

        public static class JsMethods
        {
            public const string InitializeDataTable = "initializeDataTable",
                InitializeSidebar = "initializeSidebar",
                InitializeDateTimePickers = "initializeDateTimePickers",
                InitializeMultipleSelect = "initializeMultipleSelect",
                InitializeChart = "initializeChart",
                ShowModal = "showModal",
                HideModal = "hideModal";
        }

        public static class BrowserStorageParameterKeys
        {
            public const string Title = "title",
                NameList = "nameList",
                FormPageName = "formPageName";
        }

        public static class PageParts
        {
            public const string AddEvent = "Add",
                UpdateEvent = "Update",
                AddTitle = "Adding new {0}",
                UpdateTitle = "Updating {0}",
                ProviderPartOfTitle = "provider",
                OrderItemPartOfTitle = "item{0} in order №{1}",
                OrderPartOfTitle = "order",
                UnknownErrorTitle = "Unknown error",
                CountOfOrdersWithoutProviderTitle = "Without provider";
        }

        public static class Parameters
        {
            public const string Id = "id",
                OrderId = "orderId";
        }

        public static class Replicas
        {
            public const string DataBaseErrorTitle = "There was a problem accessing the database",
                JsErrorTitle = "There was a problem using the client code",
                BrowserStorageErrorTitle = "There was a problem accessing browser storage",
                RuntimeErrorTitle = "There was a problem running the program",
                OrderItemErrorDescription = "The name of the order item cannot be equal to the order number. Try again",
                OrderErrorDescription = "There cannot be more than one order in the system with the same order number and provider. Try again",
                OrderDeletionErrorDescription = "Unable to delete an order that has order items",
                NotFoundSubtitle = "Can't find the page at the given address",
                UnknownErrorSubtitle = "An unknown error occurred while executing the program";
        }
    }
}