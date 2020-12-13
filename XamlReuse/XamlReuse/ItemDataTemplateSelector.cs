using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamlReuse
{
    public class ItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BasicItemTemplate { get; set; }
        public DataTemplate ItemWithPropertiesTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return item is ItemWithProperties ? ItemWithPropertiesTemplate : BasicItemTemplate;
        }
    }
}
