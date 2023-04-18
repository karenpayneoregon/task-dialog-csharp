using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace WpfExamples.Classes;

public class ImageHelpers
{
    /// <summary>
    /// Convert <see cref="BitmapImage"/> to <see cref="Icon"/>
    /// </summary>
    /// <param name="path">Location of image file</param>
    /// <returns>An Icon</returns>
    public static Icon BitmapImageToIcon(string path)
    {
        BitmapImage bitmapImage = new (new Uri(path, UriKind.Relative));
        using MemoryStream outStream = new ();
        BitmapEncoder encoder = new BmpBitmapEncoder();
        encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
        encoder.Save(outStream);
        Bitmap bitmap = new (outStream);

        return Icon.FromHandle(new Bitmap(bitmap).GetHicon());
    }
}