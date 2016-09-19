using Library.Abstract;
using Library.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Prism : Figure
    {
        public Prism(float height, float radius) : base(height, radius)
        {
            int count = 3;
            coordBottom = new Point3D[count];
            coordTop = new Point3D[count];
        }

        public void CalculateCoords(Point3D startCoord)
        {
            coordBottom[0].X = startCoord.X - (float)(Math.Sqrt(3) * Radius / 2);
            coordBottom[0].Y = startCoord.Y;
            coordBottom[0].Z = startCoord.Z - Radius / 2;

            coordBottom[1].X = startCoord.X;
            coordBottom[1].Y = startCoord.Y;
            coordBottom[1].Z = startCoord.Z + Radius;

            coordBottom[2].X = startCoord.X + (float)(Math.Sqrt(3) * Radius / 2);
            coordBottom[2].Y = startCoord.Y;
            coordBottom[2].Z = startCoord.Z - Radius / 2;

            coordTop[0].X = startCoord.X - (float)(Math.Sqrt(3) * Radius / 2);
            coordTop[0].Y = startCoord.Y - Height;
            coordTop[0].Z = startCoord.Z - Radius / 2;

            coordTop[1].X = startCoord.X;
            coordTop[1].Y = startCoord.Y - Height;
            coordTop[1].Z = startCoord.Z + Radius;

            coordTop[2].X = startCoord.X + (float)(Math.Sqrt(3) * Radius / 2);
            coordTop[2].Y = startCoord.Y - Height;
            coordTop[2].Z = startCoord.Z - Radius / 2;
        }
    }
}
