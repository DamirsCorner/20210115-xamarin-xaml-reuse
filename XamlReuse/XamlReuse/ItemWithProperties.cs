using System.Collections.Generic;

namespace XamlReuse
{
    public class ItemWithProperties : IItem
    {
        public ItemWithProperties(string title, List<KeyValuePair<string, string>> properties)
        {
            Title = title;
            Properties = properties;
        }

        public string Title { get; }
        public List<KeyValuePair<string, string>> Properties { get; }
    }
}
