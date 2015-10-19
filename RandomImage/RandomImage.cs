using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapGenerator
{
    public class RandomBitmap
    {
        public int Width { get; set; }
        public int Height { get; set; }

        Bitmap pic;

        public RandomBitmap() { }

        public RandomBitmap(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Bitmap Generate()
        {
            pic = new Bitmap(Width, Height);
            Random cas = new Random();

            for (int w = 0; w < Width; w++)
                for (int h = 0; h < Height; h++)
                {
                    Color c = Color.FromArgb(cas.Next(255), cas.Next(255), cas.Next(255));
                    pic.SetPixel(w, h, c);
                }
            return pic;
        }

        public void SaveImage(string path)
        {
            Dictionary<string, System.Drawing.Imaging.ImageFormat> imageFormat = new Dictionary<string, System.Drawing.Imaging.ImageFormat>();
            imageFormat.Add(".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            imageFormat.Add(".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            imageFormat.Add(".png", System.Drawing.Imaging.ImageFormat.Png);
            System.Drawing.Imaging.ImageFormat format;
            string ext = Path.GetExtension(path);
            imageFormat.TryGetValue(ext, out format);
            pic.Save(path, format);
        }
    }
}
