using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilGenerator.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class AlsoNotifyAttribute : Attribute
    {
        public string PropertyName { get; }

        public AlsoNotifyAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }

        public static string GetPropertyName(string attributeDeclaration)
        {
            if (String.IsNullOrWhiteSpace(attributeDeclaration))
            {
                throw new ArgumentNullException("Die Attributdeklaration darf nicht leer sein.");
            }

            if (attributeDeclaration.Contains("\""))
            {
                return StringHelper.Between(attributeDeclaration, "\"", "\"");
            }

            if (attributeDeclaration.Contains("nameof("))
            {
                return StringHelper.Between(attributeDeclaration, "nameof(", "))");
            }

            throw new Exception("Invalid Attribute Usage");
        }
    }
}
