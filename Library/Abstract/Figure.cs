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
            float[] Target = { point.X, point.Y, point.Z, 1 };

            float[,] Source = { {1, 0, 0, 0},
                                {0, 1, 0, 0},
                                {0, 0, 1, 0},
                                {dx, dy, dz, 1} };

            float[] Result = {  (Target[0] * Source[0, 0]) + (Target[1] * Source[1, 0]) + (Target[2] * Source[2, 0]) + (Target[3] * Source[3, 0]),
                                (Target[0] * Source[0, 1]) + (Target[1] * Source[1, 1]) + (Target[2] * Source[2, 1]) - (Target[3] * Source[3, 1]),
                                (Target[0] * Source[0, 2]) + (Target[1] * Source[1, 2]) + (Target[2] * Source[2, 2]) + (Target[3] * Source[3, 2]),
                                (Target[0] * Source[0, 3]) + (Target[1] * Source[1, 3]) + (Target[2] * Source[2, 3]) + (Target[3] * Source[3, 3]) };

            point.X = Result[0];
            point.Y = Result[1];
            point.Z = Result[2];
        }
    }
}
