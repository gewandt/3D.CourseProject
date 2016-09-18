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

        public virtual void CalculateCoords(Point3D start) { }
    }
}
