
namespace Cezar
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
            splitContainer1 = new SplitContainer();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(numericUpDown1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBox4);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(numericUpDown2);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Size = new Size(800, 556);
            splitContainer1.SplitterDistance = 269;
            splitContainer1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(26, 201);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(744, 51);
            textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(526, 144);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(647, 132);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "Klucz";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(578, 155);
            numericUpDown1.Maximum = new decimal(new int[] { 34, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(192, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(334, 7);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 3;
            label1.Text = "SZYFROWANIE";
            // 
            // button1
            // 
            button1.Location = new Point(578, 38);
            button1.Name = "button1";
            button1.Size = new Size(192, 71);
            button1.TabIndex = 1;
            button1.Text = "Szyfruj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(26, 220);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(744, 51);
            textBox4.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 59);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(526, 144);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(647, 153);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "Klucz";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(578, 176);
            numericUpDown2.Maximum = new decimal(new int[] { 34, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(192, 27);
            numericUpDown2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(321, 28);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 4;
            label2.Text = "DESZYFROWANIE";
            // 
            // button2
            // 
            button2.Location = new Point(578, 59);
            button2.Name = "button2";
            button2.Size = new Size(192, 72);
            button2.TabIndex = 2;
            button2.Text = "Deszyfruj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Szyfr Cezara";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox2;
    }
}
