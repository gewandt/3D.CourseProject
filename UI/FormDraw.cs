using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormDraw : Form
    {
        private readonly Graphics _gr;
        private ParamCtrl _ctrl;
        public FormDraw(ParamCtrl ctrl)
        {
            _ctrl = ctrl;
            InitializeComponent();
            _gr = Graphics.FromHwnd(pictureBoxMain.Handle);
        }

        public void ClearDrawArea()
        {
            _ctrl.ClearArea(_gr);
        }

        public void RedrawArea(Graphics g)
        {
            _ctrl.DrawCoordSystem(pictureBoxMain, g);
            _ctrl.DrawFigures(g);
            _ctrl.DrawRibs(g);
        }

        private void FormDraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            RedrawArea(e.Graphics);
        }
    }
}
