#pragma warning disable CS8618
namespace WinFormsExamples.Classes;

/// <summary>
/// Provides access to resource images by loading them once
/// </summary>
public sealed class ResourceImages
{
    private static readonly Lazy<ResourceImages> Lazy = new(() => new ResourceImages());

    public static ResourceImages Instance => Lazy.Value;

    private List<ResourceItem> _images;
    /// <summary>
    /// Get all icon and bitmap images from project resources
    /// </summary>
    /// <returns>list of images</returns>
    public List<ResourceItem> Images() 
        => _images ??= ImageHelper.ResourceItemList();

    /// <summary>
    /// Icons only
    /// </summary>
    public List<ResourceItem> Icons => Images().Where(resourceItem 
        => resourceItem.IsIcon).OrderBy(resourceItem => resourceItem.Name).ToList();
}