using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public abstract class PixelFilter : IFilter
    {
        public abstract ParameterInfo[] GetParametersInfo();

        public Pic Process(Pic original, double[] parameters)
        {
            var newPic = new Pic(original.Width, original.Height);

            for (var x = 0; x < original.Width; x++)
                for (var y = 0; y < original.Height; y++)
                    newPic[x, y] = ProcessPixel(original[x, y], parameters);

            return newPic;
        }  
        
        public abstract Pixel ProcessPixel(Pixel pixel, double[] parameters);
    }
}
