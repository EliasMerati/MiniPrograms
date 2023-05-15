using System;
using System.Collections.Generic;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;


string ImageFolder = Path.Combine(Environment.CurrentDirectory, "Images");
IEnumerable<string> Images = Directory.EnumerateFiles(ImageFolder);
foreach (string ImagePath in Images)
{
    string ThumbnailPath =Path.Combine(Environment.CurrentDirectory ,"Images",
        Path.GetFileNameWithoutExtension(ImagePath)
        + "-Thumbnail" + Path.GetExtension(ImagePath));

    using (Image image = Image.Load(ImagePath))
    {
        image.Mutate(x => x.Resize(image.Width / 10, image.Height / 10));
        image.Mutate(x => x.Grayscale());
        image.Save(ThumbnailPath);
    }
}