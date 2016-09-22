using Library.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Abstract
{
    public abstract class Figure
    {
        public Point3D[] coordBottom;
        public Point3D[] coordTop;
        public float Height { get; }
        public float Radius { get; }
        public Figure(float height, float radius)
        {
            Height = height;
            Radius = radius;
        }

        public void Move(ref Point3D point, float dx, float dy, float dz)
        {
            float[] target = { point.X, point.Y, point.Z, 1 };

            float[,] source = { {1, 0, 0, 0},
                                {0, 1, 0, 0},
                                {0, 0, 1, 0},
                                {dx, dy, dz, 1} };

            float[] result = {  (target[0] * source[0, 0]) + (target[1] * source[1, 0]) + (target[2] * source[2, 0]) + (target[3] * source[3, 0]),
                                (target[0] * source[0, 1]) + (target[1] * source[1, 1]) + (target[2] * source[2, 1]) - (target[3] * source[3, 1]),
                                (target[0] * source[0, 2]) + (target[1] * source[1, 2]) + (target[2] * source[2, 2]) + (target[3] * source[3, 2]),
                                (target[0] * source[0, 3]) + (target[1] * source[1, 3]) + (target[2] * source[2, 3]) + (target[3] * source[3, 3]) };

            point.X = result[0];
            point.Y = result[1];
            point.Z = result[2];
        }

        public void Scale(ref Point3D point, float sx, float sy, float sz, float toZeroX, float toZeroY, float toZeroZ)
        {
            float[] target = { point.X, point.Y, point.Z, 1 };

            float[,] source = {  {sx, 0, 0, 0},
                            {0, sy, 0, 0},
                            {0, 0, sz, 0},
                            {0, 0, 0, 1} };

            float[] result = { (target[0] * source[0, 0]) + (target[1] * source[1, 0]) + (target[2] * source[2, 0]) + (target[3] * source[3, 0]),
                            (target[0] * source[0, 1]) + (target[1] * source[1, 1]) + (target[2] * source[2, 1]) + (target[3] * source[3, 1]),
                            (target[0] * source[0, 2]) + (target[1] * source[1, 2]) + (target[2] * source[2, 2]) + (target[3] * source[3, 2]),
                            (target[0] * source[0, 3]) + (target[1] * source[1, 3]) + (target[2] * source[2, 3]) + (target[3] * source[3, 3]) };
            point.X = result[0] + toZeroX;
            point.Y = result[1] + toZeroY;
            point.Z = result[2] + toZeroZ;
        }
    }
}
