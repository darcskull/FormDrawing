namespace курсов_проект
{
    partial class FormScene
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
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonRedraw = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxSurface = new System.Windows.Forms.TextBox();
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStripShape = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSurface = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPerimeter = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonFile = new System.Windows.Forms.Button();
            this.statusStripShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(666, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 0;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(660, 140);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(100, 23);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Colors Codes";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonRedraw
            // 
            this.buttonRedraw.Location = new System.Drawing.Point(713, 375);
            this.buttonRedraw.Name = "buttonRedraw";
            this.buttonRedraw.Size = new System.Drawing.Size(75, 23);
            this.buttonRedraw.TabIndex = 2;
            this.buttonRedraw.Text = "Redraw";
            this.buttonRedraw.UseVisualStyleBackColor = true;
            this.buttonRedraw.Click += new System.EventHandler(this.buttonRedraw_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(615, 375);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(660, 181);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCircle.TabIndex = 4;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(660, 204);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(63, 17);
            this.radioButtonTriangle.TabIndex = 5;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "Triangle";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Location = new System.Drawing.Point(660, 227);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(59, 17);
            this.radioButtonSquare.TabIndex = 6;
            this.radioButtonSquare.TabStop = true;
            this.radioButtonSquare.Text = "Square";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(660, 68);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxSize.TabIndex = 7;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(660, 114);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 8;
            // 
            // textBoxSurface
            // 
            this.textBoxSurface.Enabled = false;
            this.textBoxSurface.Location = new System.Drawing.Point(660, 281);
            this.textBoxSurface.Name = "textBoxSurface";
            this.textBoxSurface.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurface.TabIndex = 9;
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Enabled = false;
            this.textBoxPerimeter.Location = new System.Drawing.Point(660, 334);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxPerimeter.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add Color\'s Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Surface";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Perimeter";
            // 
            // statusStripShape
            // 
            this.statusStripShape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSurface,
            this.toolStripStatusLabelPerimeter});
            this.statusStripShape.Location = new System.Drawing.Point(0, 428);
            this.statusStripShape.Name = "statusStripShape";
            this.statusStripShape.Size = new System.Drawing.Size(800, 22);
            this.statusStripShape.TabIndex = 15;
            this.statusStripShape.Text = "statusStripShape";
            // 
            // toolStripStatusLabelSurface
            // 
            this.toolStripStatusLabelSurface.Name = "toolStripStatusLabelSurface";
            this.toolStripStatusLabelSurface.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabelSurface.Text = "Shapes Surface";
            // 
            // toolStripStatusLabelPerimeter
            // 
            this.toolStripStatusLabelPerimeter.Name = "toolStripStatusLabelPerimeter";
            this.toolStripStatusLabelPerimeter.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabelPerimeter.Text = "Shapes Perimeter";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(634, 402);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(126, 23);
            this.buttonFile.TabIndex = 16;
            this.buttonFile.Text = "Draw from file";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.statusStripShape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPerimeter);
            this.Controls.Add(this.textBoxSurface);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.radioButtonSquare);
            this.Controls.Add(this.radioButtonTriangle);
            this.Controls.Add(this.radioButtonCircle);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRedraw);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonHelp);
            this.Name = "FormScene";
            this.Text = "Scene";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.Load += new System.EventHandler(this.FormScene_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.statusStripShape.ResumeLayout(false);
            this.statusStripShape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonRedraw;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxSurface;
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStripShape;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSurface;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPerimeter;
        private System.Windows.Forms.Button buttonFile;
    }
}

