using System;

namespace Strapi.SDK
{
    public static class Utility
    {
        public static void EnsureArgument(this object parameter, string name)
        {
            if (parameter == null)
            {
                throw new ArgumentException($"{name} is required");
            }

            var type = parameter.GetType();
            if (type.GetDefaultValue() == parameter)
            {
                throw new ArgumentException($"{name} is required");
            }
        }

        public static object GetDefaultValue(this Type t)
        {
            if (t.IsValueType && Nullable.GetUnderlyingType(t) == null)
            {
                return Activator.CreateInstance(t);
            }
            return null;
        }
    }
}