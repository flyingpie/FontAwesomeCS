namespace FontAwesomeCS
{
    using System;

    public class FAStyleAttribute : Attribute
    {
        public FAStyleAttribute(string style)
        {
            Style = style;
        }

        public string Style { get; set; }
    }
}