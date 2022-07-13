using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Helpers.Methods;

public static class MyOfficeMethods
{
    public static bool ValidRequireds<T>(T obj)
    {
        var propertiesRequireds = TypeDescriptor.GetProperties(typeof(T))
            .Cast<PropertyDescriptor>()
            .Where(p => p.Attributes.Cast<Attribute>().Any(a => a.GetType() == typeof(RequiredAttribute)))
            .Select(p => p.Name)
            .ToList();

        var type = obj?.GetType();
        var properties = type?.GetProperties().ToList();
        if (properties == null) return false;
        
        foreach (var property in properties)
        {
            var propValue = (string)property.GetValue(obj, null)!;
            var propName = property.Name!;

            if (propertiesRequireds.Contains(propName) && string.IsNullOrEmpty(propValue)) return false;
        }

        return true;
    }
}