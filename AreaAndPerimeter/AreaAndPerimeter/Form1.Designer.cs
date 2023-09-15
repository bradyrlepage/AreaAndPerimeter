namespace AreaAndPerimeter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LengthLabel=new Label();
            WidthLabel=new Label();
            AreaLabel=new Label();
            PerimeterLabel=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            textBox4=new TextBox();
            Calculate=new Button();
            Exit=new Button();
            SuspendLayout();
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize=true;
            LengthLabel.Location=new Point(39, 43);
            LengthLabel.Name="LengthLabel";
            LengthLabel.Size=new Size(47, 15);
            LengthLabel.TabIndex=0;
            LengthLabel.Text="Length:";
            LengthLabel.TextAlign=ContentAlignment.MiddleLeft;
            LengthLabel.Click+=label1_Click;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize=true;
            WidthLabel.Location=new Point(39, 72);
            WidthLabel.Name="WidthLabel";
            WidthLabel.Size=new Size(42, 15);
            WidthLabel.TabIndex=1;
            WidthLabel.Text="Width:";
            WidthLabel.TextAlign=ContentAlignment.MiddleLeft;
            WidthLabel.Click+=WidthLable_Click;
            // 
            // AreaLabel
            // 
            AreaLabel.AutoSize=true;
            AreaLabel.Location=new Point(39, 103);
            AreaLabel.Name="AreaLabel";
            AreaLabel.Size=new Size(34, 15);
            AreaLabel.TabIndex=2;
            AreaLabel.Text="Area:";
            AreaLabel.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // PerimeterLabel
            // 
            PerimeterLabel.AutoSize=true;
            PerimeterLabel.Location=new Point(39, 127);
            PerimeterLabel.Name="PerimeterLabel";
            PerimeterLabel.Size=new Size(61, 15);
            PerimeterLabel.TabIndex=3;
            PerimeterLabel.Text="Perimeter:";
            PerimeterLabel.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(141, 35);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=4;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(141, 64);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(100, 23);
            textBox2.TabIndex=5;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(141, 95);
            textBox3.Name="textBox3";
            textBox3.ReadOnly=true;
            textBox3.Size=new Size(100, 23);
            textBox3.TabIndex=6;
            // 
            // textBox4
            // 
            textBox4.Location=new Point(141, 124);
            textBox4.Name="textBox4";
            textBox4.ReadOnly=true;
            textBox4.Size=new Size(100, 23);
            textBox4.TabIndex=7;
            // 
            // Calculate
            // 
            Calculate.Location=new Point(25, 169);
            Calculate.Name="Calculate";
            Calculate.Size=new Size(91, 35);
            Calculate.TabIndex=8;
            Calculate.Text="&Calculate";
            Calculate.UseVisualStyleBackColor=true;
            Calculate.Click+=button1_Click;
            // 
            // Exit
            // 
            Exit.Location=new Point(179, 169);
            Exit.Name="Exit";
            Exit.Size=new Size(84, 35);
            Exit.TabIndex=9;
            Exit.Text="E&xit";
            Exit.UseVisualStyleBackColor=true;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(306, 241);
            Controls.Add(Exit);
            Controls.Add(Calculate);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(PerimeterLabel);
            Controls.Add(AreaLabel);
            Controls.Add(WidthLabel);
            Controls.Add(LengthLabel);
            Name="Form1";
            Text="AreaAndPerimeter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LengthLabel;
        private Label WidthLabel;
        private Label AreaLabel;
        private Label PerimeterLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Calculate;
        private Button Exit;
    }
}