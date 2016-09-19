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
        public FormDraw(ParamCtrl ctrl)
        {
            _ctrl = ctrl;
            InitializeComponent();
        }

        private void FormDraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            _ctrl.DrawCoordSystem(pictureBoxMain, e);
            _ctrl.DrawFigures(e);
            _ctrl.DrawRibs(e);
        }
    }
}
