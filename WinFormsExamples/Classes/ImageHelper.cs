using System.Collections;
using System.Globalization;
using WinFormsExamples.Properties;
#pragma warning disable CS8600
#pragma warning disable CS8601

namespace WinFormsExamples.Classes;

/// <summary>
/// Read images from current project resources
/// </summary>
public class ImageHelper
{

    /// <summary>
    /// Get all bitmap and icon resources
    /// </summary>
    /// <returns></returns>
    public static List<ResourceItem> ResourceItemList()
    {
        var items = new List<ResourceItem>();

        foreach (var name in ResourceImageNames())
        {
            /*
             * For this code sample ignore the default image
             */
            if (name == "ready")
            {
                continue;
            }

            var item = new ResourceItem() { Name = name, IsIcon = false };

            if (Resources.ResourceManager.GetObject(name) is Icon icon)
            {
                item.Image = ((Icon)Resources.ResourceManager.GetObject(name))?.ToBitmap();
                item.Icon = icon;
                item.IsIcon = true;
            }
            else
            {
                item.Image = (Bitmap)Resources.ResourceManager.GetObject(name);
            }

            items.Add(item);

        }

        return items;

    }
    /// <summary>
    /// Get all resource names for icon and bitmaps
    /// </summary>
    /// <returns></returns>
    public static List<string> ResourceImageNames()
    {

        try
        {

            var names = new List<string>();

            var resourceSet = Resources
                .ResourceManager
                .GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            names.AddRange(
                from DictionaryEntry dictionaryEntry in resourceSet
                where dictionaryEntry.Value is Image || dictionaryEntry.Value is Icon
                select dictionaryEntry.Key.ToString());

            return names;

        }
        catch (Exception)
        {
            return null!;
        }
    }
}