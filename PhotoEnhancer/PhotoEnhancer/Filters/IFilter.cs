using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public interface IFilter
    {
        Pic Process(Pic original, double[] parameters);
        ParameterInfo[] GetParametersInfo();
    }
}
