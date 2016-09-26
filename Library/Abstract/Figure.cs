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

        public void Rotate(ref Point3D point, float ax, float ay, float az, double toZeroX = 0, double toZeroY = 0, double toZeroZ = 0)
        {
            double[] target = { point.X, point.Y, point.Z, 1 };

            double[,] rx = { { 1, 0, 0, 0},
                           {0, Math.Cos(-(ax * Math.PI) / 180), Math.Sin(-(ax * Math.PI) / 180), 0},
                           {0, -(Math.Sin(-(ax * Math.PI) / 180)), Math.Cos(-(ax * Math.PI) / 180), 0},
                           {0, 0, 0, 1} };

            double[,] ry = { {Math.Cos(-(ay * Math.PI) / 180), 0, Math.Sin(-(ay * Math.PI) / 180), 0},
                           {0, 1, 0, 0},
                           {-(Math.Sin(-(ay * Math.PI) / 180)), 0, Math.Cos(-(ay * Math.PI) / 180), 0},
                           {0, 0, 0, 1} };

            double[,] rz = { {Math.Cos(-(az * Math.PI) / 180), Math.Sin(-(az * Math.PI) / 180), 0, 0},
                           {-(Math.Sin(-(az * Math.PI) / 180)), Math.Cos(-(az * Math.PI) / 180), 0, 0},
                           {0, 0, 1, 0},
                           {0, 0, 0, 1} };

            double[] result = { (target[0] * rx[0, 0]) + (target[1] * rx[1, 0]) + (target[2] * rx[2, 0]) - (target[3] * rx[3, 0]),
                            (target[0] * rx[0, 1]) + (target[1] * rx[1, 1]) + (target[2] * rx[2, 1]) + (target[3] * rx[3, 1]),
                            (target[0] * rx[0, 2]) + (target[1] * rx[1, 2]) + (target[2] * rx[2, 2]) + (target[3] * rx[3, 2]),
                            (target[0] * rx[0, 3]) + (target[1] * rx[1, 3]) + (target[2] * rx[2, 3]) + (target[3] * rx[3, 3]),

                            (target[0] * ry[0, 0]) + (target[1] * ry[1, 0]) + (target[2] * ry[2, 0]) - (target[3] * ry[3, 0]),
                            (target[0] * ry[0, 1]) + (target[1] * ry[1, 1]) + (target[2] * ry[2, 1]) + (target[3] * ry[3, 1]),
                            (target[0] * ry[0, 2]) + (target[1] * ry[1, 2]) + (target[2] * ry[2, 2]) + (target[3] * ry[3, 2]),
                            (target[0] * ry[0, 3]) + (target[1] * ry[1, 3]) + (target[2] * ry[2, 3]) + (target[3] * ry[3, 3]),

                            (target[0] * rz[0, 0]) + (target[1] * rz[1, 0]) + (target[2] * rz[2, 0]) - (target[3] * rz[3, 0]),
                            (target[0] * rz[0, 1]) + (target[1] * rz[1, 1]) + (target[2] * rz[2, 1]) + (target[3] * rz[3, 1]),
                            (target[0] * rz[0, 2]) + (target[1] * rz[1, 2]) + (target[2] * rz[2, 2]) + (target[3] * rz[3, 2]),
                            (target[0] * rz[0, 3]) + (target[1] * rz[1, 3]) + (target[2] * rz[2, 3]) + (target[3] * rz[3, 3]) };
            if(ax != 0)
            {
                point.X = (float)(result[0] + toZeroX);
                point.Y = (float)(result[1] + toZeroY);
                point.Z = (float)(result[2] + toZeroZ);
            }
            if(ay != 0)
            {
                point.X = (float)(result[4] + toZeroX);
                point.Y = (float)(result[5] + toZeroY);
                point.Z = (float)(result[6] + toZeroZ);
            }
            if (az != 0)
            {
                point.X = (float)(result[8] + toZeroX);
                point.Y = (float)(result[9] + toZeroY);
                point.Z = (float)(result[10] + toZeroZ);
            }
        }
    }
}
