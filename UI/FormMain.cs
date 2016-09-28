using Library;
using Library.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class FormMain : Form
    {
        private ParamCtrl _ctrl;
        private FormDraw _formDraw;
        public FormMain()
        {
            InitializeComponent();
            comboBoxBinding.SelectedIndex = 1;
            tabControlActions.Visible = false;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                _ctrl = Validation.Validate(textBoxHeight1.Text, textBoxRadius1.Text, textBoxHeight2.Text, textBoxRadius2.Text, comboBoxBinding.Text, textBoxPoints.Text, textBoxDx.Text, textBoxDy.Text);
                CreateFormForDraw();
                tabControlActions.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show(Resources.Incorrect);
            }
        }

        private void CreateFormForDraw()
        {
            if (_formDraw == null || _formDraw.IsDisposed)
            {
                _formDraw = new FormDraw(_ctrl) {MdiParent = this };
                _formDraw.Show();
                _formDraw.StartPosition = FormStartPosition.CenterScreen;
                _formDraw.WindowState = FormWindowState.Maximized;
                RedrawAreaWithRefreshing();
            }
        }

        private void RedrawAreaWithRefreshing(bool isFirst = true)
        {
            _formDraw.Refresh();
            _formDraw.RedrawArea(isFirst);
        }

        private void RedrawAreaWithChangeCoords(bool isProf, bool isGoriz)
        {
            _formDraw.Refresh();
            _formDraw.RedrawAreaWithChangeCoords(isProf, isGoriz);
        }

        private void buttonInc_Click(object sender, EventArgs e)
        {
            _ctrl.MoveFigures((int)numericUpDownDx.Value, (int)numericUpDownDy.Value, (int)numericUpDownDz.Value);
            RedrawAreaWithRefreshing(false);
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            _ctrl.MoveFigures(-(int)numericUpDownDx.Value, -(int)numericUpDownDy.Value, -(int)numericUpDownDz.Value);
            RedrawAreaWithRefreshing(false);
        }

        private void buttonScaleOX_Click(object sender, EventArgs e)
        {
            _ctrl.ScaleFigures(float.Parse(textBoxCoeffScaleX.Text), float.Parse(textBoxCoeffScaleY.Text), float.Parse(textBoxCoeffScaleZ.Text));
            RedrawAreaWithRefreshing(false);
        }

        private void buttonRotateX_Click(object sender, EventArgs e)
        {
            _ctrl.RotateFigures(float.Parse(numericUpDownRotate.Value.ToString()), 0, 0);
            RedrawAreaWithRefreshing(false);
        }

        private void buttonRotateY_Click(object sender, EventArgs e)
        {
            _ctrl.RotateFigures(0, float.Parse(numericUpDownRotate.Value.ToString()), 0);
            RedrawAreaWithRefreshing(false);
        }

        private void buttonRotateZ_Click(object sender, EventArgs e)
        {
            _ctrl.RotateFigures(0, 0, float.Parse(numericUpDownRotate.Value.ToString()));
            RedrawAreaWithRefreshing(false);
        }

        private void buttonFrontProection_Click(object sender, EventArgs e)
        {
            RedrawAreaWithRefreshing(false);
        }

        private void buttonGorisProection_Click(object sender, EventArgs e)
        {
            RedrawAreaWithChangeCoords(false, true);
        }

        private void buttonProfProection_Click(object sender, EventArgs e)
        {
            RedrawAreaWithChangeCoords(true, false);
        }
    }
}
