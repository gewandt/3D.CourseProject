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
        private ParamCtrl _ctrl;
        private Graphics gr;
        public FormDraw(ParamCtrl ctrl)
        {
            _ctrl = ctrl;
            InitializeComponent();
        }

        public void RedrawArea(bool isFirst = true)
        {
            InitialGraphics();
            if (isFirst)
                _ctrl.OverrideOriginCoordinates(pictureBoxMain);
            _ctrl.DrawCoordSystem(gr);
            _ctrl.DrawFigures(gr);
            _ctrl.DrawRibs(gr);
        }

        private void InitialGraphics()
        {
            gr = Graphics.FromHwnd(pictureBoxMain.Handle);
        }

        private void FormDraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
