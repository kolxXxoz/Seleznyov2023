using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public static class Converter
    {
        public static Pic BitmapToPic(Bitmap bmp)
        {
            var pic = new Pic(bmp.Width, bmp.Height);
            
            for (var x = 0; x < bmp.Width; x++) 
                for (var y = 0; y < bmp.Height; y++)
                {
                    var p = bmp.GetPixel(x, y);
                    pic[x, y] = new Pixel(p.R / 255.0, p.G / 255.0, p.B / 255.0);
                }

            return pic;
        }

        public static Bitmap PicToBitmap(Pic pic)
        {
            var bmp = new Bitmap(pic.Width, pic.Height);

            for (var x = 0; x < pic.Width; x++)
                for (var y = 0; y < pic.Height; y++)
                    bmp.SetPixel(x, y, Color.FromArgb(
                        (int)Math.Round(pic[x, y].R * 255), 
                        (int)Math.Round(pic[x, y].G * 255), 
                        (int)Math.Round(pic[x, y].B * 255)));

            return bmp;
        }
    }
}
