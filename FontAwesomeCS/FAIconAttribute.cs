namespace FontAwesomeCS
{
    using System;

    public class FAIconAttribute : Attribute
    {
        public FAIconAttribute(string label, FAStyle style, string unicode)
        {
            Label = label;
            Style = style;
            Unicode = unicode;
        }

        public string Label { get; set; }

        public FAStyle Style { get; set; }

        public string Unicode { get; set; }
    }
}