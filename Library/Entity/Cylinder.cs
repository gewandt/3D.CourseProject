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

        public void CalculateCoords(Point3D startCoord, float targetHeight)
        {
            targetHeight = GetByBindingDrawDimension(targetHeight);
            var angle = 360 / _points;
            CalcCoords(startCoord, coordBottom, angle, targetHeight, false);
            CalcCoords(startCoord, coordTop, angle, targetHeight, true);
        }

        private void CalcCoords(Point3D startCoord, Point3D[] points, int angle, float targetHeight, bool isTop)
        {
            var angleSum = 0;
            for (var i = 0; i < _points; i++)
            {
                var alpha = (angleSum * Math.PI) / 180;
                points[i].X = (float)(startCoord.X + (Radius * Math.Cos(alpha) + Dx));
                points[i].Y = GetSumByLocationPoints(startCoord.Y, targetHeight, isTop);
                points[i].Z = (float)(startCoord.Z + (Radius * Math.Sin(alpha) + Dz));
                angleSum += angle;
            }
        }

        private float GetSumByLocationPoints(float startY, float targetHeight, bool isTop)
        {
            if (isTop)
            {
                var operation = GetOperationByBinding();
                return operation(startY, Height) - targetHeight;
            }
            return startY - targetHeight;
        }

        private float GetByBindingDrawDimension(float targetHeight)
        {
            if (_binding.Equals("Снизу"))
            {
                return 0;
            }
            return targetHeight;            
        }

        private Func<float, float, float> GetOperationByBinding()
        {
            if (_binding.Equals("Снизу"))
            {
                return OperationPlus;
            }
            return OperationMinus;
        }

        private float OperationPlus(float source1, float source2)
        {
            return source1 + source2;
        }

        private float OperationMinus(float source1, float source2)
        {
            return source1 - source2;
        }
    }
}
