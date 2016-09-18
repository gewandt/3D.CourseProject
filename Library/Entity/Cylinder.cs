using Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity
{
    public class Cylinder : Figure
    {
        private readonly int _points;
        private string _binding;
        private float Dx { get; }
        private float Dz { get; }
        public Cylinder(float height, float radius, int points, string binding, float dx, float dz) : base(height, radius)
        {
            _points = points;
            _binding = binding;
            Dx = dx;
            Dz = dz;
            coordBottom = new Point3D[_points];
            coordTop = new Point3D[_points];
        }

        public override void CalculateCoords(Point3D startCoord)
        {
            var angle = 360 / _points;
            int angleSum = 0;
            for (var i = 0; i < _points; i++)
            {
                var alpha = (angleSum * Math.PI) / 180;
                coordBottom[i].X = (float)(startCoord.X + (Radius * Math.Cos(alpha) + Dx));
                coordBottom[i].Y = startCoord.Y;
                coordBottom[i].Z = (float)(startCoord.Z + (Radius * Math.Sin(alpha) + Dz));
                angleSum += angle;
            }

            angleSum = 0;
            for (var i = 0; i < _points; i++)
            {
                var alpha = (angleSum * Math.PI) / 180;
                coordTop[i].X = (float)(startCoord.X + (Radius * Math.Cos(alpha) + Dx));
                coordTop[i].Y = startCoord.Y + Height;
                coordTop[i].Z = (float)(startCoord.Z + (Radius * Math.Sin(alpha) + Dz));
                angleSum += angle;
            }
        }
    }
}
