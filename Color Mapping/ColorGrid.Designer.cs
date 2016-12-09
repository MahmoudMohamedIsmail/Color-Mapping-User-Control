namespace Color_Mapping
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorMapping = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Panel_Grid = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_value = new System.Windows.Forms.RadioButton();
            this.radio_color = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.G_color = new System.Windows.Forms.TextBox();
            this.R_color = new System.Windows.Forms.TextBox();
            this.Test_Value = new System.Windows.Forms.TextBox();
            this.B_color = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Smax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Smin = new System.Windows.Forms.TextBox();
            this.ColorGrid = new System.Windows.Forms.Label();
            this.Color_Grid = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ColorMapping.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorMapping
            // 
            this.ColorMapping.Controls.Add(this.groupBox3);
            this.ColorMapping.Controls.Add(this.groupBox2);
            this.ColorMapping.Controls.Add(this.groupBox1);
            this.ColorMapping.Controls.Add(this.ColorGrid);
            this.ColorMapping.Controls.Add(this.Color_Grid);
            this.ColorMapping.Location = new System.Drawing.Point(3, 3);
            this.ColorMapping.Name = "ColorMapping";
            this.ColorMapping.Size = new System.Drawing.Size(380, 215);
            this.ColorMapping.TabIndex = 0;
            this.ColorMapping.TabStop = false;
            this.ColorMapping.Text = "ColorMapping";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Panel_Grid);
            this.groupBox3.Location = new System.Drawing.Point(6, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 70);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // Panel_Grid
            // 
            this.Panel_Grid.Location = new System.Drawing.Point(9, 19);
            this.Panel_Grid.Name = "Panel_Grid";
            this.Panel_Grid.Size = new System.Drawing.Size(346, 43);
            this.Panel_Grid.TabIndex = 0;
            this.Panel_Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Grid_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_value);
            this.groupBox2.Controls.Add(this.radio_color);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.G_color);
            this.groupBox2.Controls.Add(this.R_color);
            this.groupBox2.Controls.Add(this.Test_Value);
            this.groupBox2.Controls.Add(this.B_color);
            this.groupBox2.Location = new System.Drawing.Point(155, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 115);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // radio_value
            // 
            this.radio_value.AutoSize = true;
            this.radio_value.Location = new System.Drawing.Point(3, 63);
            this.radio_value.Name = "radio_value";
            this.radio_value.Size = new System.Drawing.Size(52, 17);
            this.radio_value.TabIndex = 15;
            this.radio_value.TabStop = true;
            this.radio_value.Text = "Value";
            this.radio_value.UseVisualStyleBackColor = true;
            // 
            // radio_color
            // 
            this.radio_color.AutoSize = true;
            this.radio_color.Location = new System.Drawing.Point(3, 32);
            this.radio_color.Name = "radio_color";
            this.radio_color.Size = new System.Drawing.Size(49, 17);
            this.radio_color.TabIndex = 14;
            this.radio_color.TabStop = true;
            this.radio_color.Text = "Color";
            this.radio_color.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "R";
            // 
            // G_color
            // 
            this.G_color.Location = new System.Drawing.Point(108, 31);
            this.G_color.Name = "G_color";
            this.G_color.Size = new System.Drawing.Size(46, 20);
            this.G_color.TabIndex = 6;
            // 
            // R_color
            // 
            this.R_color.Location = new System.Drawing.Point(56, 31);
            this.R_color.Name = "R_color";
            this.R_color.Size = new System.Drawing.Size(46, 20);
            this.R_color.TabIndex = 5;
            // 
            // Test_Value
            // 
            this.Test_Value.Location = new System.Drawing.Point(56, 63);
            this.Test_Value.Name = "Test_Value";
            this.Test_Value.Size = new System.Drawing.Size(59, 20);
            this.Test_Value.TabIndex = 7;
            // 
            // B_color
            // 
            this.B_color.Location = new System.Drawing.Point(160, 31);
            this.B_color.Name = "B_color";
            this.B_color.Size = new System.Drawing.Size(46, 20);
            this.B_color.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Smax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Smin);
            this.groupBox1.Location = new System.Drawing.Point(6, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 82);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Smin";
            // 
            // Smax
            // 
            this.Smax.Location = new System.Drawing.Point(45, 52);
            this.Smax.Name = "Smax";
            this.Smax.Size = new System.Drawing.Size(70, 20);
            this.Smax.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Smax";
            // 
            // Smin
            // 
            this.Smin.Location = new System.Drawing.Point(45, 19);
            this.Smin.Name = "Smin";
            this.Smin.Size = new System.Drawing.Size(70, 20);
            this.Smin.TabIndex = 3;
            // 
            // ColorGrid
            // 
            this.ColorGrid.AutoSize = true;
            this.ColorGrid.Location = new System.Drawing.Point(3, 23);
            this.ColorGrid.Name = "ColorGrid";
            this.ColorGrid.Size = new System.Drawing.Size(50, 13);
            this.ColorGrid.TabIndex = 2;
            this.ColorGrid.Text = "ColorGrid";
            // 
            // Color_Grid
            // 
            this.Color_Grid.FormattingEnabled = true;
            this.Color_Grid.Items.AddRange(new object[] {
            "Discrete",
            "Continuous "});
            this.Color_Grid.Location = new System.Drawing.Point(59, 20);
            this.Color_Grid.Name = "Color_Grid";
            this.Color_Grid.Size = new System.Drawing.Size(90, 21);
            this.Color_Grid.TabIndex = 1;
            this.Color_Grid.SelectedIndexChanged += new System.EventHandler(this.Color_Grid_SelectedIndexChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorMapping);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(388, 224);
            this.ColorMapping.ResumeLayout(false);
            this.ColorMapping.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ColorMapping;
        private System.Windows.Forms.Label ColorGrid;
        private System.Windows.Forms.ComboBox Color_Grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Smax;
        private System.Windows.Forms.TextBox Test_Value;
        private System.Windows.Forms.TextBox G_color;
        private System.Windows.Forms.TextBox R_color;
        private System.Windows.Forms.TextBox B_color;
        private System.Windows.Forms.TextBox Smin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel Panel_Grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_value;
        private System.Windows.Forms.RadioButton radio_color;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}
