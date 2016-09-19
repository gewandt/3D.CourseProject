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
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                _ctrl = Validation.Validate(textBoxHeight1.Text, textBoxRadius1.Text, textBoxHeight2.Text, textBoxRadius2.Text, comboBoxBinding.Text, textBoxPoints.Text, textBoxDx.Text, textBoxDy.Text);
                CreateFormForDraw();
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
                _formDraw = new FormDraw(_ctrl) {MdiParent = this};
                _formDraw.Show();
                _formDraw.StartPosition = FormStartPosition.CenterScreen;
                _formDraw.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
