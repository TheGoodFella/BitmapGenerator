using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapGenerator
{
    public class RandomBitmap
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public RandomBitmap() { }

        public RandomBitmap(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Bitmap Generate()
        {
            Bitmap pic = new Bitmap(Width, Height);
            Random cas = new Random();

            for (int w = 0; w < Width; w++)
                for (int h = 0; h < Height; h++)
                {
                    Color c = Color.FromArgb(cas.Next(255), cas.Next(255), cas.Next(255));
                    pic.SetPixel(w, h, c);
                }

            return pic;
        }

    }
}
