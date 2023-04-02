using System;

namespace OrderProcessingApplication.DTO.Extensions
{
    public static class Enums
    {
        public static T ToEnum<T>(this uint value)
        {
            return (T) Enum.ToObject(typeof(T), value);
        }
    }
}