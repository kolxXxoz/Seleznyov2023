using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class BnWFilter : PixelFilter
    {
        public override ParameterInfo[] GetParametersInfo()
        {
            return new ParameterInfo[0];
        }

        public override Pixel ProcessPixel(Pixel pixel, double[] parameters)
        {
            var bnw = (pixel.R + pixel.G + pixel.B) / 3;
            return new Pixel(bnw, bnw, bnw);
        }

        public override string ToString()
        {
            return "Чёрно-белый фильтр";
        }
    }
}
