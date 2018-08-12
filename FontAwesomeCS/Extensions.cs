namespace FontAwesomeCS
{
    using System;
    using System.Reflection;

    public static class Extensions
    {
        public static FAIconAttribute GetFAIconAttribute(this FAIcon icon) => icon.GetAttributeOfType<FAIconAttribute>();

        public static FAStyleAttribute GetFAStyleAttribute(this FAStyle style) => style.GetAttributeOfType<FAStyleAttribute>();

        private static T GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
        {
            return enumVal
                .GetType()
                .GetMember(enumVal.ToString())[0]
                .GetCustomAttribute<T>()
            ;
        }
    }
}