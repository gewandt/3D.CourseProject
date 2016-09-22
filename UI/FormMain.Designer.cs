namespace UI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDy = new System.Windows.Forms.TextBox();
            this.textBoxDx = new System.Windows.Forms.TextBox();
            this.labelSepPoints = new System.Windows.Forms.Label();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBinding = new System.Windows.Forms.ComboBox();
            this.textBoxRadius2 = new System.Windows.Forms.TextBox();
            this.textBoxHeight2 = new System.Windows.Forms.TextBox();
            this.textBoxRadius1 = new System.Windows.Forms.TextBox();
            this.textBoxHeight1 = new System.Windows.Forms.TextBox();
            this.pictureBoxSchema = new System.Windows.Forms.PictureBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.tabControlActions = new System.Windows.Forms.TabControl();
            this.tabPageMoove = new System.Windows.Forms.TabPage();
            this.buttonInc = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.labelDz = new System.Windows.Forms.Label();
            this.labelDy = new System.Windows.Forms.Label();
            this.labelDx = new System.Windows.Forms.Label();
            this.numericUpDownDz = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDx = new System.Windows.Forms.NumericUpDown();
            this.tabPageScale = new System.Windows.Forms.TabPage();
            this.groupBoxDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchema)).BeginInit();
            this.groupBoxActions.SuspendLayout();
            this.tabControlActions.SuspendLayout();
            this.tabPageMoove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.label7);
            this.groupBoxDescription.Controls.Add(this.buttonDraw);
            this.groupBoxDescription.Controls.Add(this.label6);
            this.groupBoxDescription.Controls.Add(this.textBoxDy);
            this.groupBoxDescription.Controls.Add(this.textBoxDx);
            this.groupBoxDescription.Controls.Add(this.labelSepPoints);
            this.groupBoxDescription.Controls.Add(this.textBoxPoints);
            this.groupBoxDescription.Controls.Add(this.label5);
            this.groupBoxDescription.Controls.Add(this.label4);
            this.groupBoxDescription.Controls.Add(this.label3);
            this.groupBoxDescription.Controls.Add(this.label2);
            this.groupBoxDescription.Controls.Add(this.label1);
            this.groupBoxDescription.Controls.Add(this.comboBoxBinding);
            this.groupBoxDescription.Controls.Add(this.textBoxRadius2);
            this.groupBoxDescription.Controls.Add(this.textBoxHeight2);
            this.groupBoxDescription.Controls.Add(this.textBoxRadius1);
            this.groupBoxDescription.Controls.Add(this.textBoxHeight1);
            this.groupBoxDescription.Controls.Add(this.pictureBoxSchema);
            this.groupBoxDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxDescription.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(249, 731);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Описание объекта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 668);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dy";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(6, 696);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(237, 23);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Построить";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dx";
            // 
            // textBoxDy
            // 
            this.textBoxDy.Location = new System.Drawing.Point(44, 665);
            this.textBoxDy.Name = "textBoxDy";
            this.textBoxDy.Size = new System.Drawing.Size(199, 20);
            this.textBoxDy.TabIndex = 14;
            this.textBoxDy.Text = "0";
            // 
            // textBoxDx
            // 
            this.textBoxDx.Location = new System.Drawing.Point(44, 638);
            this.textBoxDx.Name = "textBoxDx";
            this.textBoxDx.Size = new System.Drawing.Size(199, 20);
            this.textBoxDx.TabIndex = 13;
            this.textBoxDx.Text = "0";
            // 
            // labelSepPoints
            // 
            this.labelSepPoints.AutoSize = true;
            this.labelSepPoints.Location = new System.Drawing.Point(12, 614);
            this.labelSepPoints.Name = "labelSepPoints";
            this.labelSepPoints.Size = new System.Drawing.Size(21, 13);
            this.labelSepPoints.TabIndex = 12;
            this.labelSepPoints.Text = "ТА";
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(44, 611);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(199, 20);
            this.textBoxPoints.TabIndex = 11;
            this.textBoxPoints.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вариант крепления:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "R2 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "h2 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "R1 =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "h1 =";
            // 
            // comboBoxBinding
            // 
            this.comboBoxBinding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBinding.Items.AddRange(new object[] {
            "Сверху",
            "Снизу"});
            this.comboBoxBinding.Location = new System.Drawing.Point(6, 583);
            this.comboBoxBinding.Name = "comboBoxBinding";
            this.comboBoxBinding.Size = new System.Drawing.Size(237, 21);
            this.comboBoxBinding.TabIndex = 5;
            // 
            // textBoxRadius2
            // 
            this.textBoxRadius2.Location = new System.Drawing.Point(44, 536);
            this.textBoxRadius2.Name = "textBoxRadius2";
            this.textBoxRadius2.Size = new System.Drawing.Size(199, 20);
            this.textBoxRadius2.TabIndex = 4;
            this.textBoxRadius2.Text = "6";
            // 
            // textBoxHeight2
            // 
            this.textBoxHeight2.Location = new System.Drawing.Point(44, 510);
            this.textBoxHeight2.Name = "textBoxHeight2";
            this.textBoxHeight2.Size = new System.Drawing.Size(199, 20);
            this.textBoxHeight2.TabIndex = 3;
            this.textBoxHeight2.Text = "10";
            // 
            // textBoxRadius1
            // 
            this.textBoxRadius1.Location = new System.Drawing.Point(44, 484);
            this.textBoxRadius1.Name = "textBoxRadius1";
            this.textBoxRadius1.Size = new System.Drawing.Size(199, 20);
            this.textBoxRadius1.TabIndex = 2;
            this.textBoxRadius1.Text = "2";
            // 
            // textBoxHeight1
            // 
            this.textBoxHeight1.Location = new System.Drawing.Point(44, 458);
            this.textBoxHeight1.Name = "textBoxHeight1";
            this.textBoxHeight1.Size = new System.Drawing.Size(199, 20);
            this.textBoxHeight1.TabIndex = 1;
            this.textBoxHeight1.Text = "4";
            // 
            // pictureBoxSchema
            // 
            this.pictureBoxSchema.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxSchema.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxSchema.Name = "pictureBoxSchema";
            this.pictureBoxSchema.Size = new System.Drawing.Size(243, 240);
            this.pictureBoxSchema.TabIndex = 0;
            this.pictureBoxSchema.TabStop = false;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.tabControlActions);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxActions.Location = new System.Drawing.Point(249, 531);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(759, 200);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Действия";
            // 
            // tabControlActions
            // 
            this.tabControlActions.Controls.Add(this.tabPageMoove);
            this.tabControlActions.Controls.Add(this.tabPageScale);
            this.tabControlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlActions.Location = new System.Drawing.Point(3, 16);
            this.tabControlActions.Name = "tabControlActions";
            this.tabControlActions.SelectedIndex = 0;
            this.tabControlActions.Size = new System.Drawing.Size(753, 181);
            this.tabControlActions.TabIndex = 1;
            // 
            // tabPageMoove
            // 
            this.tabPageMoove.Controls.Add(this.buttonInc);
            this.tabPageMoove.Controls.Add(this.buttonDec);
            this.tabPageMoove.Controls.Add(this.labelDz);
            this.tabPageMoove.Controls.Add(this.labelDy);
            this.tabPageMoove.Controls.Add(this.labelDx);
            this.tabPageMoove.Controls.Add(this.numericUpDownDz);
            this.tabPageMoove.Controls.Add(this.numericUpDownDy);
            this.tabPageMoove.Controls.Add(this.numericUpDownDx);
            this.tabPageMoove.Location = new System.Drawing.Point(4, 22);
            this.tabPageMoove.Name = "tabPageMoove";
            this.tabPageMoove.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMoove.Size = new System.Drawing.Size(745, 155);
            this.tabPageMoove.TabIndex = 0;
            this.tabPageMoove.Text = "Смещение";
            this.tabPageMoove.UseVisualStyleBackColor = true;
            // 
            // buttonInc
            // 
            this.buttonInc.Location = new System.Drawing.Point(188, 62);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(75, 23);
            this.buttonInc.TabIndex = 9;
            this.buttonInc.Text = "-->";
            this.buttonInc.UseVisualStyleBackColor = true;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.Location = new System.Drawing.Point(106, 62);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(75, 23);
            this.buttonDec.TabIndex = 8;
            this.buttonDec.Text = "<--";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // labelDz
            // 
            this.labelDz.AutoSize = true;
            this.labelDz.Location = new System.Drawing.Point(24, 110);
            this.labelDz.Name = "labelDz";
            this.labelDz.Size = new System.Drawing.Size(22, 13);
            this.labelDz.TabIndex = 5;
            this.labelDz.Text = "DZ";
            // 
            // labelDy
            // 
            this.labelDy.AutoSize = true;
            this.labelDy.Location = new System.Drawing.Point(24, 67);
            this.labelDy.Name = "labelDy";
            this.labelDy.Size = new System.Drawing.Size(22, 13);
            this.labelDy.TabIndex = 4;
            this.labelDy.Text = "DY";
            // 
            // labelDx
            // 
            this.labelDx.AutoSize = true;
            this.labelDx.Location = new System.Drawing.Point(24, 25);
            this.labelDx.Name = "labelDx";
            this.labelDx.Size = new System.Drawing.Size(22, 13);
            this.labelDx.TabIndex = 3;
            this.labelDx.Text = "DX";
            // 
            // numericUpDownDz
            // 
            this.numericUpDownDz.Location = new System.Drawing.Point(49, 108);
            this.numericUpDownDz.Name = "numericUpDownDz";
            this.numericUpDownDz.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownDz.TabIndex = 2;
            // 
            // numericUpDownDy
            // 
            this.numericUpDownDy.Location = new System.Drawing.Point(49, 65);
            this.numericUpDownDy.Name = "numericUpDownDy";
            this.numericUpDownDy.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownDy.TabIndex = 1;
            // 
            // numericUpDownDx
            // 
            this.numericUpDownDx.Location = new System.Drawing.Point(49, 23);
            this.numericUpDownDx.Name = "numericUpDownDx";
            this.numericUpDownDx.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownDx.TabIndex = 0;
            // 
            // tabPageScale
            // 
            this.tabPageScale.Location = new System.Drawing.Point(4, 22);
            this.tabPageScale.Name = "tabPageScale";
            this.tabPageScale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScale.Size = new System.Drawing.Size(745, 155);
            this.tabPageScale.TabIndex = 1;
            this.tabPageScale.Text = "Масштабирование";
            this.tabPageScale.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 731);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxDescription);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchema)).EndInit();
            this.groupBoxActions.ResumeLayout(false);
            this.tabControlActions.ResumeLayout(false);
            this.tabPageMoove.ResumeLayout(false);
            this.tabPageMoove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.PictureBox pictureBoxSchema;
        private System.Windows.Forms.TextBox textBoxRadius2;
        private System.Windows.Forms.TextBox textBoxHeight2;
        private System.Windows.Forms.TextBox textBoxRadius1;
        private System.Windows.Forms.TextBox textBoxHeight1;
        private System.Windows.Forms.ComboBox comboBoxBinding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelSepPoints;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDy;
        private System.Windows.Forms.TextBox textBoxDx;
        private System.Windows.Forms.TabControl tabControlActions;
        private System.Windows.Forms.TabPage tabPageMoove;
        private System.Windows.Forms.TabPage tabPageScale;
        private System.Windows.Forms.Label labelDz;
        private System.Windows.Forms.Label labelDy;
        private System.Windows.Forms.Label labelDx;
        private System.Windows.Forms.NumericUpDown numericUpDownDz;
        private System.Windows.Forms.NumericUpDown numericUpDownDy;
        private System.Windows.Forms.NumericUpDown numericUpDownDx;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button buttonDec;
    }
}

