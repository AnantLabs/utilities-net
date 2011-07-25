using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using Size = System.Drawing.Size;

/// <summary>
/// Common image utility methods.
/// </summary>
public static class ImageUtils
{
    private static readonly ColorMatrix GrayscaleColorMatrix = new ColorMatrix(
        new[] 
                {
                    new[] { .3f, .3f, .3f, 0, 0 },
                    new[] { .59f, .59f, .59f, 0, 0 },
                    new[] { .11f, .11f, .11f, 0, 0 },
                    new[] { 0f, 0, 0, 1, 0 },
                    new[] { 0f, 0, 0, 0, 1 }
                });

    /// <summary>
    /// Converts <paramref name="original"/> image to grayscale and returns the resulting image.
    /// This method uses ColorMatrix, so it's fast.
    /// </summary>
    public static Bitmap Grayscale(this Image original)
    {
        if (original == null) throw new ArgumentNullException("original");

        // create a blank bitmap the same size as original
        var newBitmap = new Bitmap(original.Width, original.Height);

        using (var g = Graphics.FromImage(newBitmap))
        using (var attributes = new ImageAttributes())
        {
            attributes.SetColorMatrix(GrayscaleColorMatrix);

            // draw the original image on the new image
            // using the grayscale color matrix
            g.DrawImage(
                original,
                new Rectangle(0, 0, original.Width, original.Height),
                0,
                0,
                original.Width,
                original.Height,
                GraphicsUnit.Pixel,
                attributes);

            return newBitmap;
        }
    }

    /// <summary>
    /// Shrinks <paramref name="image"/> to fit it in the rectangle <paramref name="maxWidth"/> * <paramref name="maxHeight"/> and returns the resulting image.
    /// If it already fits - nothing is changed.
    /// </summary>
    public static Bitmap Shrink(this Image image, int maxWidth, int maxHeight)
    {
        if (image == null) throw new ArgumentNullException("image");

        int sourceWidth = image.Width;
        int sourceHeight = image.Height;

        int destWidth;
        int destHeight;
        if (sourceWidth > maxWidth || sourceHeight > maxHeight)
        {
            float widthRatio = 1f * maxWidth / sourceWidth;
            float heightRatio = 1f * maxHeight / sourceHeight;

            float ratio = Math.Min(heightRatio, widthRatio);

            destWidth = (int)(sourceWidth * ratio);
            destHeight = (int)(sourceHeight * ratio);
        }
        else
        {
            destHeight = sourceHeight;
            destWidth = sourceWidth;
        }

        return image.Scale(destWidth, destHeight);
    }

    /// <summary>
    /// Scales this <paramref name="image"/> to the specified <paramref name="width"/> and <paramref name="height"/>.
    /// </summary>
    public static Bitmap Scale(this Image image, int width, int height)
    {
        return Scale(image, new Size(width, height));
    }

    /// <summary>
    /// Scales this <paramref name="image"/> to the specified <paramref name="size"/>.
    /// </summary>
    public static Bitmap Scale(this Image image, Size size)
    {
        if (image == null) throw new ArgumentNullException("image");
        if (size.Width <= 0 || size.Height <= 0) throw new ArgumentException("Specified size is invalid (width <= 0 or height <= 0).");

        var newBitmap = new Bitmap(size.Width, size.Height);
        using (var g = Graphics.FromImage(newBitmap))
        {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, size.Width, size.Height);

            return newBitmap;
        }
    }

    /// <summary>
    /// Gets this <paramref name="image"/> in JPEG format with specified <paramref name="quality"/> as byte[].
    /// </summary>
    public static byte[] GetJpegBytes(this Image image, int quality)
    {
        if (image == null) throw new ArgumentNullException("image");

        var encoder = ImageCodecInfo.GetImageEncoders().
            First(codec => codec.FormatID == ImageFormat.Jpeg.Guid);

        // ReSharper disable RedundantCast
        using (var qualityParam = new EncoderParameter(Encoder.Quality, (long)quality))
        // ReSharper restore RedundantCast
        using (var encoderParameters = new EncoderParameters { Param = new[] { qualityParam } })
        using (var stream = new MemoryStream())
        {
            image.Save(stream, encoder, encoderParameters);
            return stream.ToArray();
        }
    }

    /// <summary>
    /// Downloads image from the specified <paramref name="url"/> and returns it as Bitmap.
    /// </summary>
    public static Bitmap Download(Uri url)
    {
        if (url == null) throw new ArgumentNullException("url");

        using (var response = WebRequest.Create(url).GetResponse())
        using (var responseStream = response.GetResponseStream())
        {
            // Nested construction required to prevent issues from closing the underlying stream
            return new Bitmap(new Bitmap(responseStream));
        }
    }

    /// <summary>
    /// Downloads image from the specified <paramref name="url"/> and returns it as Bitmap.
    /// </summary>
    public static Bitmap Download(string url)
    {
        if (url == null) throw new ArgumentNullException("url");

        return Download(new Uri(url));
    }

    /// <summary>
    /// Converts this BitmapSource to Bitmap.
    /// </summary>
    public static Bitmap ToBitmap(this BitmapSource bitmapSource)
    {
        if (bitmapSource == null) return null;

        var encoder = new BmpBitmapEncoder();
        encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

        using (var stream = new MemoryStream())
        {
            encoder.Save(stream);

            // Nested construction required to prevent issues from closing the underlying stream
            return new Bitmap(new Bitmap(stream));
        }
    }

    /// <summary>
    /// Converts this Bitmap to BitmapSource.
    /// </summary>
    public static BitmapSource ToBitmapSource(this Bitmap bitmap)
    {
        if (bitmap == null) return null;

        return Imaging.CreateBitmapSourceFromHBitmap(
            bitmap.GetHbitmap(),
            IntPtr.Zero,
            Int32Rect.Empty,
            BitmapSizeOptions.FromEmptyOptions());
    }
}