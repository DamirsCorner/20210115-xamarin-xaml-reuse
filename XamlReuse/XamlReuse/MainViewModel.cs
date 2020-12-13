using System;
using System.Collections.Generic;
using System.Text;

namespace XamlReuse
{
    public class MainViewModel
    {
        public List<BasicItem> BasicItems { get; } = new List<BasicItem>
        {
            new BasicItem("First", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rhoncus fermentum tellus vel euismod."),
            new BasicItem("Second", "Maecenas iaculis, erat non varius semper, nibh tellus sollicitudin tortor, ut suscipit justo justo id nisl. Donec efficitur iaculis quam, ac interdum nunc maximus nec."),
        };

        public List<IItem> MixedItems { get; } = new List<IItem>
        {
            new BasicItem("First", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rhoncus fermentum tellus vel euismod."),
            new ItemWithProperties("Properties", new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Key 1", "Value 1"),
                new KeyValuePair<string, string>("Key 2", "Value 2"),
                new KeyValuePair<string, string>("Key 3", "Value 3"),
                new KeyValuePair<string, string>("Key 4", "Value 4"),
            }),
        };
    }
}
