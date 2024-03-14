namespace Calculadora
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 22);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Média";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 8.25F);
            label2.Location = new Point(24, 60);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 1;
            label2.Text = "Nota 1:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 8.25F);
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(46, 16);
            label3.TabIndex = 3;
            label3.Text = "Nota 2:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8.25F);
            label4.Location = new Point(24, 171);
            label4.Name = "label4";
            label4.Size = new Size(46, 16);
            label4.TabIndex = 5;
            label4.Text = "Nota 4:";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(75, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8.25F);
            label5.Location = new Point(24, 136);
            label5.Name = "label5";
            label5.Size = new Size(46, 16);
            label5.TabIndex = 7;
            label5.Text = "Nota 3:";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(75, 163);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 8.25F);
            button1.Location = new Point(189, 117);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 8.25F);
            button2.Location = new Point(283, 117);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "LIMPAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 8.25F);
            label6.Location = new Point(57, 215);
            label6.Name = "label6";
            label6.Size = new Size(108, 16);
            label6.TabIndex = 11;
            label6.Text = "Média do aluno é:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 8.25F);
            label7.Location = new Point(196, 215);
            label7.Name = "label7";
            label7.Size = new Size(16, 16);
            label7.TabIndex = 12;
            label7.Text = "...";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 253);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label7;
    }
}
