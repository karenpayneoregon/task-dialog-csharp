using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using ResourcesDemo.Properties;

namespace ResourcesDemo.Classes
{
    public class ResourceHelper
    {
        public static List<ResourceItem> ResourceItemList()
        {
            var items = new List<ResourceItem>();

            foreach (var name in ResourceImageNames())
            {
                var item = new ResourceItem() { Name = name };
                if (Resources.ResourceManager.GetObject(name) is string)
                {
                    item.Value = Resources.ResourceManager.GetObject(name)?.ToString();
                }
                items.Add(item);
            }
            return items;
        }
        public static List<string> ResourceImageNames()
        {

            try
            {
                var names = new List<string>();
                
                names.AddRange(
                    from DictionaryEntry dictionaryEntry in Resources
                        .ResourceManager
                        .GetResourceSet(CultureInfo.CurrentUICulture, true, true)
                    where dictionaryEntry.Value is Bitmap
                    select dictionaryEntry.Key.ToString());

                return names;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}