using Library.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class ParamCtrl
    {
        private const int delta = 30;
        private Prism prism;
        private Cylinder cylinder;
        // Point start coord 0,0,0
        private Point3D OriginCoord { get; set; }
        private string Binding { get; }
        private double Accuracy { get; }
        /// <summary>
        /// Ctor for calculation library
        /// </summary>
        /// <param name="h1">Cylinder height</param>
        /// <param name="r1">Cylinder radius</param>
        /// <param name="h2">Prism height</param>
        /// <param name="r2">Prism radius (base)</param>
        /// <param name="points">Count points to separation</param>
        /// <param name="binding">Bind areas top/bottom</param>
        public ParamCtrl(float h1, float r1, float h2, float r2, int points, string binding, float dx, float dy)
        {
            cylinder = new Cylinder(h1 * delta, r1 * delta, points, binding, dx, dy);
            prism = new Prism(h2 * delta, r2 * delta);
            Accuracy = points;
            Binding = binding;
        }

        /// <summary>
        /// Draw lines like coord system x and y
        /// </summary>
        /// <param name="pb">picture box for coord</param>
        /// <param name="e">paint event</param>
        public void DrawCoordSystem(PictureBox pb, PaintEventArgs e)
        {
            var height = pb.Height;
            var width = pb.Width;
            OriginCoord = new Entity.Point3D(width / 2, height / 2, 0);
            var g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, 0, OriginCoord.Y, width, OriginCoord.Y);
            g.DrawLine(pen, OriginCoord.X, 0, OriginCoord.X, height);

            int index = 1;
            for (float i = OriginCoord.X; i < width; i += delta)
            {
                g.DrawLine(pen, i, OriginCoord.Y + delta / 2, i, OriginCoord.Y - delta / 2);
                g.DrawString($"{index}", new Font("Arial", 8), System.Drawing.Brushes.Black, new Point((int)i + delta, (int)OriginCoord.Y - delta));
                index += 1;
            }

            index = -1;
            for (float i = OriginCoord.X; i > 0; i -= delta)
            {
                g.DrawLine(pen, i, OriginCoord.Y + delta / 2, i, OriginCoord.Y - delta / 2);
                g.DrawString($"{index}", new Font("Arial", 8), System.Drawing.Brushes.Black, new Point((int)i - delta, (int)OriginCoord.Y + delta));
                index -= 1;
            }

            index = -1;
            for (float i = OriginCoord.Y; i < height; i += delta)
            {
                g.DrawLine(pen, OriginCoord.X + delta / 2, i, OriginCoord.X - delta / 2, i);
                g.DrawString($"{index}", new Font("Arial", 8), System.Drawing.Brushes.Black, new Point((int)OriginCoord.X + delta, (int)i + delta));
                index -= 1;
            }

            index = 1;
            for (float i = OriginCoord.Y; i > 0; i -= delta)
            {
                g.DrawLine(pen, OriginCoord.X + delta / 2, i, OriginCoord.X - delta / 2, i);
                g.DrawString($"{index}", new Font("Arial", 8), System.Drawing.Brushes.Black, new Point((int)OriginCoord.X - delta, (int)i - delta));
                index += 1;
            }

            g.DrawString("X", new Font("Arial", 12), System.Drawing.Brushes.Black, new Point(delta, (int)OriginCoord.Y - delta));
            g.DrawString("Y", new Font("Arial", 12), System.Drawing.Brushes.Black, new Point((int)OriginCoord.X - delta, height - delta));
        }

        public void DrawFigures(PaintEventArgs e)
        {
            prism?.CalculateCoords(OriginCoord);
            cylinder?.CalculateCoords(OriginCoord);
            var g = e.Graphics;
            Pen pen = new Pen(Color.Green, 5);
            foreach (var item in prism.coordBottom)
            {
                g.DrawEllipse(pen, item.X, item.Y, 2, 2);
            }

            foreach (var item in prism.coordTop)
            {
                g.DrawEllipse(pen, item.X, item.Y, 2, 2);
            }

            pen = new Pen(Color.Red, 5);

            foreach (var item in cylinder.coordBottom)
            {
                g.DrawEllipse(pen, item.X, item.Y, 2, 2);
            }

            foreach (var item in cylinder.coordTop)
            {
                g.DrawEllipse(pen, item.X, item.Y, 2, 2);
            }
        }
    }
}
