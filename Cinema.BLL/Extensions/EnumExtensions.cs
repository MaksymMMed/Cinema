using System.Reflection;

namespace Cinema.BLL.Extensions;

public static class EnumExtensions
{
    public static TAttribute? GetAttribute<TAttribute>(this Enum enumValue) 
        where TAttribute : Attribute
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<TAttribute>();
    }
}