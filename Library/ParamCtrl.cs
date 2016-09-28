using Library.Abstract;
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
        private const int delta = 20;
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
            cylinder = new Cylinder(h1 * delta, r1 * delta, points, binding, dx * delta, dy * delta);
            prism = new Prism(h2 * delta, r2 * delta);
            Accuracy = points;
            Binding = binding;
            OriginCoord = new Entity.Point3D() { X = 0, Y = 0, Z = 0 };
        }

        /// <summary>
        /// Override standart starting coordinates and calculate coords for figures
        /// </summary>
        /// <param name="pb">Picturebox for painting</param>
        public void OverrideOriginCoordinates(PictureBox pb)
        {
            var height = pb.Height;
            var width = pb.Width;
            OriginCoord = new Entity.Point3D(width / 2, height / 2, height / 2);
            prism?.CalculateCoords(OriginCoord);
            cylinder?.CalculateCoords(OriginCoord, prism.Height);
        }

        /// <summary>
        /// Draw lines like coord system x and y
        /// </summary>
        /// <param name="pb">picture box for coord</param>
        /// <param name="g">Graphics</param>
        public void DrawCoordSystem(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, 0, OriginCoord.Y, OriginCoord.X * 2, OriginCoord.Y);
            g.DrawLine(pen, OriginCoord.X, 0, OriginCoord.X, OriginCoord.Y * 2);
            var height = OriginCoord.Y * 2;

            #region Draw cordinates (numbers and notes)

            //int index = 1;
            //for (float i = OriginCoord.X; i < width; i += delta)
            //{
            //    g.DrawLine(pen, i, OriginCoord.Y + delta / 2, i, OriginCoord.Y - delta / 2);
            //    g.DrawString($"{index}", new Font("Arial", 8), System.Drawing.Brushes.Black, new Point((int)i + delta, (int)OriginCoord.Y - delta));
            //    index += 1;
            //}

            //index = -1;
            //for (float i = OriginCoord.X; i > 0; i -= delta)
            //{
            //    g.DrawLine(pen, i, OriginCoord.Y + delta / 2, i, OriginCoord.Y - delta / 2);
            //    g.DrawString($"{index}", new Font("Arial", 8), System.Drawing.Brushes.Black, new Point((int)i - delta, (int)OriginCoord.Y + delta));
            //    index -= 1;
            //}

            //index = -1;
            //for (float i = OriginCoord.Y; i < height; i += delta)
            //{
            //    g.DrawLine(pen, OriginCoord.X + delta / 2, i, OriginCoord.X - delta / 2, i);
            //    g.DrawString($"{index}", new Font("Arial", 8), System.Drawing.Brushes.Black, new Point((int)OriginCoord.X + delta, (int)i + delta));
            //    index -= 1;
            //}

            //index = 1;
            //for (float i = OriginCoord.Y; i > 0; i -= delta)
            //{
            //    g.DrawLine(pen, OriginCoord.X + delta / 2, i, OriginCoord.X - delta / 2, i);
            //    g.DrawString($"{index}", new Font("Arial", 8), System.Drawing.Brushes.Black, new Point((int)OriginCoord.X - delta, (int)i - delta));
            //    index += 1;
            //}

            #endregion

            g.DrawString("X", new Font("Arial", 12), System.Drawing.Brushes.Black, new Point(delta, (int)OriginCoord.Y - delta));
            g.DrawString("Y", new Font("Arial", 12), System.Drawing.Brushes.Black, new Point((int)OriginCoord.X - delta, (int)height - delta));
        }

        /// <summary>
        /// Draw figures on graphic
        /// </summary>
        /// <param name="g">Graphics to paint</param>
        public void DrawFigures(Graphics g, Action<Graphics, Pen, Point3D[]> drawPoints)
        {
            if (drawPoints == null)
                drawPoints = DrawPointsByCoordsXY;
            Pen pen = new Pen(Color.Green, 5);
            drawPoints(g, pen, prism.coordBottom);
            drawPoints(g, pen, prism.coordTop);
            pen = new Pen(Color.Red, 5);
            drawPoints(g, pen, cylinder.coordBottom);
            drawPoints(g, pen, cylinder.coordTop);
        }

        /// <summary>
        /// Draw ribs for figures
        /// </summary>
        /// <param name="g">Graphics to paint</param>
        public void DrawRibs(Graphics g, Action<Graphics, Pen, Point3D[]> drawRibs, Action<Graphics, Pen, Point3D[], Point3D[]> drawRibsFromTopToBottom)
        {
            if (drawRibs == null)
                drawRibs = DrawRibsAtBaseXY;
            if (drawRibsFromTopToBottom == null)
                drawRibsFromTopToBottom = DrawRibsFromTopToBottomXY;
            Pen pen = new Pen(Color.Green, 1);
            drawRibs(g, pen, prism.coordTop);
            drawRibs(g, pen, prism.coordBottom);
            pen.Color = Color.Red;
            drawRibs(g, pen, cylinder.coordTop);
            drawRibs(g, pen, cylinder.coordBottom);

            drawRibsFromTopToBottom(g, pen, cylinder.coordTop, cylinder.coordBottom);
            pen.Color = Color.Green;
            drawRibsFromTopToBottom(g, pen, prism.coordTop, prism.coordBottom);
        }

        public Action<Graphics, Pen, Point3D[]> GetMethodForDrawPoints(bool isProf, bool isGoriz)
        {
            if (isProf)
                return DrawPointsByCoordsYZ;
            return DrawPointsByCoordsXZ;
        }

        public Action<Graphics, Pen, Point3D[]> GetMethodForDrawRibs(bool isProf, bool isGoriz)
        {
            if (isProf)
                return DrawRibsAtBaseYZ;
            return DrawRibsAtBaseXZ;
        }

        public Action<Graphics, Pen, Point3D[], Point3D[]> GetMethodForDrawRibsFromTopToBottom(bool isProf, bool isGoriz)
        {
            if (isProf)
                return DrawRibsFromTopToBottomYZ;
            return DrawRibsFromTopToBottomXZ;
        }

        public void MoveFigures(int dx, int dy, int dz)
        {
            dx *= delta;
            dy *= delta;
            dz *= delta;
            MoveFigure(cylinder, dx, dy, dz);
            MoveFigure(prism, dx, dy, dz);
        }

        public void ScaleFigures(float sx, float sy, float sz)
        {
            ScaleFigure(cylinder, sx, sy, sz);
            ScaleFigure(prism, sx, sy, sz);
        }

        public void RotateFigures(float ax, float ay, float az)
        {
            RotateFigure(cylinder, ax, ay, az);
            RotateFigure(prism, ax, ay, az);
        }

        private void RotateFigure(Figure figure, float ax = 0, float ay = 0, float az = 0)
        {
            double zeroAx = 0, zeroAy = 0, zeroAz = 0;
            GetZeroRotation(ax, ay, az, out zeroAx, out zeroAy, out zeroAz);
            for (int i = 0; i < figure.coordBottom.Count(); i++)
            {
                figure.Rotate(ref figure.coordBottom[i], ax, ay, az, zeroAx, zeroAy, zeroAz);
                figure.Rotate(ref figure.coordTop[i], ax, ay, az, zeroAx, zeroAy, zeroAz);
            }
        }

        private void GetZeroRotation(float ax, float ay, float az, out double zeroX, out double zeroY, out double zeroZ)
        {
            zeroX = 0;
            zeroY = 0;
            zeroZ = 0;
            if(ax != 0)
            {
                zeroX = 0;
                zeroY = OriginCoord.Y * (1 - Math.Cos(-(ax * Math.PI) / 180)) + OriginCoord.Z * Math.Sin(-(ax * Math.PI) / 180);
                zeroZ = OriginCoord.Z * (1 - Math.Cos(-(ax * Math.PI) / 180)) - OriginCoord.Y * Math.Sin(-(ax * Math.PI) / 180);
            }
            if (ay != 0)
            {
                zeroX = OriginCoord.X * (1 - Math.Cos(-(ay * Math.PI) / 180)) + OriginCoord.Z * Math.Sin(-(ay * Math.PI) / 180);
                zeroY = 0;
                zeroZ = OriginCoord.Z * (1 - Math.Cos(-(ay * Math.PI) / 180)) - OriginCoord.X * Math.Sin(-(ay * Math.PI) / 180);
            }
            if (az != 0)
            {
                zeroX = OriginCoord.X * (1 - Math.Cos(-(az * Math.PI) / 180)) + OriginCoord.Y * Math.Sin(-(az * Math.PI) / 180);
                zeroY = OriginCoord.Y * (1 - Math.Cos(-(az * Math.PI) / 180)) - OriginCoord.X * Math.Sin(-(az * Math.PI) / 180);
                zeroZ = 0;
            }
        }

        private void MoveFigure(Figure figure, int dx, int dy, int dz)
        {
            for (int i = 0; i < figure.coordBottom.Count(); i++)
            {
                figure.Move(ref figure.coordBottom[i], dx, dy, dz);
                figure.Move(ref figure.coordTop[i], dx, dy, dz);
            }
        }

        private void ScaleFigure(Figure figure, float sx, float sy, float sz)
        {
            float toZeroX = OriginCoord.X * (1 - sx);
            float toZeroY = OriginCoord.Y * (1 - sy);
            float toZeroZ = OriginCoord.Z * (1 - sz);
            for (int i = 0; i < figure.coordBottom.Count(); i++)
            {
                figure.Scale(ref figure.coordBottom[i], sx, sy, sz, toZeroX, toZeroY, toZeroZ);
                figure.Scale(ref figure.coordTop[i], sx, sy, sz, toZeroX, toZeroY, toZeroZ);
            }
        }

        private void DrawRibsAtBaseXY(Graphics g, Pen pen, Point3D[] array)
        {
            var count = array.Count() - 1;
            g.DrawLine(pen, array[0].X, array[0].Y, array[count].X, array[count].Y);
            for (int i = 0; i < count; i++)
            {
                g.DrawLine(pen, array[i].X, array[i].Y, array[i + 1].X, array[i + 1].Y);
            }
        }

        private void DrawRibsFromTopToBottomXY(Graphics g, Pen pen, Point3D[] source, Point3D[] target)
        {
            for (int i = 0; i < source.Count(); i++)
            {
                g.DrawLine(pen, source[i].X, source[i].Y, target[i].X, target[i].Y);
            }
        }

        private void DrawPointsByCoordsXY(Graphics g, Pen pen, Point3D[] array)
        {
            foreach (var item in array)
            {
                g.DrawEllipse(pen, item.X, item.Y, 2, 2);
            }
        }

        private void DrawRibsAtBaseXZ(Graphics g, Pen pen, Point3D[] array)
        {
            var count = array.Count() - 1;
            g.DrawLine(pen, array[0].X, array[0].Z, array[count].X, array[count].Z);
            for (int i = 0; i < count; i++)
            {
                g.DrawLine(pen, array[i].X, array[i].Z, array[i + 1].X, array[i + 1].Z);
            }
        }

        private void DrawRibsFromTopToBottomXZ(Graphics g, Pen pen, Point3D[] source, Point3D[] target)
        {
            for (int i = 0; i < source.Count(); i++)
            {
                g.DrawLine(pen, source[i].X, source[i].Z, target[i].X, target[i].Z);
            }
        }

        private void DrawPointsByCoordsXZ(Graphics g, Pen pen, Point3D[] array)
        {
            foreach (var item in array)
            {
                g.DrawEllipse(pen, item.X, item.Z, 2, 2);
            }
        }

        private void DrawRibsAtBaseYZ(Graphics g, Pen pen, Point3D[] array)
        {
            var count = array.Count() - 1;
            g.DrawLine(pen, array[0].Y, array[0].Z, array[count].Y, array[count].Z);
            for (int i = 0; i < count; i++)
            {
                g.DrawLine(pen, array[i].Y, array[i].Z, array[i + 1].Y, array[i + 1].Z);
            }
        }

        private void DrawRibsFromTopToBottomYZ(Graphics g, Pen pen, Point3D[] source, Point3D[] target)
        {
            for (int i = 0; i < source.Count(); i++)
            {
                g.DrawLine(pen, source[i].Y, source[i].Z, target[i].Y, target[i].Z);
            }
        }

        private void DrawPointsByCoordsYZ(Graphics g, Pen pen, Point3D[] array)
        {
            foreach (var item in array)
            {
                g.DrawEllipse(pen, item.Y, item.Z, 2, 2);
            }
        }
    }
}
