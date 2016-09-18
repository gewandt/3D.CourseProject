using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Validation
{
    public static class Validation
    {
        public static ParamCtrl Validate(string h1, string r1, string h2, string r2, string binding, string points, string dx, string dz)
        {
            try
            {
                float height1 = float.Parse(h1);
                float radius1 = float.Parse(r1);
                float height2 = float.Parse(h2);
                float radius2 = float.Parse(r2);
                int pointsAppr = int.Parse(points);
                float floatDx = float.Parse(dx);
                float floatDz = float.Parse(dz);
                return new ParamCtrl(height1, radius1, height2, radius2, pointsAppr, binding, floatDx, floatDz);
            }
            catch (FormatException)
            {
                throw new FormatException();
            }
        }
    }
}
